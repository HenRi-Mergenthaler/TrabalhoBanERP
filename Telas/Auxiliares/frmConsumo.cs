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

namespace TrabalhoBan.Telas.Auxiliares
{
    public partial class frmConsumo : Form
    {
        Sessoes sessoes;
        long codigoSessao;

        public frmConsumo(Sessoes sessoes, long codigoSessao)
        {
            InitializeComponent();
            this.sessoes = sessoes;
            this.codigoSessao = codigoSessao;

            Text = $"Adicionar Consumo - Sessão #{codigoSessao}";
        }

        private async void frmConsumo_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT codigo, preco, estoque,
                                  nome || '  (R$ ' || to_char(preco, 'FM9990.00') || ' - estoque: ' || estoque || ')' AS descricao
                           FROM produto
                           WHERE estoque > 0 AND preco IS NOT NULL
                           ORDER BY nome";

            DataTable produtos = await Database.LerAsync(sql);

            if (produtos.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum produto com estoque.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            campoProduto.Carregar(produtos, "descricao", "codigo");
            AtualizarTotal();
        }

        private void AtualizarTotal()
        {
            DataRow produto = campoProduto.LinhaSelecionada;

            if (produto == null)
                return;

            decimal total = Convert.ToDecimal(produto["preco"]) * campoQuantidade.Valor;

            lblTotal.Text = $"Total: {total:C2}";
        }

        private async Task SalvarConsumo()
        {
            long codigoProduto = Convert.ToInt64(campoProduto.ValorSelecionado);
            int quantidade = (int)campoQuantidade.Valor;

            string sql = $@"INSERT INTO consumo (quantidade, data, codigo_sessao, codigo_produto)
                            VALUES ({quantidade}, '{DateTime.Now:yyyy-MM-dd HH:mm:ss}', {codigoSessao}, {codigoProduto});

                            UPDATE produto SET estoque = estoque - {quantidade} WHERE codigo = {codigoProduto};";

            await Database.EscreverAsync(sql);
        }

        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            DataRow produto = campoProduto.LinhaSelecionada;

            if (produto == null)
                return;

            int estoque = Convert.ToInt32(produto["estoque"]);

            if (campoQuantidade.Valor > estoque)
            {
                MessageBox.Show($"So tem {estoque} unidade(s) desse produto no estoque.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                await SalvarConsumo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar o consumo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await sessoes.PopularSessoes();
            this.Close();
        }

        private void campoProduto_ItemSelecionado(object sender, EventArgs e)
        {
            AtualizarTotal();
        }

        private void campoQuantidade_ValorAlterado(object sender, EventArgs e)
        {
            AtualizarTotal();
        }
    }
}
