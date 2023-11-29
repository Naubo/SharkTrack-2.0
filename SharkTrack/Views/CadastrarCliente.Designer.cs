namespace SharkTrack.Views
{
    partial class CadastrarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblCpfEdit = new System.Windows.Forms.Label();
            this.txbNomeEdit = new System.Windows.Forms.TextBox();
            this.lblNomeEdit = new System.Windows.Forms.Label();
            this.txbCpfEdit = new System.Windows.Forms.TextBox();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.grbEditTelefone = new System.Windows.Forms.GroupBox();
            this.txbTelefoneEdit = new System.Windows.Forms.Button();
            this.lblCpfEditTel = new System.Windows.Forms.Label();
            this.txbEditTel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            this.grbEditTelefone.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(38, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(235, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CADASTRAR CLIENTE";
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(642, 47);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.Size = new System.Drawing.Size(437, 468);
            this.dgvCliente.TabIndex = 1;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(17, 58);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(17, 92);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(17, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(85, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome Completo:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(130, 20);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(137, 20);
            this.txbNome.TabIndex = 5;
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(130, 55);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(137, 20);
            this.txbCPF.TabIndex = 6;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(130, 85);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(137, 20);
            this.txbTelefone.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(20, 159);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(247, 55);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar Cliente";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.lblCPF);
            this.grbCadastrar.Controls.Add(this.txbTelefone);
            this.grbCadastrar.Controls.Add(this.txbNome);
            this.grbCadastrar.Controls.Add(this.lblNome);
            this.grbCadastrar.Controls.Add(this.txbCPF);
            this.grbCadastrar.Controls.Add(this.lblTelefone);
            this.grbCadastrar.Location = new System.Drawing.Point(33, 89);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(282, 233);
            this.grbCadastrar.TabIndex = 11;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "CADASTRO";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.lblCpfEdit);
            this.grbEditar.Controls.Add(this.txbNomeEdit);
            this.grbEditar.Controls.Add(this.lblNomeEdit);
            this.grbEditar.Controls.Add(this.txbCpfEdit);
            this.grbEditar.Enabled = false;
            this.grbEditar.Location = new System.Drawing.Point(321, 89);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(282, 233);
            this.grbEditar.TabIndex = 12;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(20, 159);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(247, 55);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar Cliente";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblCpfEdit
            // 
            this.lblCpfEdit.AutoSize = true;
            this.lblCpfEdit.Location = new System.Drawing.Point(17, 58);
            this.lblCpfEdit.Name = "lblCpfEdit";
            this.lblCpfEdit.Size = new System.Drawing.Size(30, 13);
            this.lblCpfEdit.TabIndex = 2;
            this.lblCpfEdit.Text = "CPF:";
            // 
            // txbNomeEdit
            // 
            this.txbNomeEdit.Location = new System.Drawing.Point(130, 20);
            this.txbNomeEdit.Name = "txbNomeEdit";
            this.txbNomeEdit.Size = new System.Drawing.Size(137, 20);
            this.txbNomeEdit.TabIndex = 5;
            // 
            // lblNomeEdit
            // 
            this.lblNomeEdit.AutoSize = true;
            this.lblNomeEdit.Location = new System.Drawing.Point(17, 27);
            this.lblNomeEdit.Name = "lblNomeEdit";
            this.lblNomeEdit.Size = new System.Drawing.Size(85, 13);
            this.lblNomeEdit.TabIndex = 4;
            this.lblNomeEdit.Text = "Nome Completo:";
            // 
            // txbCpfEdit
            // 
            this.txbCpfEdit.Location = new System.Drawing.Point(130, 55);
            this.txbCpfEdit.Name = "txbCpfEdit";
            this.txbCpfEdit.Size = new System.Drawing.Size(137, 20);
            this.txbCpfEdit.TabIndex = 6;
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblMensagem);
            this.grbApagar.Enabled = false;
            this.grbApagar.Location = new System.Drawing.Point(35, 367);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(280, 134);
            this.grbApagar.TabIndex = 11;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "APAGAR";
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(20, 78);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(227, 39);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click_1);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(6, 32);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(256, 20);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Selecione um carro para apagar!";
            // 
            // grbEditTelefone
            // 
            this.grbEditTelefone.Controls.Add(this.lblCpfEditTel);
            this.grbEditTelefone.Controls.Add(this.txbEditTel);
            this.grbEditTelefone.Controls.Add(this.txbTelefoneEdit);
            this.grbEditTelefone.Enabled = false;
            this.grbEditTelefone.Location = new System.Drawing.Point(321, 367);
            this.grbEditTelefone.Name = "grbEditTelefone";
            this.grbEditTelefone.Size = new System.Drawing.Size(282, 134);
            this.grbEditTelefone.TabIndex = 12;
            this.grbEditTelefone.TabStop = false;
            this.grbEditTelefone.Text = "Editar Telefone";
            // 
            // txbTelefoneEdit
            // 
            this.txbTelefoneEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefoneEdit.Location = new System.Drawing.Point(18, 78);
            this.txbTelefoneEdit.Name = "txbTelefoneEdit";
            this.txbTelefoneEdit.Size = new System.Drawing.Size(227, 39);
            this.txbTelefoneEdit.TabIndex = 7;
            this.txbTelefoneEdit.Text = "Editar Telefone";
            this.txbTelefoneEdit.UseVisualStyleBackColor = true;
            this.txbTelefoneEdit.Click += new System.EventHandler(this.txbTelefoneEdit_Click);
            // 
            // lblCpfEditTel
            // 
            this.lblCpfEditTel.AutoSize = true;
            this.lblCpfEditTel.Location = new System.Drawing.Point(29, 42);
            this.lblCpfEditTel.Name = "lblCpfEditTel";
            this.lblCpfEditTel.Size = new System.Drawing.Size(52, 13);
            this.lblCpfEditTel.TabIndex = 8;
            this.lblCpfEditTel.Text = "Telefone:";
            // 
            // txbEditTel
            // 
            this.txbEditTel.Location = new System.Drawing.Point(87, 39);
            this.txbEditTel.Name = "txbEditTel";
            this.txbEditTel.Size = new System.Drawing.Size(137, 20);
            this.txbEditTel.TabIndex = 9;
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 561);
            this.Controls.Add(this.grbEditTelefone);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.lblTitulo);
            this.Name = "CadastrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.grbEditTelefone.ResumeLayout(false);
            this.grbEditTelefone.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblCpfEdit;
        private System.Windows.Forms.TextBox txbNomeEdit;
        private System.Windows.Forms.Label lblNomeEdit;
        private System.Windows.Forms.TextBox txbCpfEdit;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.GroupBox grbEditTelefone;
        private System.Windows.Forms.Label lblCpfEditTel;
        private System.Windows.Forms.TextBox txbEditTel;
        private System.Windows.Forms.Button txbTelefoneEdit;
    }
}