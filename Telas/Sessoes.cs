using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoBan.Helpers;
using TrabalhoBan.Tabelas;
using TrabalhoBan.Telas.Auxiliares;

namespace TrabalhoBan.Telas
{
    public partial class Sessoes : UserControl
    {
        private bool _carregando = false;

        public Sessoes()
        {
            InitializeComponent();

            cabecalho1.AdicionarBotao("Iniciar Sessão", btnIniciar_Click);
            cabecalho1.AdicionarBotao("Adicionar Consumo", btnConsumo_Click);
            cabecalho1.AdicionarBotao("Encerrar Sessão", btnEncerrar_Click);
        }

        public async Task PopularSessoes()
        {
            object selecionada = ViewSessoes.ValorSelecionado("Codigo");

            string sql = @"SELECT s.codigo AS ""Codigo"",
                                  COALESCE(c.nome, 'Avulso') AS ""Cliente"",
                                  s.codigo_computador AS ""Computador"",
                                  s.hora_inicio AS ""Inicio"",
                                  '' AS ""Tempo"",
                                  COALESCE(p.valor_hora, 0) AS ""Valor Hora"",
                                  (SELECT COALESCE(SUM(co.quantidade * pr.preco), 0)
                                     FROM consumo co
                                     JOIN produto pr ON pr.codigo = co.codigo_produto
                                    WHERE co.codigo_sessao = s.codigo) AS ""Consumo"",
                                  '' AS ""Parcial""
                           FROM sessao s
                           JOIN computador p ON p.codigo = s.codigo_computador
                           LEFT JOIN cliente c ON c.cpf = s.cpf_cliente
                           WHERE s.hora_fim IS NULL";

            if (!string.IsNullOrWhiteSpace(cabecalho1.TextoPesquisa))
                sql += $@" AND (c.nome ILIKE '%{cabecalho1.TextoPesquisa}%' OR CAST(s.codigo_computador AS TEXT) = '{cabecalho1.TextoPesquisa}')";

            sql += " ORDER BY s.hora_inicio";

            _carregando = true;
            await ViewSessoes.Carregar(sql);

            if (selecionada != null)
                ViewSessoes.SelecionarLinha("Codigo", selecionada);
            _carregando = false;

            ViewSessoes.FormatarMoeda("Valor Hora", "Consumo");
            ViewSessoes.Columns["Inicio"].DefaultCellStyle.Format = "dd/MM HH:mm";

            await PopularConsumo();
        }

        public async Task PopularConsumo()
        {
            object codigoSessao = ViewSessoes.ValorSelecionado("Codigo");

            if (codigoSessao == null)
            {
                ViewConsumo.DataSource = null;
                lblConsumo.Text = "Consumo da sessão";
                return;
            }

            string sql = $@"SELECT co.codigo AS ""Codigo"", p.nome AS ""Produto"", co.quantidade AS ""Quantidade"",
                                   p.preco AS ""Preco"", co.quantidade * p.preco AS ""Total"", co.data AS ""Hora""
                            FROM consumo co
                            JOIN produto p ON p.codigo = co.codigo_produto
                            WHERE co.codigo_sessao = {codigoSessao}
                            ORDER BY co.data";

            await ViewConsumo.Carregar(sql);
            ViewConsumo.FormatarMoeda("Preco", "Total");
            ViewConsumo.Columns["Hora"].DefaultCellStyle.Format = "HH:mm";

            lblConsumo.Text = $"Consumo da sessão #{codigoSessao}  -  Total: {ViewConsumo.Somar("Total"):C2}";
        }

        public async Task RemoverConsumo(long codigo)
        {
            string sql = $@"UPDATE produto SET estoque = COALESCE(produto.estoque, 0) + co.quantidade
                            FROM consumo co
                            WHERE co.codigo = {codigo} AND produto.codigo = co.codigo_produto;

                            DELETE FROM consumo WHERE codigo = {codigo};";

            await Database.EscreverAsync(sql);
            await PopularSessoes();
        }

        private long? SessaoSelecionada()
        {
            object codigo = ViewSessoes.ValorSelecionado("Codigo");

            if (codigo == null)
            {
                MessageBox.Show("Selecione uma sessão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return Convert.ToInt64(codigo);
        }

        private async void Sessoes_Load(object sender, EventArgs e)
        {
            await PopularSessoes();
            timer1.Start();
        }

        private async void cabecalho1_Pesquisar(object sender, EventArgs e)
        {
            await PopularSessoes();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            frmIniciarSessao frm = new frmIniciarSessao(this);

            frm.ShowDialog();
        }

        private void btnConsumo_Click(object sender, EventArgs e)
        {
            long? codigo = SessaoSelecionada();

            if (codigo == null)
                return;

            frmConsumo frm = new frmConsumo(this, codigo.Value);

            frm.ShowDialog();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            long? codigo = SessaoSelecionada();

            if (codigo == null)
                return;

            frmEncerrarSessao frm = new frmEncerrarSessao(this, codigo.Value);

            frm.ShowDialog();
        }

        private async void btnRemoverConsumo_Click(object sender, EventArgs e)
        {
            object codigo = ViewConsumo.ValorSelecionado("Codigo");

            if (codigo == null)
                return;

            string produto = ViewConsumo.ValorSelecionado("Produto").ToString();

            if (MessageBox.Show($"Remover {produto} da sessão? O produto volta pro estoque.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                await RemoverConsumo(Convert.ToInt64(codigo));
        }

        private async void ViewSessoes_SelectionChanged(object sender, EventArgs e)
        {
            if (!_carregando)
                await PopularConsumo();
        }

        private void ViewSessoes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string coluna = ViewSessoes.Columns[e.ColumnIndex].Name;

            if (coluna != "Tempo" && coluna != "Parcial")
                return;

            DataGridViewRow row = ViewSessoes.Rows[e.RowIndex];
            DateTime inicio = Convert.ToDateTime(row.Cells["Inicio"].Value);

            if (coluna == "Tempo")
            {
                e.Value = Cobranca.FormatarTempo(DateTime.Now - inicio);
            }
            else
            {
                decimal valorHora = Convert.ToDecimal(row.Cells["Valor Hora"].Value);
                decimal consumo = Convert.ToDecimal(row.Cells["Consumo"].Value);

                e.Value = (Cobranca.ValorTempo(inicio, DateTime.Now, valorHora) + consumo).ToString("C2");
            }

            e.FormattingApplied = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Parent == null)
            {
                timer1.Stop();
                return;
            }

            ViewSessoes.Invalidate();
        }
    }
}
