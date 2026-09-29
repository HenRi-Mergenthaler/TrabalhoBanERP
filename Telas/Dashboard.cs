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

namespace TrabalhoBan.Telas
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();

            cabecalho1.AdicionarBotao("Atualizar", btnAtualizar_Click);
        }

        public async Task PopularCards()
        {
            string hoje = DateTime.Today.ToString("yyyy-MM-dd");

            string sql = $@"SELECT (SELECT COUNT(*) FROM computador WHERE status = 0) AS livres,
                                   (SELECT COUNT(*) FROM computador) AS computadores,
                                   (SELECT COUNT(*) FROM sessao WHERE hora_fim IS NULL) AS sessoes,
                                   (SELECT COALESCE(SUM(valor), 0) FROM pagamento WHERE data >= '{hoje}') AS faturamento,
                                   (SELECT COUNT(*) FROM produto WHERE estoque < 5) AS estoque_baixo";

            DataTable tabela = await Database.LerAsync(sql);
            DataRow row = tabela.Rows[0];

            cardLivres.Valor = $"{row["livres"]} / {row["computadores"]}";
            cardSessoes.Valor = row["sessoes"].ToString();
            cardFaturamento.Valor = Convert.ToDecimal(row["faturamento"]).ToString("C2");
            cardEstoque.Valor = row["estoque_baixo"].ToString();
        }

        public async Task PopularComputadores()
        {
            string sql = @"SELECT c.codigo AS ""Computador"",
                                  c.processador AS ""Processador"",
                                  c.status AS ""Status"",
                                  CASE WHEN s.codigo IS NOT NULL THEN COALESCE(cl.nome, 'Avulso') END AS ""Cliente"",
                                  s.hora_inicio AS ""Desde""
                           FROM computador c
                           LEFT JOIN sessao s ON s.codigo_computador = c.codigo AND s.hora_fim IS NULL
                           LEFT JOIN cliente cl ON cl.cpf = s.cpf_cliente
                           ORDER BY c.codigo";

            await ViewComputadores.Carregar(sql);
            ViewComputadores.Columns["Desde"].DefaultCellStyle.Format = "dd/MM HH:mm";
        }

        private async Task Atualizar()
        {
            await PopularCards();
            await PopularComputadores();
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            await Atualizar();
        }

        private async void btnAtualizar_Click(object sender, EventArgs e)
        {
            await Atualizar();
        }

        private void ViewComputadores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ViewComputadores.Columns[e.ColumnIndex].Name == "Status")
                Computadores.FormatarStatus(e);
        }
    }
}
