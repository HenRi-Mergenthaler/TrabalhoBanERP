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
using static TrabalhoBan.Telas.Auxiliares.frmComprarComputador;

namespace TrabalhoBan.Telas.Auxiliares
{
    public partial class frmIniciarSessao : Form
    {
        Sessoes sessoes;

        public frmIniciarSessao(Sessoes sessoes)
        {
            InitializeComponent();
            this.sessoes = sessoes;
        }

        private async void frmIniciarSessao_Load(object sender, EventArgs e)
        {
            string sqlClientes = @"SELECT 0 AS cpf, '(Avulso - sem cadastro)' AS nome
                                   UNION ALL
                                   (SELECT cpf, nome FROM cliente ORDER BY nome)";

            string sqlComputadores = $@"SELECT codigo,
                                               'PC ' || codigo || ' - ' || processador || '  (R$ ' || to_char(valor_hora, 'FM9990.00') || '/hora)' AS descricao
                                        FROM computador
                                        WHERE status = {(int)eStatus.Livre}
                                        ORDER BY codigo";

            DataTable computadores = await Database.LerAsync(sqlComputadores);

            if (computadores.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum computador livre no momento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            campoComputador.Carregar(computadores, "descricao", "codigo");
            campoCliente.Carregar(await Database.LerAsync(sqlClientes), "nome", "cpf");
        }

        private async Task<bool> ClienteJaTemSessao(long cpf)
        {
            string sql = $@"SELECT codigo_computador FROM sessao WHERE cpf_cliente = {cpf} AND hora_fim IS NULL";

            DataTable tabela = await Database.LerAsync(sql);

            if (tabela.Rows.Count > 0)
            {
                MessageBox.Show($"Esse cliente ja esta usando o computador {tabela.Rows[0]["codigo_computador"]}.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private async Task IniciarSessao()
        {
            long cpf = Convert.ToInt64(campoCliente.ValorSelecionado);
            long computador = Convert.ToInt64(campoComputador.ValorSelecionado);
            string cpfCliente = cpf == 0 ? "NULL" : cpf.ToString();

            string sql = $@"INSERT INTO sessao (hora_inicio, cpf_cliente, codigo_computador)
                            VALUES ('{DateTime.Now:yyyy-MM-dd HH:mm:ss}', {cpfCliente}, {computador});

                            UPDATE computador SET status = {(int)eStatus.Ocupado} WHERE codigo = {computador};";

            await Database.EscreverAsync(sql);
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            if (campoCliente.ValorSelecionado == null || campoComputador.ValorSelecionado == null)
                return;

            long cpf = Convert.ToInt64(campoCliente.ValorSelecionado);

            if (cpf != 0 && await ClienteJaTemSessao(cpf))
                return;

            try
            {
                await IniciarSessao();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao iniciar a sessão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await sessoes.PopularSessoes();
            this.Close();
        }
    }
}
