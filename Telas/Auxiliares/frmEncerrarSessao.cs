using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoBan.Helpers;
using TrabalhoBan.Tabelas;
using static TrabalhoBan.Telas.Auxiliares.frmComprarComputador;

namespace TrabalhoBan.Telas.Auxiliares
{
    public partial class frmEncerrarSessao : Form
    {
        Sessoes sessoes;
        long codigoSessao;
        long codigoComputador;
        string cliente = "";
        DateTime inicio;
        DateTime fim;
        decimal valorHora;
        decimal valorCorujao;
        decimal valorConsumo;

        public frmEncerrarSessao(Sessoes sessoes, long codigoSessao)
        {
            InitializeComponent();
            this.sessoes = sessoes;
            this.codigoSessao = codigoSessao;

            Text = $"Encerrar Sessão #{codigoSessao}";
            campoPagamento.CarregarEnum<eFormaPagamento>();
        }

        private async void frmEncerrarSessao_Load(object sender, EventArgs e)
        {
            string sql = $@"SELECT s.hora_inicio, s.codigo_computador,
                                   COALESCE(c.nome, 'Avulso') AS cliente,
                                   COALESCE(p.valor_hora, 0) AS valor_hora,
                                   COALESCE(p.valor_corujao, 0) AS valor_corujao,
                                   (SELECT COALESCE(SUM(co.quantidade * pr.preco), 0)
                                      FROM consumo co
                                      JOIN produto pr ON pr.codigo = co.codigo_produto
                                     WHERE co.codigo_sessao = s.codigo) AS consumo
                            FROM sessao s
                            JOIN computador p ON p.codigo = s.codigo_computador
                            LEFT JOIN cliente c ON c.cpf = s.cpf_cliente
                            WHERE s.codigo = {codigoSessao}";

            DataTable tabela = await Database.LerAsync(sql);
            DataRow row = tabela.Rows[0];

            inicio = Convert.ToDateTime(row["hora_inicio"]);
            fim = DateTime.Now;
            codigoComputador = Convert.ToInt64(row["codigo_computador"]);
            cliente = row["cliente"].ToString();
            valorHora = Convert.ToDecimal(row["valor_hora"]);
            valorCorujao = Convert.ToDecimal(row["valor_corujao"]);
            valorConsumo = Convert.ToDecimal(row["consumo"]);

            chkCorujao.Text = $"Cobrar como Corujão (valor fixo de {valorCorujao:C2})";
            chkCorujao.Checked = Cobranca.EhCorujao(inicio);

            AtualizarResumo();
            btnConfirmar.Enabled = true;
        }

        private decimal ValorTempo()
        {
            if (chkCorujao.Checked)
                return valorCorujao;

            return Cobranca.ValorTempo(inicio, fim, valorHora);
        }

        private decimal ValorTotal()
        {
            return ValorTempo() + valorConsumo;
        }

        private void AtualizarResumo()
        {
            lblResumo.Text = $"Cliente: {cliente}\n" +
                             $"Computador: {codigoComputador}\n" +
                             $"Inicio: {inicio:dd/MM/yyyy HH:mm}\n" +
                             $"Fim: {fim:dd/MM/yyyy HH:mm}\n" +
                             $"Tempo de uso: {Cobranca.FormatarTempo(fim - inicio)}\n\n" +
                             $"Valor do tempo: {ValorTempo():C2}  ({valorHora:C2}/hora, minimo 30 min)\n" +
                             $"Consumo: {valorConsumo:C2}";

            lblTotal.Text = $"Total: {ValorTotal():C2}";
        }

        private async Task SalvarPagamento()
        {
            string dataFim = fim.ToString("yyyy-MM-dd HH:mm:ss");
            string total = ValorTotal().ToString(CultureInfo.InvariantCulture);
            int forma = Convert.ToInt32(campoPagamento.ValorSelecionado);

            string sql = $@"UPDATE sessao SET hora_fim = '{dataFim}' WHERE codigo = {codigoSessao};

                            UPDATE computador SET status = {(int)eStatus.Livre} WHERE codigo = {codigoComputador};

                            INSERT INTO pagamento (data, valor, forma_de_pagamento, codigo_sessao)
                            VALUES ('{dataFim}', {total}, {forma}, {codigoSessao});";

            await Database.EscreverAsync(sql);
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                await SalvarPagamento();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao encerrar a sessão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Sessão encerrada! Recebido {ValorTotal():C2} em {campoPagamento.ValorSelecionado}.", "Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            await sessoes.PopularSessoes();
            this.Close();
        }

        private void chkCorujao_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarResumo();
        }
    }
}
