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
    public partial class CadastrarCarro : Form
    {
        public CadastrarCarro()
        {
            InitializeComponent();
            Classes.Carros carros = new Classes.Carros();

            dgvCarros.DataSource = carros;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //instanciar Cliente:

            Classes.Carros carros = new Classes.Carros();

            //obter valores dos campos

            carros.Marca  = txbMarca.Text;
            carros.Modelo = txbModelo.Text;
            carros.Placa = txbPlaca.Text;
            carros.Quilometragem = int.Parse(txbQuilometragem.Text);

            if (carros.Cadastrar() == true)
            {
                MessageBox.Show("Carro cadastrado com sucesso!");

                //limpar os campos
                txbMarca.Clear();
                txbModelo.Clear();
                txbPlaca.Clear();
                txbQuilometragem.Clear();

                //atualizar dgv
                dgvCarros.DataSource = carros.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar carro");
            }

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Id = IdSelecionado;

            //mostrar messagebox
            var r = MessageBox.Show("Tem certeza que deseja remover?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                //apagar
                if (Carros.Apagar() == true)
                {
                    MessageBox.Show("Usuário Removido!", "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // atualizar dgv
                    dgvCarros.DataSource = Carros.ListarTudo();

                    //limpar campos de edicao
                    txbMarca.Clear();
                    txbModelo.Clear();
                    txbPlaca.Clear();
                    txbQuilometragem.Clear();
                    lblMensagem.Text = "Selecione um carro para apagar:";

                    //desabilitar group box edição e apagar
                    grbEditar.Enabled = false;
                    grbApagar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Falha ao remover usuário!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
