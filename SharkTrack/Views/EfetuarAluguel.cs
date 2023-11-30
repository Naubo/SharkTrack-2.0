using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharkTrack.Views
{
    public partial class EfetuarAluguel : Form
    {

        int idCarro = 0;
        int idCliente = 0;
        public EfetuarAluguel()
        {
            InitializeComponent();
            //instanciar
            Classes.Carros carro =  new Classes.Carros();
            Classes.Clientes clientes = new Classes.Clientes();

            dgvCarro.DataSource = carro.ListarTudo();
            dgvCliente.DataSource = clientes.ListarTudo();

        }

        // btn confirmar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //instanciar Cliente:
            Classes.Aluguel aluguel = new Classes.Aluguel();

            //obter valores dos campos
            aluguel.Id_usuario = idCliente;
            aluguel.Id_carro = idCarro;
            aluguel.Data_retirada = dtpRetirada.Value;
            aluguel.Data_devolucao = dtpDevolucao.Value;

            if (aluguel.Cadastrar() == true)
            {
                MessageBox.Show("Aluguel feito com sucesso!");

                //limpar os campos
                txbNomeEdit.Clear();
                txbCpfEdit.Clear();
                txbMarca.Clear();
                txbModelo.Clear();
                txbAno.Clear();
                txbPlaca.Clear();
                txbPreco.Clear();
                txbQuilom.Clear();
            }
            else
            {
                MessageBox.Show("Falha ao Alugar o automovel!");
            }
        }

        private void dgvCarro_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //obter linha clicada
            int linhaSelecionada = dgvCarro.CurrentCell.RowIndex;

            //armazenar os dados da linha clicada em linha (tipo um vetor)
            var linha = dgvCarro.Rows[linhaSelecionada];

            txbMarca.Text = linha.Cells[1].Value.ToString();
            txbModelo.Text = linha.Cells[2].Value.ToString();
            txbAno.Text = linha.Cells[3].Value.ToString();
            txbPlaca.Text = linha.Cells[4].Value.ToString();
            txbPreco.Text = linha.Cells[5].Value.ToString();
            txbQuilom.Text = linha.Cells[6].Value.ToString();


            //Salvar o id na variavel global
            idCarro = (int)linha.Cells[0].Value;
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //obter linha clicada
            int linhaSelecionada = dgvCliente.CurrentCell.RowIndex;

            //armazenar os dados da linha clicada em linha (tipo um vetor)
            var linha = dgvCliente.Rows[linhaSelecionada];

            txbNomeEdit.Text = linha.Cells[1].Value.ToString();
            txbCpfEdit.Text = linha.Cells[2].Value.ToString();


            //Salvar o id na variavel global
            idCliente = (int)linha.Cells[0].Value;
        }

        private void chbTotal_CheckedChanged(object sender, EventArgs e)
        {
            //ativar e desativar btn de acordo com o checked
            btnConfirmar.Enabled = chbTotal.Checked;
        }

        private void btnCalcularAluguel_Click(object sender, EventArgs e)
        {
            // Obtém as datas dos DateTimePickers
            DateTime data1 = dtpRetirada.Value;
            DateTime data2 = dtpDevolucao.Value;

            // Calcula a diferença entre as datas
            TimeSpan diferenca = data2 - data1;

            int total = int.Parse(txbPreco.Text);
            int calculo = total * diferenca.Days;
            lblTotal.Text = ("R$ ") + String.Format("{0:0.00}", calculo);
        }
    }
}
