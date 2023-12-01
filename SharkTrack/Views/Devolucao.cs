using SharkTrack.Classes;
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
    public partial class Devolucao : Form
    {
        int idCarro = 0;
        public Devolucao()
        {
            InitializeComponent();
            //instanciar
            Classes.Carros carro = new Classes.Carros();

            dgvCarrosEmprestados.DataSource = carro.Devolucao();

        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            if (txbAnoCadastrar.Text != "" && txbMarca.Text != "" && txbModelo.Text != "" && txbPlaca.Text != "" && txbQuilometragem.Text != "")
            {
                Classes.Carros carros = new Classes.Carros();
                carros.Id = idCarro;
                if (carros.Devolver() == true)
                {
                    MessageBox.Show("Devolução feito com sucesso!");

                    //limpar os campos
                    txbMarca.Clear();
                    txbAnoCadastrar.Clear();
                    txbModelo.Clear();
                    txbPlaca.Clear();
                    txbQuilometragem.Clear();

                    // Atualizar
                    dgvCarrosEmprestados.DataSource = carros.Devolucao();
                }
                else
                {
                    MessageBox.Show("Falha ao Devolver o automovel!");
                }
            }
            else
            {
                MessageBox.Show("Selecione o carro!", "Inválido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }



        }

        private void dgvCarrosEmprestados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //obter linha clicada
            int linhaSelecionada = dgvCarrosEmprestados.CurrentCell.RowIndex;

            //armazenar os dados da linha clicada em linha (tipo um vetor)
            var linha = dgvCarrosEmprestados.Rows[linhaSelecionada];

            txbMarca.Text = linha.Cells[1].Value.ToString();
            txbModelo.Text = linha.Cells[2].Value.ToString();
            txbAnoCadastrar.Text = linha.Cells[3].Value.ToString();
            txbPlaca.Text = linha.Cells[4].Value.ToString();
            txbQuilometragem.Text = linha.Cells[5].Value.ToString();


            //Salvar o id na variavel global
            idCarro = (int)linha.Cells[0].Value;
            //

        }
    }
}
