namespace Burrice_Artificial
{
    partial class frmCategoria
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            this.gpBoxBotoes = new System.Windows.Forms.GroupBox();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnPosterior = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.gpBoxInputs = new System.Windows.Forms.GroupBox();
            this.comboBoxProfissao = new System.Windows.Forms.ComboBox();
            this.tb_categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetzumbumbaboonbagosmalevolentesbehavior = new Burrice_Artificial.dataSetzumbumbaboonbagosmalevolentesbehavior();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtBoxNm = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblProfissao = new System.Windows.Forms.Label();
            this.lblNm = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nAVEGAÇÃOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bURRICEARTIFICIALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATEGORIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fABRICANTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tESTECONEXÃOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALVARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cANCELARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lIMPARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rETORNARStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_categoriaTableAdapter = new Burrice_Artificial.dataSetzumbumbaboonbagosmalevolentesbehaviorTableAdapters.tb_categoriaTableAdapter();
            this.gpBoxBotoes.SuspendLayout();
            this.gpBoxInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetzumbumbaboonbagosmalevolentesbehavior)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpBoxBotoes
            // 
            this.gpBoxBotoes.Controls.Add(this.btnUltimo);
            this.gpBoxBotoes.Controls.Add(this.btnProximo);
            this.gpBoxBotoes.Controls.Add(this.btnPosterior);
            this.gpBoxBotoes.Controls.Add(this.btnPrimeiro);
            this.gpBoxBotoes.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.gpBoxBotoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpBoxBotoes.Location = new System.Drawing.Point(51, 334);
            this.gpBoxBotoes.Name = "gpBoxBotoes";
            this.gpBoxBotoes.Size = new System.Drawing.Size(703, 105);
            this.gpBoxBotoes.TabIndex = 20;
            this.gpBoxBotoes.TabStop = false;
            this.gpBoxBotoes.Text = "BOTÕES";
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.Color.IndianRed;
            this.btnUltimo.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnUltimo.FlatAppearance.BorderSize = 4;
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnUltimo.ForeColor = System.Drawing.Color.MistyRose;
            this.btnUltimo.Location = new System.Drawing.Point(500, 29);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(127, 45);
            this.btnUltimo.TabIndex = 15;
            this.btnUltimo.Text = "ÚLTIMO";
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.BtnUltimo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.IndianRed;
            this.btnProximo.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnProximo.FlatAppearance.BorderSize = 4;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnProximo.ForeColor = System.Drawing.Color.MistyRose;
            this.btnProximo.Location = new System.Drawing.Point(358, 29);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(127, 45);
            this.btnProximo.TabIndex = 14;
            this.btnProximo.Text = "PRÓXIMO";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // btnPosterior
            // 
            this.btnPosterior.BackColor = System.Drawing.Color.IndianRed;
            this.btnPosterior.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnPosterior.FlatAppearance.BorderSize = 4;
            this.btnPosterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosterior.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnPosterior.ForeColor = System.Drawing.Color.MistyRose;
            this.btnPosterior.Location = new System.Drawing.Point(217, 29);
            this.btnPosterior.Name = "btnPosterior";
            this.btnPosterior.Size = new System.Drawing.Size(127, 45);
            this.btnPosterior.TabIndex = 13;
            this.btnPosterior.Text = "POSTERIOR";
            this.btnPosterior.UseVisualStyleBackColor = false;
            this.btnPosterior.Click += new System.EventHandler(this.BtnPosterior_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.BackColor = System.Drawing.Color.IndianRed;
            this.btnPrimeiro.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnPrimeiro.FlatAppearance.BorderSize = 4;
            this.btnPrimeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeiro.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrimeiro.ForeColor = System.Drawing.Color.MistyRose;
            this.btnPrimeiro.Location = new System.Drawing.Point(75, 29);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(127, 45);
            this.btnPrimeiro.TabIndex = 12;
            this.btnPrimeiro.Text = "PRIMEIRO";
            this.btnPrimeiro.UseVisualStyleBackColor = false;
            this.btnPrimeiro.Click += new System.EventHandler(this.BtnPrimeiro_Click);
            // 
            // gpBoxInputs
            // 
            this.gpBoxInputs.Controls.Add(this.comboBoxProfissao);
            this.gpBoxInputs.Controls.Add(this.btnBuscar);
            this.gpBoxInputs.Controls.Add(this.txtBoxID);
            this.gpBoxInputs.Controls.Add(this.txtBoxNm);
            this.gpBoxInputs.Controls.Add(this.lblID);
            this.gpBoxInputs.Controls.Add(this.lblProfissao);
            this.gpBoxInputs.Controls.Add(this.lblNm);
            this.gpBoxInputs.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxInputs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpBoxInputs.Location = new System.Drawing.Point(51, 62);
            this.gpBoxInputs.Name = "gpBoxInputs";
            this.gpBoxInputs.Size = new System.Drawing.Size(702, 250);
            this.gpBoxInputs.TabIndex = 19;
            this.gpBoxInputs.TabStop = false;
            this.gpBoxInputs.Text = "FORMS";
            // 
            // comboBoxProfissao
            // 
            this.comboBoxProfissao.BackColor = System.Drawing.Color.MistyRose;
            this.comboBoxProfissao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_categoriaBindingSource, "profissao", true));
            this.comboBoxProfissao.Enabled = false;
            this.comboBoxProfissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProfissao.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.comboBoxProfissao.FormattingEnabled = true;
            this.comboBoxProfissao.Items.AddRange(new object[] {
            "Redação",
            "Aprendizagem",
            "Tecnologia",
            "Medicina",
            "Programação",
            "Apresentação",
            "Conversação"});
            this.comboBoxProfissao.Location = new System.Drawing.Point(211, 69);
            this.comboBoxProfissao.Name = "comboBoxProfissao";
            this.comboBoxProfissao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxProfissao.Size = new System.Drawing.Size(269, 35);
            this.comboBoxProfissao.TabIndex = 19;
            // 
            // tb_categoriaBindingSource
            // 
            this.tb_categoriaBindingSource.DataMember = "tb_categoria";
            this.tb_categoriaBindingSource.DataSource = this.dataSetzumbumbaboonbagosmalevolentesbehavior;
            // 
            // dataSetzumbumbaboonbagosmalevolentesbehavior
            // 
            this.dataSetzumbumbaboonbagosmalevolentesbehavior.DataSetName = "dataSetzumbumbaboonbagosmalevolentesbehavior";
            this.dataSetzumbumbaboonbagosmalevolentesbehavior.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.IndianRed;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnBuscar.FlatAppearance.BorderSize = 4;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.MistyRose;
            this.btnBuscar.Location = new System.Drawing.Point(382, 115);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 32);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtBoxID
            // 
            this.txtBoxID.BackColor = System.Drawing.Color.MistyRose;
            this.txtBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_categoriaBindingSource, "pk_categoria", true));
            this.txtBoxID.Enabled = false;
            this.txtBoxID.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxID.Location = new System.Drawing.Point(211, 115);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.ReadOnly = true;
            this.txtBoxID.Size = new System.Drawing.Size(165, 32);
            this.txtBoxID.TabIndex = 10;
            this.txtBoxID.TextChanged += new System.EventHandler(this.TxtBoxID_TextChanged);
            // 
            // txtBoxNm
            // 
            this.txtBoxNm.BackColor = System.Drawing.Color.MistyRose;
            this.txtBoxNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_categoriaBindingSource, "nome", true));
            this.txtBoxNm.Enabled = false;
            this.txtBoxNm.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNm.Location = new System.Drawing.Point(211, 24);
            this.txtBoxNm.Name = "txtBoxNm";
            this.txtBoxNm.Size = new System.Drawing.Size(269, 32);
            this.txtBoxNm.TabIndex = 6;
            this.txtBoxNm.TextChanged += new System.EventHandler(this.TxtBoxNm_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblID.Location = new System.Drawing.Point(59, 115);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(32, 27);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID";
            // 
            // lblProfissao
            // 
            this.lblProfissao.AutoSize = true;
            this.lblProfissao.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfissao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProfissao.Location = new System.Drawing.Point(59, 72);
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(120, 27);
            this.lblProfissao.TabIndex = 2;
            this.lblProfissao.Text = "PROFISSÃO";
            // 
            // lblNm
            // 
            this.lblNm.AutoSize = true;
            this.lblNm.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNm.Location = new System.Drawing.Point(59, 29);
            this.lblNm.Name = "lblNm";
            this.lblNm.Size = new System.Drawing.Size(69, 27);
            this.lblNm.TabIndex = 1;
            this.lblNm.Text = "NOME";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.IndianRed;
            this.menuStrip1.Font = new System.Drawing.Font("TechnicBold", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nAVEGAÇÃOToolStripMenuItem,
            this.cADASTRARToolStripMenuItem,
            this.sALVARToolStripMenuItem,
            this.dELETARToolStripMenuItem,
            this.eDITARToolStripMenuItem,
            this.cANCELARToolStripMenuItem,
            this.lIMPARToolStripMenuItem,
            this.rETORNARStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 13, 0, 13);
            this.menuStrip1.Size = new System.Drawing.Size(803, 48);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // nAVEGAÇÃOToolStripMenuItem
            // 
            this.nAVEGAÇÃOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem,
            this.bURRICEARTIFICIALToolStripMenuItem,
            this.cATEGORIAToolStripMenuItem,
            this.fABRICANTEToolStripMenuItem,
            this.tESTECONEXÃOToolStripMenuItem});
            this.nAVEGAÇÃOToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nAVEGAÇÃOToolStripMenuItem.Name = "nAVEGAÇÃOToolStripMenuItem";
            this.nAVEGAÇÃOToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.nAVEGAÇÃOToolStripMenuItem.Text = "NAVEGAÇÃO";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.mENUToolStripMenuItem.Text = "MENU";
            this.mENUToolStripMenuItem.Click += new System.EventHandler(this.MENUToolStripMenuItem_Click);
            // 
            // bURRICEARTIFICIALToolStripMenuItem
            // 
            this.bURRICEARTIFICIALToolStripMenuItem.Name = "bURRICEARTIFICIALToolStripMenuItem";
            this.bURRICEARTIFICIALToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.bURRICEARTIFICIALToolStripMenuItem.Text = "BURRICE ARTIFICIAL";
            this.bURRICEARTIFICIALToolStripMenuItem.Click += new System.EventHandler(this.BURRICEARTIFICIALToolStripMenuItem_Click);
            // 
            // cATEGORIAToolStripMenuItem
            // 
            this.cATEGORIAToolStripMenuItem.Name = "cATEGORIAToolStripMenuItem";
            this.cATEGORIAToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.cATEGORIAToolStripMenuItem.Text = "CATEGORIA";
            this.cATEGORIAToolStripMenuItem.Click += new System.EventHandler(this.FORNECEDORToolStripMenuItem_Click);
            // 
            // fABRICANTEToolStripMenuItem
            // 
            this.fABRICANTEToolStripMenuItem.Name = "fABRICANTEToolStripMenuItem";
            this.fABRICANTEToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.fABRICANTEToolStripMenuItem.Text = "FABRICANTE";
            this.fABRICANTEToolStripMenuItem.Click += new System.EventHandler(this.FABRICANTEToolStripMenuItem_Click);
            // 
            // tESTECONEXÃOToolStripMenuItem
            // 
            this.tESTECONEXÃOToolStripMenuItem.Name = "tESTECONEXÃOToolStripMenuItem";
            this.tESTECONEXÃOToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.tESTECONEXÃOToolStripMenuItem.Text = "TESTE CONEXÃO";
            this.tESTECONEXÃOToolStripMenuItem.Click += new System.EventHandler(this.TESTECONEXÃOToolStripMenuItem_Click);
            // 
            // cADASTRARToolStripMenuItem
            // 
            this.cADASTRARToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cADASTRARToolStripMenuItem.Name = "cADASTRARToolStripMenuItem";
            this.cADASTRARToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.cADASTRARToolStripMenuItem.Text = "CADASTRAR";
            this.cADASTRARToolStripMenuItem.Click += new System.EventHandler(this.CADASTRARToolStripMenuItem_Click);
            // 
            // sALVARToolStripMenuItem
            // 
            this.sALVARToolStripMenuItem.Enabled = false;
            this.sALVARToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sALVARToolStripMenuItem.Name = "sALVARToolStripMenuItem";
            this.sALVARToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.sALVARToolStripMenuItem.Text = "SALVAR";
            this.sALVARToolStripMenuItem.Click += new System.EventHandler(this.SALVARToolStripMenuItem_Click);
            // 
            // dELETARToolStripMenuItem
            // 
            this.dELETARToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dELETARToolStripMenuItem.Name = "dELETARToolStripMenuItem";
            this.dELETARToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.dELETARToolStripMenuItem.Text = "DELETAR";
            this.dELETARToolStripMenuItem.Click += new System.EventHandler(this.DELETARToolStripMenuItem_Click);
            // 
            // eDITARToolStripMenuItem
            // 
            this.eDITARToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eDITARToolStripMenuItem.Name = "eDITARToolStripMenuItem";
            this.eDITARToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.eDITARToolStripMenuItem.Text = "EDITAR";
            this.eDITARToolStripMenuItem.Click += new System.EventHandler(this.EDITARToolStripMenuItem_Click);
            // 
            // cANCELARToolStripMenuItem
            // 
            this.cANCELARToolStripMenuItem.Enabled = false;
            this.cANCELARToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cANCELARToolStripMenuItem.Name = "cANCELARToolStripMenuItem";
            this.cANCELARToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.cANCELARToolStripMenuItem.Text = "CANCELAR";
            this.cANCELARToolStripMenuItem.Click += new System.EventHandler(this.RETORNARToolStripMenuItem_Click);
            // 
            // lIMPARToolStripMenuItem
            // 
            this.lIMPARToolStripMenuItem.Enabled = false;
            this.lIMPARToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lIMPARToolStripMenuItem.Name = "lIMPARToolStripMenuItem";
            this.lIMPARToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.lIMPARToolStripMenuItem.Text = "LIMPAR";
            this.lIMPARToolStripMenuItem.Click += new System.EventHandler(this.LImparToolStripMenuItem_Click);
            // 
            // rETORNARStripMenuItem1
            // 
            this.rETORNARStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rETORNARStripMenuItem1.Name = "rETORNARStripMenuItem1";
            this.rETORNARStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.rETORNARStripMenuItem1.Text = "RETORNAR";
            this.rETORNARStripMenuItem1.Click += new System.EventHandler(this.RETORNARStripMenuItem1_Click);
            // 
            // tb_categoriaTableAdapter
            // 
            this.tb_categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.gpBoxBotoes);
            this.Controls.Add(this.gpBoxInputs);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forms Categoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            this.gpBoxBotoes.ResumeLayout(false);
            this.gpBoxInputs.ResumeLayout(false);
            this.gpBoxInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetzumbumbaboonbagosmalevolentesbehavior)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBoxBotoes;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnPosterior;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.GroupBox gpBoxInputs;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox txtBoxNm;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblProfissao;
        private System.Windows.Forms.Label lblNm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nAVEGAÇÃOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bURRICEARTIFICIALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATEGORIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fABRICANTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALVARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cANCELARToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxProfissao;
        private System.Windows.Forms.ToolStripMenuItem tESTECONEXÃOToolStripMenuItem;
        private dataSetzumbumbaboonbagosmalevolentesbehavior dataSetzumbumbaboonbagosmalevolentesbehavior;
        private dataSetzumbumbaboonbagosmalevolentesbehaviorTableAdapters.tb_categoriaTableAdapter tb_categoriaTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem lIMPARToolStripMenuItem;
        private System.Windows.Forms.BindingSource tb_categoriaBindingSource;
        private System.Windows.Forms.ToolStripMenuItem rETORNARStripMenuItem1;
    }
}