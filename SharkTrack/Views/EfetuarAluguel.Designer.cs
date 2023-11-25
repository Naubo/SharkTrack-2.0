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
            this.mcRetirada = new System.Windows.Forms.MonthCalendar();
            this.lblDatadeRetirada = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txbRetirada = new System.Windows.Forms.TextBox();
            this.txbDevolucao = new System.Windows.Forms.TextBox();
            this.lblDatadeDevolucao = new System.Windows.Forms.Label();
            this.lblAlugado = new System.Windows.Forms.Label();
            this.txbaAugado = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.mcDevolucao = new System.Windows.Forms.MonthCalendar();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.chbTotal = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcRetirada
            // 
            this.mcRetirada.Location = new System.Drawing.Point(37, 116);
            this.mcRetirada.Name = "mcRetirada";
            this.mcRetirada.TabIndex = 0;
            // 
            // lblDatadeRetirada
            // 
            this.lblDatadeRetirada.AutoSize = true;
            this.lblDatadeRetirada.Location = new System.Drawing.Point(34, 84);
            this.lblDatadeRetirada.Name = "lblDatadeRetirada";
            this.lblDatadeRetirada.Size = new System.Drawing.Size(86, 13);
            this.lblDatadeRetirada.TabIndex = 1;
            this.lblDatadeRetirada.Text = "Data de retirada:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 235);
            this.dataGridView1.TabIndex = 3;
            // 
            // txbRetirada
            // 
            this.txbRetirada.Location = new System.Drawing.Point(164, 84);
            this.txbRetirada.Name = "txbRetirada";
            this.txbRetirada.Size = new System.Drawing.Size(100, 20);
            this.txbRetirada.TabIndex = 4;
            // 
            // txbDevolucao
            // 
            this.txbDevolucao.Location = new System.Drawing.Point(427, 78);
            this.txbDevolucao.Name = "txbDevolucao";
            this.txbDevolucao.Size = new System.Drawing.Size(100, 20);
            this.txbDevolucao.TabIndex = 5;
            // 
            // lblDatadeDevolucao
            // 
            this.lblDatadeDevolucao.AutoSize = true;
            this.lblDatadeDevolucao.Location = new System.Drawing.Point(297, 85);
            this.lblDatadeDevolucao.Name = "lblDatadeDevolucao";
            this.lblDatadeDevolucao.Size = new System.Drawing.Size(101, 13);
            this.lblDatadeDevolucao.TabIndex = 6;
            this.lblDatadeDevolucao.Text = "Data de devolução:";
            // 
            // lblAlugado
            // 
            this.lblAlugado.AutoSize = true;
            this.lblAlugado.Location = new System.Drawing.Point(34, 293);
            this.lblAlugado.Name = "lblAlugado";
            this.lblAlugado.Size = new System.Drawing.Size(101, 13);
            this.lblAlugado.TabIndex = 7;
            this.lblAlugado.Text = "Automóvel alugado:";
            // 
            // txbaAugado
            // 
            this.txbaAugado.Location = new System.Drawing.Point(141, 293);
            this.txbaAugado.Name = "txbaAugado";
            this.txbaAugado.Size = new System.Drawing.Size(162, 20);
            this.txbaAugado.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(202, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(186, 22);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Registro :: Aluguel";
            // 
            // mcDevolucao
            // 
            this.mcDevolucao.Location = new System.Drawing.Point(300, 116);
            this.mcDevolucao.Name = "mcDevolucao";
            this.mcDevolucao.TabIndex = 12;
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.txbTelefone);
            this.grbInformacoes.Controls.Add(this.txbNome);
            this.grbInformacoes.Controls.Add(this.lblNome);
            this.grbInformacoes.Controls.Add(this.lblTelefone);
            this.grbInformacoes.Location = new System.Drawing.Point(563, 142);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(282, 94);
            this.grbInformacoes.TabIndex = 13;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "INFORMAÇÕES";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(583, 510);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(247, 55);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Confirmar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(130, 53);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(137, 20);
            this.txbTelefone.TabIndex = 7;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(130, 20);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(137, 20);
            this.txbNome.TabIndex = 5;
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
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(17, 53);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(579, 430);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(122, 33);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "R$ 0,00";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(580, 81);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 8;
            this.lblCPF.Text = "CPF:";
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(616, 78);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(189, 20);
            this.txbCPF.TabIndex = 9;
            // 
            // chbTotal
            // 
            this.chbTotal.AutoSize = true;
            this.chbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTotal.Location = new System.Drawing.Point(585, 482);
            this.chbTotal.Name = "chbTotal";
            this.chbTotal.Size = new System.Drawing.Size(62, 22);
            this.chbTotal.TabIndex = 14;
            this.chbTotal.Text = "Pago";
            this.chbTotal.UseVisualStyleBackColor = true;
            // 
            // EfetuarAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 577);
            this.Controls.Add(this.chbTotal);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.mcDevolucao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txbaAugado);
            this.Controls.Add(this.lblAlugado);
            this.Controls.Add(this.lblDatadeDevolucao);
            this.Controls.Add(this.txbDevolucao);
            this.Controls.Add(this.txbRetirada);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDatadeRetirada);
            this.Controls.Add(this.mcRetirada);
            this.Name = "EfetuarAluguel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EfetuarAluguel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcRetirada;
        private System.Windows.Forms.Label lblDatadeRetirada;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txbRetirada;
        private System.Windows.Forms.TextBox txbDevolucao;
        private System.Windows.Forms.Label lblDatadeDevolucao;
        private System.Windows.Forms.Label lblAlugado;
        private System.Windows.Forms.TextBox txbaAugado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MonthCalendar mcDevolucao;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.CheckBox chbTotal;
    }
}