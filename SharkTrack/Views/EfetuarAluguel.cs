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
        public EfetuarAluguel()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //instanciar Cliente:
            Classes.Aluguel aluguel = new Classes.Aluguel();

            //obter valores dos campos

            aluguel.Id_usuario = ;
            aluguel.Id_carro = ;
            aluguel.Data_retirada = dtpRetirada.Value;
            aluguel.Data_devolucao = dtpDevolucao.Value;

            if (aluguel.Cadastrar() == true)
            {
                MessageBox.Show("Cliente cadastrado com sucesso!");

                //limpar os campos
                txbNome.Clear();
                txbCPF.Clear();
                txbTelefone.Clear();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar cliente");
            }
        }
    }
}
