namespace SharkTrack
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnModelosCarros = new System.Windows.Forms.Button();
            this.btnAluguel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctSair = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrar.Location = new System.Drawing.Point(393, 139);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(138, 69);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar Cliente";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnModelosCarros
            // 
            this.btnModelosCarros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnModelosCarros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModelosCarros.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModelosCarros.Location = new System.Drawing.Point(393, 226);
            this.btnModelosCarros.Name = "btnModelosCarros";
            this.btnModelosCarros.Size = new System.Drawing.Size(138, 69);
            this.btnModelosCarros.TabIndex = 1;
            this.btnModelosCarros.Text = "Modelos Disponiveis";
            this.btnModelosCarros.UseVisualStyleBackColor = false;
            this.btnModelosCarros.Click += new System.EventHandler(this.btnModelosCarros_Click);
            // 
            // btnAluguel
            // 
            this.btnAluguel.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAluguel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAluguel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluguel.Location = new System.Drawing.Point(393, 314);
            this.btnAluguel.Name = "btnAluguel";
            this.btnAluguel.Size = new System.Drawing.Size(138, 69);
            this.btnAluguel.TabIndex = 2;
            this.btnAluguel.Text = "Efetuar Aluguel";
            this.btnAluguel.UseVisualStyleBackColor = false;
            this.btnAluguel.Click += new System.EventHandler(this.btnAluguel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pctSair
            // 
            this.pctSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctSair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctSair.Image = ((System.Drawing.Image)(resources.GetObject("pctSair.Image")));
            this.pctSair.InitialImage = null;
            this.pctSair.Location = new System.Drawing.Point(528, 12);
            this.pctSair.Name = "pctSair";
            this.pctSair.Size = new System.Drawing.Size(46, 30);
            this.pctSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSair.TabIndex = 7;
            this.pctSair.TabStop = false;
            this.pctSair.Click += new System.EventHandler(this.pctSair_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(200, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(175, 31);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Shark Track";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 468);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pctSair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAluguel);
            this.Controls.Add(this.btnModelosCarros);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnModelosCarros;
        private System.Windows.Forms.Button btnAluguel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctSair;
        private System.Windows.Forms.Label lblTitulo;
    }
}