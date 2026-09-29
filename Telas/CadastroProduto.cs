using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using TrabalhoBan.Helpers;
using TrabalhoBan.Tabelas;
using TrabalhoBan.Telas.Auxiliares;

namespace TrabalhoBan.Telas
{
    public partial class CadastroProduto : UserControl
    {
        public CadastroProduto()
        {
            InitializeComponent();

            cabecalho1.AdicionarBotao("Adicionar Produto", btnAdicionar_Click);
            cabecalho1.AdicionarBotao("Editar", btnEditar_Click);
            cabecalho1.AdicionarBotao("Repor Estoque", btnReporEstoque_Click);
            cabecalho1.AdicionarBotao("Remover", btnRemover_Click);
        }

        public async Task PopularProdutos()
        {
            string sql = @"SELECT codigo AS ""Codigo"", nome AS ""Nome"", categoria AS ""Categoria"",
                                  preco AS ""Preco"", estoque AS ""Estoque""
                           FROM produto";

            if (!string.IsNullOrWhiteSpace(cabecalho1.TextoPesquisa))
                sql += $" WHERE nome ILIKE '%{cabecalho1.TextoPesquisa}%'";

            sql += " ORDER BY nome";

            await ViewProdutos.Carregar(sql);
            ViewProdutos.FormatarMoeda("Preco");
        }

        public async Task RemoverProduto(long codigo)
        {
            string sql = $@"DELETE FROM produto WHERE codigo = {codigo}";

            try
            {
                await Database.EscreverAsync(sql);
            }
            catch (PostgresException ex) when (ex.SqlState == PostgresErrorCodes.ForeignKeyViolation)
            {
                MessageBox.Show("Esse produto ja foi consumido em alguma sessão, não da pra remover.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            await PopularProdutos();
        }

        public async Task ReporEstoque(long codigo, int quantidade)
        {
            string sql = $@"UPDATE produto SET estoque = COALESCE(estoque, 0) + {quantidade} WHERE codigo = {codigo}";

            await Database.EscreverAsync(sql);
            await PopularProdutos();
        }

        private void EditarProduto()
        {
            object codigo = ViewProdutos.ValorSelecionado("Codigo");

            if (codigo == null)
                return;

            frmCadastroProduto frm = new frmCadastroProduto(this, Convert.ToInt64(codigo));

            frm.ShowDialog();
        }

        private async void CadastroProduto_Load(object sender, EventArgs e)
        {
            await PopularProdutos();
        }

        private async void cabecalho1_Pesquisar(object sender, EventArgs e)
        {
            await PopularProdutos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frm = new frmCadastroProduto(this);

            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarProduto();
        }

        private async void btnReporEstoque_Click(object sender, EventArgs e)
        {
            object codigo = ViewProdutos.ValorSelecionado("Codigo");

            if (codigo == null)
                return;

            string nome = ViewProdutos.ValorSelecionado("Nome").ToString();
            int? quantidade = frmQuantidade.Perguntar("Repor Estoque", $"Quantas unidades de {nome} chegaram?");

            if (quantidade != null)
                await ReporEstoque(Convert.ToInt64(codigo), quantidade.Value);
        }

        private async void btnRemover_Click(object sender, EventArgs e)
        {
            object codigo = ViewProdutos.ValorSelecionado("Codigo");

            if (codigo == null)
                return;

            string nome = ViewProdutos.ValorSelecionado("Nome").ToString();

            if (MessageBox.Show($"Deletar o produto {nome}", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                await RemoverProduto(Convert.ToInt64(codigo));
        }

        private void ViewProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                EditarProduto();
        }

        private void ViewProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string coluna = ViewProdutos.Columns[e.ColumnIndex].Name;

            if (e.Value == null || e.Value == DBNull.Value)
                return;

            if (coluna == "Categoria")
            {
                e.Value = ((eCategoriaProduto)Convert.ToInt32(e.Value)).ToString();
                e.FormattingApplied = true;
            }

            if (coluna == "Estoque" && Convert.ToInt32(e.Value) < 5)
                e.CellStyle.BackColor = Color.DarkRed;
        }
    }
}
