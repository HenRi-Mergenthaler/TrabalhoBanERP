using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TrabalhoBan.Helpers;

namespace TrabalhoBan.Telas.Auxiliares
{
    public partial class frmComprarComputador : Form
    {
        Computadores computadores;
        public frmComprarComputador(Computadores computadores)
        {
            InitializeComponent();
            this.computadores = computadores;
        }

        private async Task SalvarComputador()
        {
            string processador = txtProcessador.Text;
            string placaDeVideo = txtPlacaDeVideo.Text;
            int memoria = Convert.ToInt32(comboRam.Text);
            int status = (int)eStatus.Livre;
            decimal valorHora = nmValorHora.Value;
            decimal valorCorujao = numValorCorujao.Value;

            string sql = $@"INSERT INTO computador (processador, placa_de_video, memoria_ram, status, valor_hora, valor_corujao)
                                VALUES ('{processador}', '{placaDeVideo}', {memoria}, {status}, {valorHora}, {valorCorujao})";

            await Database.EscreverAsync(sql);
            await SalvarCompra();

        }

        private async Task SalvarCompra()
        {
            DateTime data = dateCompra.Value;
            decimal valor = numValor.Value;
            string fornecedor = txtFornecedor.Text;
            long nf = Convert.ToInt64(txtNota.Text);
            long codigoComputador = await GetCodigoComputador();

            string sql = $@"INSERT INTO aquisicao (data, valor, fornecedor, nota_fiscal, codigo_computador)
                            VALUES ('{data:yyyy-MM-dd HH:mm:ss}', {valor}, '{fornecedor}', {nf}, {codigoComputador})";

            await Database.EscreverAsync(sql);
        }

        private async Task<long> GetCodigoComputador()
        {
            string sql = "SELECT MAX(codigo) FROM computador";

            DataTable table = await Database.LerAsync(sql);

            return table.Rows[0].Field<long>("max");
        } 

        private async void button1_Click(object sender, EventArgs e)
        {
            await SalvarComputador();
            computadores.PopularComputadores();
            this.Close();
        }

        public enum eStatus
        {
            Livre = 0,
            Ocupado = 1,
            Indisponivel = 2
        }
    }
}
