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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCliente));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.txbCpfEdit = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblCpfEdit = new System.Windows.Forms.Label();
            this.txbNomeEdit = new System.Windows.Forms.TextBox();
            this.lblNomeEdit = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.grbEditTelefone = new System.Windows.Forms.GroupBox();
            this.lblCpfEditTel = new System.Windows.Forms.Label();
            this.txbEditTel = new System.Windows.Forms.TextBox();
            this.txbTelefoneEdit = new System.Windows.Forms.Button();
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
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(12, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(487, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = ":: Shark Track - Cadastro Usuário";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(353, 168);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.Size = new System.Drawing.Size(442, 460);
            this.dgvCliente.TabIndex = 1;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCPF.Location = new System.Drawing.Point(9, 52);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(37, 15);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTelefone.Location = new System.Drawing.Point(9, 80);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(67, 15);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNome.Location = new System.Drawing.Point(9, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(114, 15);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome Completo:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(129, 26);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(137, 20);
            this.txbNome.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrar.Location = new System.Drawing.Point(12, 106);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(254, 55);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "CADASTRAR CLIENTE";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.grbCadastrar.Controls.Add(this.txbTelefone);
            this.grbCadastrar.Controls.Add(this.txbCPF);
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.lblCPF);
            this.grbCadastrar.Controls.Add(this.txbNome);
            this.grbCadastrar.Controls.Add(this.lblNome);
            this.grbCadastrar.Controls.Add(this.lblTelefone);
            this.grbCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbCadastrar.Location = new System.Drawing.Point(26, 116);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(282, 173);
            this.grbCadastrar.TabIndex = 11;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "CADASTRO";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(128, 79);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(137, 20);
            this.txbTelefone.TabIndex = 14;
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(128, 52);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(137, 20);
            this.txbCPF.TabIndex = 13;
            // 
            // grbEditar
            // 
            this.grbEditar.BackColor = System.Drawing.Color.Transparent;
            this.grbEditar.Controls.Add(this.txbCpfEdit);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.lblCpfEdit);
            this.grbEditar.Controls.Add(this.txbNomeEdit);
            this.grbEditar.Controls.Add(this.lblNomeEdit);
            this.grbEditar.Enabled = false;
            this.grbEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbEditar.Location = new System.Drawing.Point(26, 306);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(282, 173);
            this.grbEditar.TabIndex = 12;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "EDITAR";
            // 
            // txbCpfEdit
            // 
            this.txbCpfEdit.Location = new System.Drawing.Point(126, 60);
            this.txbCpfEdit.Name = "txbCpfEdit";
            this.txbCpfEdit.Size = new System.Drawing.Size(137, 20);
            this.txbCpfEdit.TabIndex = 14;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(9, 106);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(254, 55);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "EDITAR CLIENTE";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblCpfEdit
            // 
            this.lblCpfEdit.AutoSize = true;
            this.lblCpfEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCpfEdit.Location = new System.Drawing.Point(6, 60);
            this.lblCpfEdit.Name = "lblCpfEdit";
            this.lblCpfEdit.Size = new System.Drawing.Size(37, 15);
            this.lblCpfEdit.TabIndex = 2;
            this.lblCpfEdit.Text = "CPF:";
            // 
            // txbNomeEdit
            // 
            this.txbNomeEdit.Location = new System.Drawing.Point(126, 30);
            this.txbNomeEdit.Name = "txbNomeEdit";
            this.txbNomeEdit.Size = new System.Drawing.Size(137, 20);
            this.txbNomeEdit.TabIndex = 5;
            // 
            // lblNomeEdit
            // 
            this.lblNomeEdit.AutoSize = true;
            this.lblNomeEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomeEdit.Location = new System.Drawing.Point(6, 30);
            this.lblNomeEdit.Name = "lblNomeEdit";
            this.lblNomeEdit.Size = new System.Drawing.Size(114, 15);
            this.lblNomeEdit.TabIndex = 4;
            this.lblNomeEdit.Text = "Nome Completo:";
            // 
            // grbApagar
            // 
            this.grbApagar.BackColor = System.Drawing.Color.Transparent;
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblMensagem);
            this.grbApagar.Enabled = false;
            this.grbApagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbApagar.Location = new System.Drawing.Point(513, 12);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(282, 134);
            this.grbApagar.TabIndex = 11;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "APAGAR";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Tomato;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApagar.Location = new System.Drawing.Point(12, 71);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(254, 50);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click_1);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMensagem.Location = new System.Drawing.Point(6, 30);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(271, 17);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Selecione um usuário para apagar!";
            // 
            // grbEditTelefone
            // 
            this.grbEditTelefone.BackColor = System.Drawing.Color.Transparent;
            this.grbEditTelefone.Controls.Add(this.lblCpfEditTel);
            this.grbEditTelefone.Controls.Add(this.txbEditTel);
            this.grbEditTelefone.Controls.Add(this.txbTelefoneEdit);
            this.grbEditTelefone.Enabled = false;
            this.grbEditTelefone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbEditTelefone.Location = new System.Drawing.Point(26, 494);
            this.grbEditTelefone.Name = "grbEditTelefone";
            this.grbEditTelefone.Size = new System.Drawing.Size(282, 134);
            this.grbEditTelefone.TabIndex = 12;
            this.grbEditTelefone.TabStop = false;
            this.grbEditTelefone.Text = "EDITAR TELEFONE";
            // 
            // lblCpfEditTel
            // 
            this.lblCpfEditTel.AutoSize = true;
            this.lblCpfEditTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfEditTel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCpfEditTel.Location = new System.Drawing.Point(9, 35);
            this.lblCpfEditTel.Name = "lblCpfEditTel";
            this.lblCpfEditTel.Size = new System.Drawing.Size(73, 16);
            this.lblCpfEditTel.TabIndex = 8;
            this.lblCpfEditTel.Text = "Telefone:";
            // 
            // txbEditTel
            // 
            this.txbEditTel.Location = new System.Drawing.Point(126, 31);
            this.txbEditTel.Name = "txbEditTel";
            this.txbEditTel.Size = new System.Drawing.Size(137, 20);
            this.txbEditTel.TabIndex = 9;
            // 
            // txbTelefoneEdit
            // 
            this.txbTelefoneEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txbTelefoneEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txbTelefoneEdit.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefoneEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbTelefoneEdit.Location = new System.Drawing.Point(9, 71);
            this.txbTelefoneEdit.Name = "txbTelefoneEdit";
            this.txbTelefoneEdit.Size = new System.Drawing.Size(254, 50);
            this.txbTelefoneEdit.TabIndex = 7;
            this.txbTelefoneEdit.Text = "EDITAR TELEFONE";
            this.txbTelefoneEdit.UseVisualStyleBackColor = false;
            this.txbTelefoneEdit.Click += new System.EventHandler(this.txbTelefoneEdit_Click);
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 658);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbEditTelefone);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvCliente);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Usuário";
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
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblCpfEdit;
        private System.Windows.Forms.TextBox txbNomeEdit;
        private System.Windows.Forms.Label lblNomeEdit;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.GroupBox grbEditTelefone;
        private System.Windows.Forms.Label lblCpfEditTel;
        private System.Windows.Forms.TextBox txbEditTel;
        private System.Windows.Forms.Button txbTelefoneEdit;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbCpfEdit;
    }
}