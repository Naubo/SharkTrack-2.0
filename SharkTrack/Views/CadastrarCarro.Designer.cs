namespace SharkTrack.Views
{
    partial class CadastrarCarro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCarro));
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbQuilometragem = new System.Windows.Forms.TextBox();
            this.txbPlaca = new System.Windows.Forms.TextBox();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.lblQuilometragem = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbQuilometragemEdit = new System.Windows.Forms.TextBox();
            this.txbPlacaEdit = new System.Windows.Forms.TextBox();
            this.txbModeloEdit = new System.Windows.Forms.TextBox();
            this.txbMarcaEdit = new System.Windows.Forms.TextBox();
            this.lblQuilometragemEdit = new System.Windows.Forms.Label();
            this.lblPlacaEdit = new System.Windows.Forms.Label();
            this.lblModeloEdit = new System.Windows.Forms.Label();
            this.lblMarcaEdit = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblAnoCadastrar = new System.Windows.Forms.Label();
            this.txbAnoCadastrar = new System.Windows.Forms.TextBox();
            this.txbPrecoCadastrar = new System.Windows.Forms.TextBox();
            this.lblPrecoCadastrar = new System.Windows.Forms.Label();
            this.lblPrecoEditar = new System.Windows.Forms.Label();
            this.txbPrecoEdit = new System.Windows.Forms.TextBox();
            this.txbAnoEdit = new System.Windows.Forms.TextBox();
            this.lblAnoEditar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCarros
            // 
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Location = new System.Drawing.Point(619, 34);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.ReadOnly = true;
            this.dgvCarros.Size = new System.Drawing.Size(416, 562);
            this.dgvCarros.TabIndex = 0;
            this.dgvCarros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarros_CellClick);
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.lblPrecoCadastrar);
            this.grbCadastrar.Controls.Add(this.txbPrecoCadastrar);
            this.grbCadastrar.Controls.Add(this.txbAnoCadastrar);
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.lblAnoCadastrar);
            this.grbCadastrar.Controls.Add(this.txbQuilometragem);
            this.grbCadastrar.Controls.Add(this.txbPlaca);
            this.grbCadastrar.Controls.Add(this.txbModelo);
            this.grbCadastrar.Controls.Add(this.txbMarca);
            this.grbCadastrar.Controls.Add(this.lblQuilometragem);
            this.grbCadastrar.Controls.Add(this.lblPlaca);
            this.grbCadastrar.Controls.Add(this.lblModelo);
            this.grbCadastrar.Controls.Add(this.lblMarca);
            this.grbCadastrar.Location = new System.Drawing.Point(12, 89);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(265, 363);
            this.grbCadastrar.TabIndex = 1;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "CADASTRAR";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(20, 306);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(227, 39);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbQuilometragem
            // 
            this.txbQuilometragem.Location = new System.Drawing.Point(118, 158);
            this.txbQuilometragem.Name = "txbQuilometragem";
            this.txbQuilometragem.Size = new System.Drawing.Size(129, 20);
            this.txbQuilometragem.TabIndex = 6;
            // 
            // txbPlaca
            // 
            this.txbPlaca.Location = new System.Drawing.Point(118, 121);
            this.txbPlaca.Name = "txbPlaca";
            this.txbPlaca.Size = new System.Drawing.Size(129, 20);
            this.txbPlaca.TabIndex = 5;
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(118, 77);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(129, 20);
            this.txbModelo.TabIndex = 4;
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(118, 41);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(129, 20);
            this.txbMarca.TabIndex = 3;
            // 
            // lblQuilometragem
            // 
            this.lblQuilometragem.AutoSize = true;
            this.lblQuilometragem.Location = new System.Drawing.Point(17, 158);
            this.lblQuilometragem.Name = "lblQuilometragem";
            this.lblQuilometragem.Size = new System.Drawing.Size(77, 13);
            this.lblQuilometragem.TabIndex = 3;
            this.lblQuilometragem.Text = "Quilometragem";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(17, 121);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(34, 13);
            this.lblPlaca.TabIndex = 2;
            this.lblPlaca.Text = "Placa";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(17, 80);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(17, 41);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(27, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "CADASTRAR CARRO";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.lblPrecoEditar);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbQuilometragemEdit);
            this.grbEditar.Controls.Add(this.txbPrecoEdit);
            this.grbEditar.Controls.Add(this.txbPlacaEdit);
            this.grbEditar.Controls.Add(this.txbAnoEdit);
            this.grbEditar.Controls.Add(this.txbModeloEdit);
            this.grbEditar.Controls.Add(this.lblAnoEditar);
            this.grbEditar.Controls.Add(this.txbMarcaEdit);
            this.grbEditar.Controls.Add(this.lblQuilometragemEdit);
            this.grbEditar.Controls.Add(this.lblPlacaEdit);
            this.grbEditar.Controls.Add(this.lblModeloEdit);
            this.grbEditar.Controls.Add(this.lblMarcaEdit);
            this.grbEditar.Enabled = false;
            this.grbEditar.Location = new System.Drawing.Point(318, 89);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(265, 363);
            this.grbEditar.TabIndex = 3;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "EDITAR";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(20, 306);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(227, 39);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbQuilometragemEdit
            // 
            this.txbQuilometragemEdit.Location = new System.Drawing.Point(118, 158);
            this.txbQuilometragemEdit.Name = "txbQuilometragemEdit";
            this.txbQuilometragemEdit.Size = new System.Drawing.Size(129, 20);
            this.txbQuilometragemEdit.TabIndex = 6;
            // 
            // txbPlacaEdit
            // 
            this.txbPlacaEdit.Location = new System.Drawing.Point(118, 121);
            this.txbPlacaEdit.Name = "txbPlacaEdit";
            this.txbPlacaEdit.Size = new System.Drawing.Size(129, 20);
            this.txbPlacaEdit.TabIndex = 5;
            // 
            // txbModeloEdit
            // 
            this.txbModeloEdit.Location = new System.Drawing.Point(118, 77);
            this.txbModeloEdit.Name = "txbModeloEdit";
            this.txbModeloEdit.Size = new System.Drawing.Size(129, 20);
            this.txbModeloEdit.TabIndex = 4;
            // 
            // txbMarcaEdit
            // 
            this.txbMarcaEdit.Location = new System.Drawing.Point(118, 41);
            this.txbMarcaEdit.Name = "txbMarcaEdit";
            this.txbMarcaEdit.Size = new System.Drawing.Size(129, 20);
            this.txbMarcaEdit.TabIndex = 3;
            // 
            // lblQuilometragemEdit
            // 
            this.lblQuilometragemEdit.AutoSize = true;
            this.lblQuilometragemEdit.Location = new System.Drawing.Point(17, 158);
            this.lblQuilometragemEdit.Name = "lblQuilometragemEdit";
            this.lblQuilometragemEdit.Size = new System.Drawing.Size(77, 13);
            this.lblQuilometragemEdit.TabIndex = 3;
            this.lblQuilometragemEdit.Text = "Quilometragem";
            // 
            // lblPlacaEdit
            // 
            this.lblPlacaEdit.AutoSize = true;
            this.lblPlacaEdit.Location = new System.Drawing.Point(17, 121);
            this.lblPlacaEdit.Name = "lblPlacaEdit";
            this.lblPlacaEdit.Size = new System.Drawing.Size(34, 13);
            this.lblPlacaEdit.TabIndex = 2;
            this.lblPlacaEdit.Text = "Placa";
            // 
            // lblModeloEdit
            // 
            this.lblModeloEdit.AutoSize = true;
            this.lblModeloEdit.Location = new System.Drawing.Point(17, 80);
            this.lblModeloEdit.Name = "lblModeloEdit";
            this.lblModeloEdit.Size = new System.Drawing.Size(42, 13);
            this.lblModeloEdit.TabIndex = 1;
            this.lblModeloEdit.Text = "Modelo";
            // 
            // lblMarcaEdit
            // 
            this.lblMarcaEdit.AutoSize = true;
            this.lblMarcaEdit.Location = new System.Drawing.Point(17, 41);
            this.lblMarcaEdit.Name = "lblMarcaEdit";
            this.lblMarcaEdit.Size = new System.Drawing.Size(37, 13);
            this.lblMarcaEdit.TabIndex = 0;
            this.lblMarcaEdit.Text = "Marca";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblMensagem);
            this.grbApagar.Enabled = false;
            this.grbApagar.Location = new System.Drawing.Point(150, 479);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(280, 134);
            this.grbApagar.TabIndex = 4;
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
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
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
            // lblAnoCadastrar
            // 
            this.lblAnoCadastrar.AutoSize = true;
            this.lblAnoCadastrar.Location = new System.Drawing.Point(17, 196);
            this.lblAnoCadastrar.Name = "lblAnoCadastrar";
            this.lblAnoCadastrar.Size = new System.Drawing.Size(26, 13);
            this.lblAnoCadastrar.TabIndex = 8;
            this.lblAnoCadastrar.Text = "Ano";
            // 
            // txbAnoCadastrar
            // 
            this.txbAnoCadastrar.Location = new System.Drawing.Point(118, 196);
            this.txbAnoCadastrar.Name = "txbAnoCadastrar";
            this.txbAnoCadastrar.Size = new System.Drawing.Size(129, 20);
            this.txbAnoCadastrar.TabIndex = 8;
            // 
            // txbPrecoCadastrar
            // 
            this.txbPrecoCadastrar.Location = new System.Drawing.Point(118, 230);
            this.txbPrecoCadastrar.Name = "txbPrecoCadastrar";
            this.txbPrecoCadastrar.Size = new System.Drawing.Size(129, 20);
            this.txbPrecoCadastrar.TabIndex = 9;
            // 
            // lblPrecoCadastrar
            // 
            this.lblPrecoCadastrar.AutoSize = true;
            this.lblPrecoCadastrar.Location = new System.Drawing.Point(17, 237);
            this.lblPrecoCadastrar.Name = "lblPrecoCadastrar";
            this.lblPrecoCadastrar.Size = new System.Drawing.Size(35, 13);
            this.lblPrecoCadastrar.TabIndex = 10;
            this.lblPrecoCadastrar.Text = "Preço";
            // 
            // lblPrecoEditar
            // 
            this.lblPrecoEditar.AutoSize = true;
            this.lblPrecoEditar.Location = new System.Drawing.Point(17, 237);
            this.lblPrecoEditar.Name = "lblPrecoEditar";
            this.lblPrecoEditar.Size = new System.Drawing.Size(35, 13);
            this.lblPrecoEditar.TabIndex = 14;
            this.lblPrecoEditar.Text = "Preço";
            // 
            // txbPrecoEdit
            // 
            this.txbPrecoEdit.Location = new System.Drawing.Point(118, 230);
            this.txbPrecoEdit.Name = "txbPrecoEdit";
            this.txbPrecoEdit.Size = new System.Drawing.Size(129, 20);
            this.txbPrecoEdit.TabIndex = 13;
            // 
            // txbAnoEdit
            // 
            this.txbAnoEdit.Location = new System.Drawing.Point(118, 196);
            this.txbAnoEdit.Name = "txbAnoEdit";
            this.txbAnoEdit.Size = new System.Drawing.Size(129, 20);
            this.txbAnoEdit.TabIndex = 11;
            // 
            // lblAnoEditar
            // 
            this.lblAnoEditar.AutoSize = true;
            this.lblAnoEditar.Location = new System.Drawing.Point(17, 196);
            this.lblAnoEditar.Name = "lblAnoEditar";
            this.lblAnoEditar.Size = new System.Drawing.Size(26, 13);
            this.lblAnoEditar.TabIndex = 12;
            this.lblAnoEditar.Text = "Ano";
            // 
            // CadastrarCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 625);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvCarros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModelosDisponiveis";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.Label lblQuilometragem;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txbQuilometragem;
        private System.Windows.Forms.TextBox txbPlaca;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbQuilometragemEdit;
        private System.Windows.Forms.TextBox txbPlacaEdit;
        private System.Windows.Forms.TextBox txbModeloEdit;
        private System.Windows.Forms.TextBox txbMarcaEdit;
        private System.Windows.Forms.Label lblQuilometragemEdit;
        private System.Windows.Forms.Label lblPlacaEdit;
        private System.Windows.Forms.Label lblModeloEdit;
        private System.Windows.Forms.Label lblMarcaEdit;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblPrecoCadastrar;
        private System.Windows.Forms.TextBox txbPrecoCadastrar;
        private System.Windows.Forms.TextBox txbAnoCadastrar;
        private System.Windows.Forms.Label lblAnoCadastrar;
        private System.Windows.Forms.Label lblPrecoEditar;
        private System.Windows.Forms.TextBox txbPrecoEdit;
        private System.Windows.Forms.TextBox txbAnoEdit;
        private System.Windows.Forms.Label lblAnoEditar;
    }
}