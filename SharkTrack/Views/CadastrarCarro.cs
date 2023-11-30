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
        //Atributos globais
        int IdSelecionado = 0;
        public CadastrarCarro()
        {
            InitializeComponent();
            Classes.Carros carros = new Classes.Carros();

            dgvCarros.DataSource = carros.ListarTudo();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (txbMarca.Text != "" && txbModelo.Text != "" && txbAnoCadastrar.Text != "" && txbPrecoCadastrar.Text != "" && txbPlaca.Text != "" && txbQuilometragem.Text != "")
            {
                //instanciar Cliente:

                Classes.Carros carros = new Classes.Carros();

                //obter valores dos campos

                carros.Marca = txbMarca.Text;
                carros.Modelo = txbModelo.Text;
                carros.Placa = txbPlaca.Text;
                carros.Preco = double.Parse(txbPrecoCadastrar.Text);
                carros.Ano = int.Parse(txbAnoCadastrar.Text);
                carros.Quilometragem = int.Parse(txbQuilometragem.Text);

                if (carros.Cadastrar() == true)
                {
                    MessageBox.Show("Carro cadastrado com sucesso!");

                    //limpar os campos
                    txbMarca.Clear();
                    txbModelo.Clear();
                    txbAnoCadastrar.Clear();
                    txbPrecoCadastrar.Clear();
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
            else
            {
                MessageBox.Show("Campos Vazios!", "Inválido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Carros carros = new Classes.Carros();
            carros.Id = IdSelecionado;

            //mostrar messagebox
            var r = MessageBox.Show("Tem certeza que deseja remover?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                //apagar
                if (carros.Apagar() == true)
                {
                    MessageBox.Show("Carro Removido!", "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // atualizar dgv
                    dgvCarros.DataSource = carros.ListarTudo();

                    //limpar campos de edição
                    txbMarcaEdit.Clear();
                    txbModeloEdit.Clear();
                    txbAnoEdit.Clear();
                    txbPrecoEdit.Clear();
                    txbPlacaEdit.Clear();
                    txbQuilometragemEdit.Clear();
                    lblMensagem.Text = "Selecione um carro para apagar:";

                    //desabilitar group box edição e apagar
                    grbEditar.Enabled = false;
                    grbApagar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Falha ao remover carro!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbMarcaEdit.Text != "" && txbModeloEdit.Text != "" && txbAnoEdit.Text != "" && txbPrecoEdit.Text != "" && txbPlacaEdit.Text != "" && txbQuilometragemEdit.Text != "")
            {  
                //instanciar usuario
                Classes.Carros carros = new Classes.Carros();
                //obter valores dos campos
                carros.Id = IdSelecionado;
                carros.Marca = txbMarcaEdit.Text;
                carros.Modelo = txbModeloEdit.Text;
                carros.Placa = txbPlacaEdit.Text;
                carros.Preco = double.Parse(txbPrecoEdit.Text);
                carros.Ano = int.Parse(txbAnoEdit.Text);
                carros.Quilometragem = int.Parse(txbQuilometragemEdit.Text);


                if (carros.Modificar() == true)
                {
                    MessageBox.Show("Carro modificado!", "Sucesso!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // atualizar dgv
                    dgvCarros.DataSource = carros.ListarTudo();

                    //limpar campos de edicao
                    txbMarcaEdit.Clear();
                    txbModeloEdit.Clear();
                    txbAnoEdit.Clear();
                    txbPrecoEdit.Clear();
                    txbPlacaEdit.Clear();
                    txbQuilometragemEdit.Clear();
                    lblMensagem.Text = "Selecione um carro para apagar:";

                    //desabilitar group box edição e apagar
                    grbEditar.Enabled = false;
                    grbApagar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Falha ao modificar Carro!", "ERROR!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Campos Vazios!", "Inválido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvCarros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ativar os groupbox editar e apagar
            grbApagar.Enabled = true;
            grbEditar.Enabled = true;

            //obter linha clicada
            int linhaSelecionada = dgvCarros.CurrentCell.RowIndex;

            //armazenar os dados da linha clicada em linha (tipo um vetor)
            var linha = dgvCarros.Rows[linhaSelecionada];

            txbMarcaEdit.Text = linha.Cells[1].Value.ToString();
            txbModeloEdit.Text = linha.Cells[2].Value.ToString();
            txbAnoEdit.Text = linha.Cells[3].Value.ToString();
            txbPlacaEdit.Text = linha.Cells[4].Value.ToString();
            txbPrecoEdit.Text = linha.Cells[5].Value.ToString();
            txbQuilometragemEdit.Text = linha.Cells[6].Value.ToString();



            lblMensagem.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString() + "  " +
                linha.Cells[2].Value.ToString(); 

            //Salvar o id na variavel global
            IdSelecionado = (int)linha.Cells[0].Value;
        }


    }
}
