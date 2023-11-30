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
    public partial class CadastrarCliente : Form
    {
        //Atributos globais
        int IdSelecionado = 0;
        public CadastrarCliente()
        {
            InitializeComponent();

            Classes.Clientes cliente = new Classes.Clientes();

            dgvCliente.DataSource = cliente.ListarTudo();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Caso os campos estejam vazios, correção do erro //
            if (txbNome.Text != "" && txbCPF.Text != "" && txbTelefone.Text != "")
            {
                //instanciar Cliente:
                Classes.Clientes cliente = new Classes.Clientes();

                //obter valores dos campos

                cliente.Nome_completo = txbNome.Text;
                cliente.Cpf = txbCPF.Text;
                cliente.Telefone.Telefones = txbTelefone.Text;

                if (cliente.Cadastrar() == true)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!");

                    //limpar os campos
                    txbNome.Clear();
                    txbCPF.Clear();
                    txbTelefone.Clear();

                    //atualizar dgv
                    dgvCliente.DataSource = cliente.ListarTudo();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar cliente");
                }
            }
            else
            {
                MessageBox.Show("Campos Vazios!", "Inválido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ativar os groupbox editar e apagar
            grbApagar.Enabled = true;
            grbEditar.Enabled = true;
            grbEditTelefone.Enabled = true;

            //obter linha clicada
            int linhaSelecionada = dgvCliente.CurrentCell.RowIndex;

            //armazenar os dados da linha clicada em linha (tipo um vetor)
            var linha = dgvCliente.Rows[linhaSelecionada];

            txbNomeEdit.Text = linha.Cells[1].Value.ToString();
            txbCpfEdit.Text = linha.Cells[2].Value.ToString();
            txbEditTel.Text = linha.Cells[3].Value.ToString();

            lblMensagem.Text = linha.Cells[1].Value.ToString() + " - " +
                linha.Cells[3].Value.ToString();

            //Salvar o id na variavel global
            IdSelecionado = (int)linha.Cells[0].Value;
        }

        private void btnApagar_Click_1(object sender, EventArgs e)
        {
            Classes.Clientes cliente = new Classes.Clientes();
            cliente.Id = IdSelecionado;

            //mostrar messagebox
            var r = MessageBox.Show("Tem certeza que deseja remover?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                //apagar
                if (cliente.Apagar() == true)
                {
                    MessageBox.Show("Cliente Removido!", "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // atualizar dgv
                    dgvCliente.DataSource = cliente.ListarTudo();

                    //limpar campos de edição
                    txbNomeEdit.Clear();
                    txbCpfEdit.Clear();
                    txbEditTel.Clear();
                    lblMensagem.Text = "Selecione um cliente para apagar:";

                    //desabilitar group box edição e apagar
                    grbEditar.Enabled = false;
                    grbApagar.Enabled = false;
                    grbEditTelefone.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Falha ao remover cliente!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            //correção caso algum dos dois campos estejam vazios:
            if (txbNomeEdit.Text != "" && txbCpfEdit.Text != "")
            {
                //instanciar usuario
                Classes.Clientes cliente = new Classes.Clientes();
                //obter valores dos campos
                cliente.Nome_completo = txbNomeEdit.Text;
                cliente.Cpf = txbCpfEdit.Text;
                cliente.Id = IdSelecionado;


                if (cliente.Modificar() == true)
                {
                    MessageBox.Show("Cliente modificado!", "Sucesso!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // atualizar dgv
                    dgvCliente.DataSource = cliente.ListarTudo();

                    //limpar campos de edicao
                    txbNomeEdit.Clear();
                    txbCpfEdit.Clear();
                    txbEditTel.Clear();
                    lblMensagem.Text = "Selecione um cliente para apagar:";

                    //desabilitar group box edição e apagar
                    grbEditar.Enabled = false;
                    grbApagar.Enabled = false;
                    grbEditTelefone.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Falha ao modificar Cliente!", "ERROR!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Campos Vazios!", "Inválido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txbTelefoneEdit_Click(object sender, EventArgs e)
        {
            if (txbEditTel.Text != "")
            {
                //instanciar usuario
                Classes.Telefone telefone = new Classes.Telefone();
                Classes.Clientes cliente = new Classes.Clientes();
                telefone.Telefones = txbEditTel.Text;
                telefone.Id_cliente = IdSelecionado;


                if (telefone.Modificar() == true)
                {
                    MessageBox.Show("Telefone modificado!", "Sucesso!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // atualizar dgv
                    dgvCliente.DataSource = cliente.ListarTudo();

                    //limpar campos de edicao
                    txbEditTel.Clear();
                    lblMensagem.Text = "Selecione um cliente para apagar:";

                    //desabilitar group box edição e apagar
                    grbEditar.Enabled = false;
                    grbApagar.Enabled = false;
                    grbEditTelefone.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Falha ao modificar Telefone!", "ERROR!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Campos Vazios!", "Inválido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
