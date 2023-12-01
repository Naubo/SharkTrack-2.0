using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharkTrack
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnAluguel_Click(object sender, EventArgs e)
        {
            // Instanciar janela:
            Views.EfetuarAluguel janela = new Views.EfetuarAluguel();
            janela.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Instanciar janela:
            Views.CadastrarCliente janela = new Views.CadastrarCliente();
            janela.Show();
        }

        private void btnModelosCarros_Click(object sender, EventArgs e)
        {
            // Instanciar janela:
            Views.CadastrarCarro janela = new Views.CadastrarCarro();
            janela.Show();
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            Views.Devolucao janela = new Views.Devolucao();
            janela.Show();
        }
    }
}
