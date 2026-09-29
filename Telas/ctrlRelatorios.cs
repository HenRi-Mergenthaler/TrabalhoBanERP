using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoBan.Telas
{
    public partial class ctrlRelatorios : UserControl
    {
        private const string SqlFormaPagamento = @"CASE forma_de_pagamento
                                                       WHEN 0 THEN 'Dinheiro'
                                                       WHEN 1 THEN 'Pix'
                                                       WHEN 2 THEN 'Cartão de Débito'
                                                       WHEN 3 THEN 'Cartão de Crédito'
                                                   END";

        public ctrlRelatorios()
        {
            InitializeComponent();

            cabecalho1.AdicionarBotao("Gerar Relatório", btnGerar_Click);

            campoRelatorio.CarregarItens("Pagamentos recebidos",
                                         "Faturamento por forma de pagamento",
                                         "Produtos mais vendidos",
                                         "Uso dos computadores",
                                         "Clientes que mais gastaram");

            campoDe.Valor = DateTime.Today.AddDays(-30);
            campoAte.Valor = DateTime.Today;
        }

        public async Task GerarRelatorio()
        {
            if (campoDe.Valor.Date > campoAte.Valor.Date)
            {
                MessageBox.Show("A data inicial é maior que a final.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string de = campoDe.Valor.ToString("yyyy-MM-dd");
            string ate = campoAte.Valor.AddDays(1).ToString("yyyy-MM-dd");

            string sql = "";
            string colunaTotal = "";

            switch (campoRelatorio.IndiceSelecionado)
            {
                case 0:
                    sql = $@"SELECT pg.codigo AS ""Codigo"", pg.data AS ""Data"",
                                    COALESCE(cl.nome, 'Avulso') AS ""Cliente"",
                                    s.codigo_computador AS ""Computador"",
                                    {SqlFormaPagamento} AS ""Forma de Pagamento"",
                                    pg.valor AS ""Valor""
                             FROM pagamento pg
                             JOIN sessao s ON s.codigo = pg.codigo_sessao
                             LEFT JOIN cliente cl ON cl.cpf = s.cpf_cliente
                             WHERE pg.data >= '{de}' AND pg.data < '{ate}'
                             ORDER BY pg.data DESC";
                    colunaTotal = "Valor";
                    break;

                case 1:
                    sql = $@"SELECT {SqlFormaPagamento} AS ""Forma de Pagamento"",
                                    COUNT(*) AS ""Quantidade"",
                                    ROUND(AVG(valor)::numeric, 2) AS ""Ticket Medio"",
                                    SUM(valor) AS ""Total""
                             FROM pagamento
                             WHERE data >= '{de}' AND data < '{ate}'
                             GROUP BY forma_de_pagamento
                             ORDER BY ""Total"" DESC";
                    colunaTotal = "Total";
                    break;

                case 2:
                    sql = $@"SELECT p.nome AS ""Produto"",
                                    SUM(co.quantidade) AS ""Quantidade"",
                                    SUM(co.quantidade * p.preco) AS ""Total""
                             FROM consumo co
                             JOIN produto p ON p.codigo = co.codigo_produto
                             WHERE co.data >= '{de}' AND co.data < '{ate}'
                             GROUP BY p.codigo, p.nome
                             ORDER BY ""Quantidade"" DESC";
                    colunaTotal = "Total";
                    break;

                case 3:
                    sql = $@"SELECT c.codigo AS ""Computador"", c.processador AS ""Processador"",
                                    COUNT(s.codigo) AS ""Sessoes"",
                                    ROUND(COALESCE(SUM(EXTRACT(EPOCH FROM (s.hora_fim - s.hora_inicio)) / 3600), 0)::numeric, 2) AS ""Horas de Uso"",
                                    COALESCE(SUM(pg.valor), 0) AS ""Faturamento""
                             FROM computador c
                             LEFT JOIN sessao s ON s.codigo_computador = c.codigo
                                               AND s.hora_fim IS NOT NULL
                                               AND s.hora_inicio >= '{de}' AND s.hora_inicio < '{ate}'
                             LEFT JOIN pagamento pg ON pg.codigo_sessao = s.codigo
                             GROUP BY c.codigo, c.processador
                             ORDER BY ""Horas de Uso"" DESC, c.codigo";
                    colunaTotal = "Faturamento";
                    break;

                case 4:
                    sql = $@"SELECT cl.nome AS ""Cliente"", cl.cpf AS ""CPF"",
                                    COUNT(pg.codigo) AS ""Sessoes"",
                                    SUM(pg.valor) AS ""Total Gasto""
                             FROM pagamento pg
                             JOIN sessao s ON s.codigo = pg.codigo_sessao
                             JOIN cliente cl ON cl.cpf = s.cpf_cliente
                             WHERE pg.data >= '{de}' AND pg.data < '{ate}'
                             GROUP BY cl.cpf, cl.nome
                             ORDER BY ""Total Gasto"" DESC
                             LIMIT 20";
                    colunaTotal = "Total Gasto";
                    break;
            }

            await ViewRelatorio.Carregar(sql);
            ViewRelatorio.FormatarMoeda("Valor", "Total", "Ticket Medio", "Faturamento", "Total Gasto");

            lblTotal.Text = $"{ViewRelatorio.Rows.Count} registro(s)   |   Total: {ViewRelatorio.Somar(colunaTotal):C2}";
        }

        private async void ctrlRelatorios_Load(object sender, EventArgs e)
        {
            await GerarRelatorio();
        }

        private async void btnGerar_Click(object sender, EventArgs e)
        {
            await GerarRelatorio();
        }

        private async void campoRelatorio_ItemSelecionado(object sender, EventArgs e)
        {
            if (Created)
                await GerarRelatorio();
        }
    }
}
