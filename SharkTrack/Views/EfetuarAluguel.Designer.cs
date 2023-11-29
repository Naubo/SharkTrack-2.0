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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDatadeDevolucao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chbTotal = new System.Windows.Forms.CheckBox();
            this.dtpRetirada = new System.Windows.Forms.DateTimePicker();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatadeRetirada
            // 
            this.lblDatadeRetirada.AutoSize = true;
            this.lblDatadeRetirada.Location = new System.Drawing.Point(52, 71);
            this.lblDatadeRetirada.Name = "lblDatadeRetirada";
            this.lblDatadeRetirada.Size = new System.Drawing.Size(86, 13);
            this.lblDatadeRetirada.TabIndex = 1;
            this.lblDatadeRetirada.Text = "Data de retirada:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 235);
            this.dataGridView1.TabIndex = 3;
            // 
            // lblDatadeDevolucao
            // 
            this.lblDatadeDevolucao.AutoSize = true;
            this.lblDatadeDevolucao.Location = new System.Drawing.Point(621, 77);
            this.lblDatadeDevolucao.Name = "lblDatadeDevolucao";
            this.lblDatadeDevolucao.Size = new System.Drawing.Size(101, 13);
            this.lblDatadeDevolucao.TabIndex = 6;
            this.lblDatadeDevolucao.Text = "Data de devolução:";
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
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(461, 494);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(247, 55);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Confirmar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(457, 414);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(122, 33);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "R$ 0,00";
            // 
            // chbTotal
            // 
            this.chbTotal.AutoSize = true;
            this.chbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTotal.Location = new System.Drawing.Point(463, 466);
            this.chbTotal.Name = "chbTotal";
            this.chbTotal.Size = new System.Drawing.Size(62, 22);
            this.chbTotal.TabIndex = 14;
            this.chbTotal.Text = "Pago";
            this.chbTotal.UseVisualStyleBackColor = true;
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
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(590, 115);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(477, 235);
            this.dataGridView2.TabIndex = 17;
            // 
            // EfetuarAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 577);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dtpDevolucao);
            this.Controls.Add(this.dtpRetirada);
            this.Controls.Add(this.chbTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDatadeDevolucao);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDatadeRetirada);
            this.Name = "EfetuarAluguel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EfetuarAluguel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDatadeRetirada;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDatadeDevolucao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chbTotal;
        private System.Windows.Forms.DateTimePicker dtpRetirada;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}