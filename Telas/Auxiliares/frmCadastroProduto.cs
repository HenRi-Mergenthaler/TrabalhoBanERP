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

namespace TrabalhoBan.Telas.Auxiliares
{
    public partial class frmCadastroProduto : Form
    {
        CadastroProduto produtos;
        long? codigoEdicao = null;

        public frmCadastroProduto(CadastroProduto produtos, long? codigo = null)
        {
            InitializeComponent();
            this.produtos = produtos;
            this.codigoEdicao = codigo;

            campoCategoria.CarregarEnum<eCategoriaProduto>();
        }

        private async void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            if (codigoEdicao == null)
                return;

            Text = "Editar Produto";

            DataTable tabela = await Database.LerAsync($"SELECT * FROM produto WHERE codigo = {codigoEdicao}");
            DataRow row = tabela.Rows[0];

            campoNome.Valor = row["nome"].ToString();

            if (row["categoria"] != DBNull.Value)
                campoCategoria.Selecionar((eCategoriaProduto)Convert.ToInt32(row["categoria"]));

            if (row["preco"] != DBNull.Value)
                campoPreco.Valor = Convert.ToDecimal(row["preco"]);

            if (row["estoque"] != DBNull.Value)
                campoEstoque.Valor = Convert.ToInt32(row["estoque"]);
        }

        private async Task SalvarProduto()
        {
            string nome = campoNome.ValorSql;
            int categoria = Convert.ToInt32(campoCategoria.ValorSelecionado);
            string preco = campoPreco.ValorSql;
            int estoque = (int)campoEstoque.Valor;

            string sql = $@"INSERT INTO produto (nome, categoria, preco, estoque)
                            VALUES ('{nome}', {categoria}, {preco}, {estoque})";

            if (codigoEdicao != null)
                sql = $@"UPDATE produto SET nome = '{nome}', categoria = {categoria}, preco = {preco}, estoque = {estoque}
                         WHERE codigo = {codigoEdicao}";

            await Database.EscreverAsync(sql);
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(campoNome.Valor))
            {
                MessageBox.Show("Informe o nome do produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (campoPreco.Valor <= 0)
            {
                MessageBox.Show("Informe o preço do produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                await SalvarProduto();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await produtos.PopularProdutos();
            this.Close();
        }
    }
}
