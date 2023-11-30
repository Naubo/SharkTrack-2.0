namespace SharkTrack.Views
{
    partial class EfetuarAluguel
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
            this.lblDatadeRetirada = new System.Windows.Forms.Label();
            this.dgvCarro = new System.Windows.Forms.DataGridView();
            this.lblDatadeDevolucao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chbTotal = new System.Windows.Forms.CheckBox();
            this.dtpRetirada = new System.Windows.Forms.DateTimePicker();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.grbInfoCarro = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbQuilom = new System.Windows.Forms.TextBox();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.txbPlaca = new System.Windows.Forms.TextBox();
            this.txbAno = new System.Windows.Forms.TextBox();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.lblCpfEdit = new System.Windows.Forms.Label();
            this.txbNomeEdit = new System.Windows.Forms.TextBox();
            this.lblNomeEdit = new System.Windows.Forms.Label();
            this.txbCpfEdit = new System.Windows.Forms.TextBox();
            this.btnCalcularAluguel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.grbInfoCarro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDatadeRetirada
            // 
            this.lblDatadeRetirada.AutoSize = true;
            this.lblDatadeRetirada.BackColor = System.Drawing.Color.Transparent;
            this.lblDatadeRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatadeRetirada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDatadeRetirada.Location = new System.Drawing.Point(21, 68);
            this.lblDatadeRetirada.Name = "lblDatadeRetirada";
            this.lblDatadeRetirada.Size = new System.Drawing.Size(133, 18);
            this.lblDatadeRetirada.TabIndex = 1;
            this.lblDatadeRetirada.Text = "Data de retirada:";
            // 
            // dgvCarro
            // 
            this.dgvCarro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarro.Location = new System.Drawing.Point(24, 115);
            this.dgvCarro.Name = "dgvCarro";
            this.dgvCarro.ReadOnly = true;
            this.dgvCarro.Size = new System.Drawing.Size(490, 235);
            this.dgvCarro.TabIndex = 3;
            this.dgvCarro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarro_CellClick);
            // 
            // lblDatadeDevolucao
            // 
            this.lblDatadeDevolucao.AutoSize = true;
            this.lblDatadeDevolucao.BackColor = System.Drawing.Color.Transparent;
            this.lblDatadeDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatadeDevolucao.Location = new System.Drawing.Point(618, 72);
            this.lblDatadeDevolucao.Name = "lblDatadeDevolucao";
            this.lblDatadeDevolucao.Size = new System.Drawing.Size(153, 18);
            this.lblDatadeDevolucao.TabIndex = 6;
            this.lblDatadeDevolucao.Text = "Data de devolução:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(418, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(260, 31);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Registro :: Aluguel";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Lime;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(590, 540);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(247, 55);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotal.Location = new System.Drawing.Point(502, 446);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(122, 33);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "R$ 0,00";
            // 
            // chbTotal
            // 
            this.chbTotal.AutoSize = true;
            this.chbTotal.BackColor = System.Drawing.Color.Transparent;
            this.chbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chbTotal.Location = new System.Drawing.Point(535, 495);
            this.chbTotal.Name = "chbTotal";
            this.chbTotal.Size = new System.Drawing.Size(62, 22);
            this.chbTotal.TabIndex = 14;
            this.chbTotal.Text = "Pago";
            this.chbTotal.UseVisualStyleBackColor = false;
            this.chbTotal.CheckedChanged += new System.EventHandler(this.chbTotal_CheckedChanged);
            // 
            // dtpRetirada
            // 
            this.dtpRetirada.Location = new System.Drawing.Point(159, 66);
            this.dtpRetirada.Name = "dtpRetirada";
            this.dtpRetirada.Size = new System.Drawing.Size(268, 20);
            this.dtpRetirada.TabIndex = 15;
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.Location = new System.Drawing.Point(777, 70);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(228, 20);
            this.dtpDevolucao.TabIndex = 16;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(590, 115);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(477, 235);
            this.dgvCliente.TabIndex = 17;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            // 
            // grbInfoCarro
            // 
            this.grbInfoCarro.BackColor = System.Drawing.Color.Transparent;
            this.grbInfoCarro.Controls.Add(this.label1);
            this.grbInfoCarro.Controls.Add(this.txbQuilom);
            this.grbInfoCarro.Controls.Add(this.txbPreco);
            this.grbInfoCarro.Controls.Add(this.txbPlaca);
            this.grbInfoCarro.Controls.Add(this.txbAno);
            this.grbInfoCarro.Controls.Add(this.txbModelo);
            this.grbInfoCarro.Controls.Add(this.label2);
            this.grbInfoCarro.Controls.Add(this.txbMarca);
            this.grbInfoCarro.Controls.Add(this.label3);
            this.grbInfoCarro.Controls.Add(this.label4);
            this.grbInfoCarro.Controls.Add(this.label5);
            this.grbInfoCarro.Controls.Add(this.label6);
            this.grbInfoCarro.Enabled = false;
            this.grbInfoCarro.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grbInfoCarro.Location = new System.Drawing.Point(24, 366);
            this.grbInfoCarro.Name = "grbInfoCarro";
            this.grbInfoCarro.Size = new System.Drawing.Size(259, 246);
            this.grbInfoCarro.TabIndex = 18;
            this.grbInfoCarro.TabStop = false;
            this.grbInfoCarro.Text = "INFORMAÇÕES CARRO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(17, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Preço";
            // 
            // txbQuilom
            // 
            this.txbQuilom.Location = new System.Drawing.Point(118, 137);
            this.txbQuilom.Name = "txbQuilom";
            this.txbQuilom.Size = new System.Drawing.Size(129, 20);
            this.txbQuilom.TabIndex = 6;
            // 
            // txbPreco
            // 
            this.txbPreco.Location = new System.Drawing.Point(118, 209);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(129, 20);
            this.txbPreco.TabIndex = 13;
            // 
            // txbPlaca
            // 
            this.txbPlaca.Location = new System.Drawing.Point(118, 100);
            this.txbPlaca.Name = "txbPlaca";
            this.txbPlaca.Size = new System.Drawing.Size(129, 20);
            this.txbPlaca.TabIndex = 5;
            // 
            // txbAno
            // 
            this.txbAno.Location = new System.Drawing.Point(118, 175);
            this.txbAno.Name = "txbAno";
            this.txbAno.Size = new System.Drawing.Size(129, 20);
            this.txbAno.TabIndex = 11;
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(118, 56);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(129, 20);
            this.txbModelo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(17, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ano";
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(118, 20);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(129, 20);
            this.txbMarca.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(17, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quilometragem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(17, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Placa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(17, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(17, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Marca";
            // 
            // grbEditar
            // 
            this.grbEditar.BackColor = System.Drawing.Color.Transparent;
            this.grbEditar.Controls.Add(this.lblCpfEdit);
            this.grbEditar.Controls.Add(this.txbNomeEdit);
            this.grbEditar.Controls.Add(this.lblNomeEdit);
            this.grbEditar.Controls.Add(this.txbCpfEdit);
            this.grbEditar.Enabled = false;
            this.grbEditar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grbEditar.Location = new System.Drawing.Point(803, 390);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(282, 96);
            this.grbEditar.TabIndex = 19;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "INFORMAÇÕES CLIENTE";
            // 
            // lblCpfEdit
            // 
            this.lblCpfEdit.AutoSize = true;
            this.lblCpfEdit.ForeColor = System.Drawing.SystemColors.AppWorkspace;
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
            this.lblNomeEdit.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeEdit.ForeColor = System.Drawing.SystemColors.AppWorkspace;
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
            // btnCalcularAluguel
            // 
            this.btnCalcularAluguel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCalcularAluguel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcularAluguel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularAluguel.Location = new System.Drawing.Point(312, 541);
            this.btnCalcularAluguel.Name = "btnCalcularAluguel";
            this.btnCalcularAluguel.Size = new System.Drawing.Size(247, 55);
            this.btnCalcularAluguel.TabIndex = 20;
            this.btnCalcularAluguel.Text = "Calcular";
            this.btnCalcularAluguel.UseVisualStyleBackColor = false;
            this.btnCalcularAluguel.Click += new System.EventHandler(this.btnCalcularAluguel_Click);
            // 
            // EfetuarAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SharkTrack.Properties.Resources._67;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1119, 625);
            this.Controls.Add(this.btnCalcularAluguel);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbInfoCarro);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.dtpDevolucao);
            this.Controls.Add(this.dtpRetirada);
            this.Controls.Add(this.chbTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDatadeDevolucao);
            this.Controls.Add(this.dgvCarro);
            this.Controls.Add(this.lblDatadeRetirada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EfetuarAluguel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EfetuarAluguel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.grbInfoCarro.ResumeLayout(false);
            this.grbInfoCarro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDatadeRetirada;
        private System.Windows.Forms.DataGridView dgvCarro;
        private System.Windows.Forms.Label lblDatadeDevolucao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chbTotal;
        private System.Windows.Forms.DateTimePicker dtpRetirada;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.GroupBox grbInfoCarro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbQuilom;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.TextBox txbPlaca;
        private System.Windows.Forms.TextBox txbAno;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Label lblCpfEdit;
        private System.Windows.Forms.TextBox txbNomeEdit;
        private System.Windows.Forms.Label lblNomeEdit;
        private System.Windows.Forms.TextBox txbCpfEdit;
        private System.Windows.Forms.Button btnCalcularAluguel;
    }
}