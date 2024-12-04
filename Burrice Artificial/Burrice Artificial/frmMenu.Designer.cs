namespace Burrice_Artificial
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnBurriceArtificial = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnFabricante = new System.Windows.Forms.Button();
            this.btnConecTest = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.gpBoxMenuIn = new System.Windows.Forms.GroupBox();
            this.gpBoxMenuOut = new System.Windows.Forms.GroupBox();
            this.gpBoxMenuIn.SuspendLayout();
            this.gpBoxMenuOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBurriceArtificial
            // 
            this.btnBurriceArtificial.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBurriceArtificial.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnBurriceArtificial.FlatAppearance.BorderSize = 4;
            this.btnBurriceArtificial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBurriceArtificial.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurriceArtificial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBurriceArtificial.Location = new System.Drawing.Point(60, 116);
            this.btnBurriceArtificial.Name = "btnBurriceArtificial";
            this.btnBurriceArtificial.Size = new System.Drawing.Size(142, 66);
            this.btnBurriceArtificial.TabIndex = 0;
            this.btnBurriceArtificial.Text = "BURRICE ARTIFICIAL";
            this.btnBurriceArtificial.UseVisualStyleBackColor = false;
            this.btnBurriceArtificial.Click += new System.EventHandler(this.BtnBurriceArtificial_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("TechnicBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(4, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(368, 26);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "FORMS - BURRICE ARTIFICIAL";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCategoria.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnCategoria.FlatAppearance.BorderSize = 4;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCategoria.Location = new System.Drawing.Point(60, 202);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(142, 66);
            this.btnCategoria.TabIndex = 6;
            this.btnCategoria.Text = "CATEGORIA";
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.BtnFornecedor_Click);
            // 
            // btnFabricante
            // 
            this.btnFabricante.BackColor = System.Drawing.Color.DarkCyan;
            this.btnFabricante.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnFabricante.FlatAppearance.BorderSize = 4;
            this.btnFabricante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFabricante.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFabricante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFabricante.Location = new System.Drawing.Point(60, 288);
            this.btnFabricante.Name = "btnFabricante";
            this.btnFabricante.Size = new System.Drawing.Size(142, 66);
            this.btnFabricante.TabIndex = 7;
            this.btnFabricante.Text = "FABRICANTE";
            this.btnFabricante.UseVisualStyleBackColor = false;
            this.btnFabricante.Click += new System.EventHandler(this.BtnFabricante_Click);
            // 
            // btnConecTest
            // 
            this.btnConecTest.BackColor = System.Drawing.Color.DarkCyan;
            this.btnConecTest.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnConecTest.FlatAppearance.BorderSize = 4;
            this.btnConecTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConecTest.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConecTest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConecTest.Location = new System.Drawing.Point(223, 159);
            this.btnConecTest.Name = "btnConecTest";
            this.btnConecTest.Size = new System.Drawing.Size(100, 66);
            this.btnConecTest.TabIndex = 8;
            this.btnConecTest.Text = "Teste Conexão";
            this.btnConecTest.UseVisualStyleBackColor = false;
            this.btnConecTest.Click += new System.EventHandler(this.BtnConecTest_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnFechar.FlatAppearance.BorderSize = 4;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFechar.Location = new System.Drawing.Point(223, 245);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 66);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // gpBoxMenuIn
            // 
            this.gpBoxMenuIn.Controls.Add(this.btnFechar);
            this.gpBoxMenuIn.Controls.Add(this.lblTitulo);
            this.gpBoxMenuIn.Controls.Add(this.btnConecTest);
            this.gpBoxMenuIn.Controls.Add(this.btnFabricante);
            this.gpBoxMenuIn.Controls.Add(this.btnCategoria);
            this.gpBoxMenuIn.Controls.Add(this.btnBurriceArtificial);
            this.gpBoxMenuIn.Location = new System.Drawing.Point(18, 15);
            this.gpBoxMenuIn.Name = "gpBoxMenuIn";
            this.gpBoxMenuIn.Size = new System.Drawing.Size(376, 426);
            this.gpBoxMenuIn.TabIndex = 10;
            this.gpBoxMenuIn.TabStop = false;
            // 
            // gpBoxMenuOut
            // 
            this.gpBoxMenuOut.Controls.Add(this.gpBoxMenuIn);
            this.gpBoxMenuOut.Location = new System.Drawing.Point(9, 2);
            this.gpBoxMenuOut.Name = "gpBoxMenuOut";
            this.gpBoxMenuOut.Size = new System.Drawing.Size(410, 459);
            this.gpBoxMenuOut.TabIndex = 11;
            this.gpBoxMenuOut.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(428, 468);
            this.Controls.Add(this.gpBoxMenuOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.gpBoxMenuIn.ResumeLayout(false);
            this.gpBoxMenuIn.PerformLayout();
            this.gpBoxMenuOut.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBurriceArtificial;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnFabricante;
        private System.Windows.Forms.Button btnConecTest;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.GroupBox gpBoxMenuIn;
        private System.Windows.Forms.GroupBox gpBoxMenuOut;
    }
}

