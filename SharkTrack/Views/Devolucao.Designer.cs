namespace SharkTrack.Views
{
    partial class Devolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devolucao));
            this.btnDevolucao = new System.Windows.Forms.Button();
            this.dgvCarrosEmprestados = new System.Windows.Forms.DataGridView();
            this.grbCarro = new System.Windows.Forms.GroupBox();
            this.txbAnoCadastrar = new System.Windows.Forms.TextBox();
            this.lblAnoCadastrar = new System.Windows.Forms.Label();
            this.txbQuilometragem = new System.Windows.Forms.TextBox();
            this.txbPlaca = new System.Windows.Forms.TextBox();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.lblQuilometragem = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrosEmprestados)).BeginInit();
            this.grbCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDevolucao
            // 
            this.btnDevolucao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDevolucao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDevolucao.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucao.Location = new System.Drawing.Point(20, 177);
            this.btnDevolucao.Name = "btnDevolucao";
            this.btnDevolucao.Size = new System.Drawing.Size(262, 39);
            this.btnDevolucao.TabIndex = 8;
            this.btnDevolucao.Text = "DEVOLVER";
            this.btnDevolucao.UseVisualStyleBackColor = false;
            this.btnDevolucao.Click += new System.EventHandler(this.btnDevolucao_Click);
            // 
            // dgvCarrosEmprestados
            // 
            this.dgvCarrosEmprestados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrosEmprestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrosEmprestados.Location = new System.Drawing.Point(18, 118);
            this.dgvCarrosEmprestados.Name = "dgvCarrosEmprestados";
            this.dgvCarrosEmprestados.Size = new System.Drawing.Size(535, 418);
            this.dgvCarrosEmprestados.TabIndex = 9;
            this.dgvCarrosEmprestados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrosEmprestados_CellClick);
            // 
            // grbCarro
            // 
            this.grbCarro.Controls.Add(this.btnDevolucao);
            this.grbCarro.Controls.Add(this.txbAnoCadastrar);
            this.grbCarro.Controls.Add(this.lblAnoCadastrar);
            this.grbCarro.Controls.Add(this.txbQuilometragem);
            this.grbCarro.Controls.Add(this.txbPlaca);
            this.grbCarro.Controls.Add(this.txbModelo);
            this.grbCarro.Controls.Add(this.txbMarca);
            this.grbCarro.Controls.Add(this.lblQuilometragem);
            this.grbCarro.Controls.Add(this.lblPlaca);
            this.grbCarro.Controls.Add(this.lblModelo);
            this.grbCarro.Controls.Add(this.lblMarca);
            this.grbCarro.Location = new System.Drawing.Point(559, 118);
            this.grbCarro.Name = "grbCarro";
            this.grbCarro.Size = new System.Drawing.Size(291, 237);
            this.grbCarro.TabIndex = 10;
            this.grbCarro.TabStop = false;
            this.grbCarro.Text = "INFORMAÇÕES CARRO";
            // 
            // txbAnoCadastrar
            // 
            this.txbAnoCadastrar.Location = new System.Drawing.Point(118, 125);
            this.txbAnoCadastrar.Name = "txbAnoCadastrar";
            this.txbAnoCadastrar.ReadOnly = true;
            this.txbAnoCadastrar.Size = new System.Drawing.Size(164, 20);
            this.txbAnoCadastrar.TabIndex = 8;
            // 
            // lblAnoCadastrar
            // 
            this.lblAnoCadastrar.AutoSize = true;
            this.lblAnoCadastrar.Location = new System.Drawing.Point(17, 132);
            this.lblAnoCadastrar.Name = "lblAnoCadastrar";
            this.lblAnoCadastrar.Size = new System.Drawing.Size(26, 13);
            this.lblAnoCadastrar.TabIndex = 8;
            this.lblAnoCadastrar.Text = "Ano";
            // 
            // txbQuilometragem
            // 
            this.txbQuilometragem.Location = new System.Drawing.Point(118, 100);
            this.txbQuilometragem.Name = "txbQuilometragem";
            this.txbQuilometragem.ReadOnly = true;
            this.txbQuilometragem.Size = new System.Drawing.Size(164, 20);
            this.txbQuilometragem.TabIndex = 6;
            // 
            // txbPlaca
            // 
            this.txbPlaca.Location = new System.Drawing.Point(118, 72);
            this.txbPlaca.Name = "txbPlaca";
            this.txbPlaca.ReadOnly = true;
            this.txbPlaca.Size = new System.Drawing.Size(164, 20);
            this.txbPlaca.TabIndex = 5;
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(118, 44);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.ReadOnly = true;
            this.txbModelo.Size = new System.Drawing.Size(164, 20);
            this.txbModelo.TabIndex = 4;
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(118, 19);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.ReadOnly = true;
            this.txbMarca.Size = new System.Drawing.Size(164, 20);
            this.txbMarca.TabIndex = 3;
            // 
            // lblQuilometragem
            // 
            this.lblQuilometragem.AutoSize = true;
            this.lblQuilometragem.Location = new System.Drawing.Point(17, 107);
            this.lblQuilometragem.Name = "lblQuilometragem";
            this.lblQuilometragem.Size = new System.Drawing.Size(77, 13);
            this.lblQuilometragem.TabIndex = 3;
            this.lblQuilometragem.Text = "Quilometragem";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(17, 79);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(34, 13);
            this.lblPlaca.TabIndex = 2;
            this.lblPlaca.Text = "Placa";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(17, 51);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(17, 26);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(12, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(561, 66);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = ":: Shark Track - Devolução Automóvel\r\n\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(602, 361);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Devolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 548);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbCarro);
            this.Controls.Add(this.dgvCarrosEmprestados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Devolucao";
            this.Text = "Devolucao";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrosEmprestados)).EndInit();
            this.grbCarro.ResumeLayout(false);
            this.grbCarro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDevolucao;
        private System.Windows.Forms.DataGridView dgvCarrosEmprestados;
        private System.Windows.Forms.GroupBox grbCarro;
        private System.Windows.Forms.TextBox txbAnoCadastrar;
        private System.Windows.Forms.Label lblAnoCadastrar;
        private System.Windows.Forms.TextBox txbQuilometragem;
        private System.Windows.Forms.TextBox txbPlaca;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.Label lblQuilometragem;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}