namespace Burrice_Artificial
{
    partial class frmBurriceArtificial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBurriceArtificial));
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnPosterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.gpBoxBotoes = new System.Windows.Forms.GroupBox();
            this.lblNm = new System.Windows.Forms.Label();
            this.lblLanc = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtBoxNm = new System.Windows.Forms.TextBox();
            this.tb_burriceartificialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetzumbumbaboonbagosmalevolentesbehavior = new Burrice_Artificial.dataSetzumbumbaboonbagosmalevolentesbehavior();
            this.txtBoxFabricante = new System.Windows.Forms.TextBox();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.maskedTxtBoxLanc = new System.Windows.Forms.MaskedTextBox();
            this.gpBoxInputs = new System.Windows.Forms.GroupBox();
            this.btnFabricanteVisualizar = new System.Windows.Forms.Button();
            this.btnCategoriaVisualizar = new System.Windows.Forms.Button();
            this.btnSelecionarImagem = new System.Windows.Forms.Button();
            this.txtBoxCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.pictureBoxIALogo = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
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
            this.rETORNARStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcherIALogo = new System.IO.FileSystemWatcher();
            this.tb_burriceartificialTableAdapter = new Burrice_Artificial.dataSetzumbumbaboonbagosmalevolentesbehaviorTableAdapters.tb_burriceartificialTableAdapter();
            this.gpBoxBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_burriceartificialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetzumbumbaboonbagosmalevolentesbehavior)).BeginInit();
            this.gpBoxInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIALogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherIALogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.BackColor = System.Drawing.Color.Sienna;
            this.btnPrimeiro.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnPrimeiro.FlatAppearance.BorderSize = 4;
            this.btnPrimeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeiro.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrimeiro.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnPrimeiro.Location = new System.Drawing.Point(75, 29);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(127, 45);
            this.btnPrimeiro.TabIndex = 12;
            this.btnPrimeiro.Text = "PRIMEIRO";
            this.btnPrimeiro.UseVisualStyleBackColor = false;
            this.btnPrimeiro.Click += new System.EventHandler(this.BtnPrimeiro_Click);
            // 
            // btnPosterior
            // 
            this.btnPosterior.BackColor = System.Drawing.Color.Sienna;
            this.btnPosterior.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnPosterior.FlatAppearance.BorderSize = 4;
            this.btnPosterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosterior.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnPosterior.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnPosterior.Location = new System.Drawing.Point(217, 29);
            this.btnPosterior.Name = "btnPosterior";
            this.btnPosterior.Size = new System.Drawing.Size(127, 45);
            this.btnPosterior.TabIndex = 13;
            this.btnPosterior.Text = "POSTERIOR";
            this.btnPosterior.UseVisualStyleBackColor = false;
            this.btnPosterior.Click += new System.EventHandler(this.BtnPosterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.Sienna;
            this.btnProximo.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnProximo.FlatAppearance.BorderSize = 4;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnProximo.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnProximo.Location = new System.Drawing.Point(358, 29);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(127, 45);
            this.btnProximo.TabIndex = 14;
            this.btnProximo.Text = "PRÓXIMO";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.Color.Sienna;
            this.btnUltimo.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnUltimo.FlatAppearance.BorderSize = 4;
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnUltimo.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnUltimo.Location = new System.Drawing.Point(500, 29);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(127, 45);
            this.btnUltimo.TabIndex = 15;
            this.btnUltimo.Text = "ÚLTIMO";
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.BtnUltimo_Click);
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
            this.gpBoxBotoes.TabIndex = 17;
            this.gpBoxBotoes.TabStop = false;
            this.gpBoxBotoes.Text = "BOTÕES";
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
            // lblLanc
            // 
            this.lblLanc.AutoSize = true;
            this.lblLanc.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLanc.Location = new System.Drawing.Point(59, 72);
            this.lblLanc.Name = "lblLanc";
            this.lblLanc.Size = new System.Drawing.Size(146, 27);
            this.lblLanc.TabIndex = 2;
            this.lblLanc.Text = "LANÇAMENTO";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLogo.Location = new System.Drawing.Point(554, 29);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(68, 27);
            this.lblLogo.TabIndex = 3;
            this.lblLogo.Text = "LOGO";
            this.lblLogo.Click += new System.EventHandler(this.LblLogo_Click);
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFabricante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFabricante.Location = new System.Drawing.Point(59, 115);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(89, 27);
            this.lblFabricante.TabIndex = 4;
            this.lblFabricante.Text = "FK FBR.";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblID.Location = new System.Drawing.Point(59, 201);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(32, 27);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID";
            this.lblID.Click += new System.EventHandler(this.LblID_Click);
            // 
            // txtBoxNm
            // 
            this.txtBoxNm.BackColor = System.Drawing.Color.PeachPuff;
            this.txtBoxNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_burriceartificialBindingSource, "nome", true));
            this.txtBoxNm.Enabled = false;
            this.txtBoxNm.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNm.HideSelection = false;
            this.txtBoxNm.Location = new System.Drawing.Point(211, 24);
            this.txtBoxNm.Name = "txtBoxNm";
            this.txtBoxNm.Size = new System.Drawing.Size(269, 32);
            this.txtBoxNm.TabIndex = 6;
            // 
            // tb_burriceartificialBindingSource
            // 
            this.tb_burriceartificialBindingSource.DataMember = "tb_burriceartificial";
            this.tb_burriceartificialBindingSource.DataSource = this.dataSetzumbumbaboonbagosmalevolentesbehavior;
            // 
            // dataSetzumbumbaboonbagosmalevolentesbehavior
            // 
            this.dataSetzumbumbaboonbagosmalevolentesbehavior.DataSetName = "dataSetzumbumbaboonbagosmalevolentesbehavior";
            this.dataSetzumbumbaboonbagosmalevolentesbehavior.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBoxFabricante
            // 
            this.txtBoxFabricante.BackColor = System.Drawing.Color.PeachPuff;
            this.txtBoxFabricante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxFabricante.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_burriceartificialBindingSource, "fk_fabricante", true));
            this.txtBoxFabricante.Enabled = false;
            this.txtBoxFabricante.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFabricante.HideSelection = false;
            this.txtBoxFabricante.Location = new System.Drawing.Point(211, 115);
            this.txtBoxFabricante.Name = "txtBoxFabricante";
            this.txtBoxFabricante.Size = new System.Drawing.Size(165, 32);
            this.txtBoxFabricante.TabIndex = 9;
            this.txtBoxFabricante.TextChanged += new System.EventHandler(this.TxtBoxFabricante_TextChanged);
            // 
            // txtBoxID
            // 
            this.txtBoxID.BackColor = System.Drawing.Color.PeachPuff;
            this.txtBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_burriceartificialBindingSource, "pk_burriceartificial", true));
            this.txtBoxID.Enabled = false;
            this.txtBoxID.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxID.HideSelection = false;
            this.txtBoxID.Location = new System.Drawing.Point(211, 201);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.ReadOnly = true;
            this.txtBoxID.Size = new System.Drawing.Size(165, 32);
            this.txtBoxID.TabIndex = 10;
            this.txtBoxID.TextChanged += new System.EventHandler(this.TxtBoxID_TextChanged);
            // 
            // maskedTxtBoxLanc
            // 
            this.maskedTxtBoxLanc.BackColor = System.Drawing.Color.PeachPuff;
            this.maskedTxtBoxLanc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTxtBoxLanc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_burriceartificialBindingSource, "ano_lanc", true));
            this.maskedTxtBoxLanc.Enabled = false;
            this.maskedTxtBoxLanc.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxtBoxLanc.HideSelection = false;
            this.maskedTxtBoxLanc.Location = new System.Drawing.Point(211, 69);
            this.maskedTxtBoxLanc.Mask = "00/00/0000";
            this.maskedTxtBoxLanc.Name = "maskedTxtBoxLanc";
            this.maskedTxtBoxLanc.Size = new System.Drawing.Size(269, 32);
            this.maskedTxtBoxLanc.TabIndex = 11;
            this.maskedTxtBoxLanc.ValidatingType = typeof(System.DateTime);
            // 
            // gpBoxInputs
            // 
            this.gpBoxInputs.Controls.Add(this.btnFabricanteVisualizar);
            this.gpBoxInputs.Controls.Add(this.btnCategoriaVisualizar);
            this.gpBoxInputs.Controls.Add(this.btnSelecionarImagem);
            this.gpBoxInputs.Controls.Add(this.txtBoxCategoria);
            this.gpBoxInputs.Controls.Add(this.lblCategoria);
            this.gpBoxInputs.Controls.Add(this.pictureBoxIALogo);
            this.gpBoxInputs.Controls.Add(this.btnBuscar);
            this.gpBoxInputs.Controls.Add(this.maskedTxtBoxLanc);
            this.gpBoxInputs.Controls.Add(this.txtBoxID);
            this.gpBoxInputs.Controls.Add(this.txtBoxFabricante);
            this.gpBoxInputs.Controls.Add(this.txtBoxNm);
            this.gpBoxInputs.Controls.Add(this.lblID);
            this.gpBoxInputs.Controls.Add(this.lblFabricante);
            this.gpBoxInputs.Controls.Add(this.lblLogo);
            this.gpBoxInputs.Controls.Add(this.lblLanc);
            this.gpBoxInputs.Controls.Add(this.lblNm);
            this.gpBoxInputs.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxInputs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpBoxInputs.Location = new System.Drawing.Point(51, 62);
            this.gpBoxInputs.Name = "gpBoxInputs";
            this.gpBoxInputs.Size = new System.Drawing.Size(702, 250);
            this.gpBoxInputs.TabIndex = 16;
            this.gpBoxInputs.TabStop = false;
            this.gpBoxInputs.Text = "FORMS";
            // 
            // btnFabricanteVisualizar
            // 
            this.btnFabricanteVisualizar.BackColor = System.Drawing.Color.Sienna;
            this.btnFabricanteVisualizar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnFabricanteVisualizar.FlatAppearance.BorderSize = 4;
            this.btnFabricanteVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFabricanteVisualizar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFabricanteVisualizar.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnFabricanteVisualizar.Location = new System.Drawing.Point(382, 115);
            this.btnFabricanteVisualizar.Name = "btnFabricanteVisualizar";
            this.btnFabricanteVisualizar.Size = new System.Drawing.Size(98, 32);
            this.btnFabricanteVisualizar.TabIndex = 26;
            this.btnFabricanteVisualizar.Text = "VISUALIZAR";
            this.btnFabricanteVisualizar.UseVisualStyleBackColor = false;
            this.btnFabricanteVisualizar.Click += new System.EventHandler(this.BtnFabricanteVisualizar_Click);
            // 
            // btnCategoriaVisualizar
            // 
            this.btnCategoriaVisualizar.BackColor = System.Drawing.Color.Sienna;
            this.btnCategoriaVisualizar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnCategoriaVisualizar.FlatAppearance.BorderSize = 4;
            this.btnCategoriaVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoriaVisualizar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoriaVisualizar.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnCategoriaVisualizar.Location = new System.Drawing.Point(382, 158);
            this.btnCategoriaVisualizar.Name = "btnCategoriaVisualizar";
            this.btnCategoriaVisualizar.Size = new System.Drawing.Size(98, 32);
            this.btnCategoriaVisualizar.TabIndex = 25;
            this.btnCategoriaVisualizar.Text = "VISUALIZAR";
            this.btnCategoriaVisualizar.UseVisualStyleBackColor = false;
            this.btnCategoriaVisualizar.Click += new System.EventHandler(this.BtnCategoriaVisualizar_Click);
            // 
            // btnSelecionarImagem
            // 
            this.btnSelecionarImagem.BackColor = System.Drawing.Color.Sienna;
            this.btnSelecionarImagem.Enabled = false;
            this.btnSelecionarImagem.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnSelecionarImagem.FlatAppearance.BorderSize = 4;
            this.btnSelecionarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarImagem.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarImagem.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnSelecionarImagem.Location = new System.Drawing.Point(524, 203);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(129, 32);
            this.btnSelecionarImagem.TabIndex = 24;
            this.btnSelecionarImagem.Text = "SELECIONAR";
            this.btnSelecionarImagem.UseVisualStyleBackColor = false;
            this.btnSelecionarImagem.Click += new System.EventHandler(this.BtnSelecionarImagem_Click);
            // 
            // txtBoxCategoria
            // 
            this.txtBoxCategoria.BackColor = System.Drawing.Color.PeachPuff;
            this.txtBoxCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_burriceartificialBindingSource, "fk_categoria", true));
            this.txtBoxCategoria.Enabled = false;
            this.txtBoxCategoria.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCategoria.HideSelection = false;
            this.txtBoxCategoria.Location = new System.Drawing.Point(211, 158);
            this.txtBoxCategoria.Name = "txtBoxCategoria";
            this.txtBoxCategoria.Size = new System.Drawing.Size(165, 32);
            this.txtBoxCategoria.TabIndex = 21;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCategoria.Location = new System.Drawing.Point(59, 158);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(91, 27);
            this.lblCategoria.TabIndex = 20;
            this.lblCategoria.Text = "FK CTG.";
            // 
            // pictureBoxIALogo
            // 
            this.pictureBoxIALogo.BackColor = System.Drawing.Color.Peru;
            this.pictureBoxIALogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxIALogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxIALogo.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tb_burriceartificialBindingSource, "logo", true));
            this.pictureBoxIALogo.Enabled = false;
            this.pictureBoxIALogo.ImageLocation = "";
            this.pictureBoxIALogo.Location = new System.Drawing.Point(526, 59);
            this.pictureBoxIALogo.Name = "pictureBoxIALogo";
            this.pictureBoxIALogo.Size = new System.Drawing.Size(127, 131);
            this.pictureBoxIALogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIALogo.TabIndex = 19;
            this.pictureBoxIALogo.TabStop = false;
            this.pictureBoxIALogo.Click += new System.EventHandler(this.PictureBoxIALogo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Sienna;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnBuscar.FlatAppearance.BorderSize = 4;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnBuscar.Location = new System.Drawing.Point(382, 201);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 32);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Peru;
            this.menuStrip1.Font = new System.Drawing.Font("TechnicBold", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nAVEGAÇÃOToolStripMenuItem,
            this.cADASTRARToolStripMenuItem,
            this.sALVARToolStripMenuItem,
            this.dELETARToolStripMenuItem,
            this.eDITARToolStripMenuItem,
            this.cANCELARToolStripMenuItem,
            this.lIMPARToolStripMenuItem,
            this.rETORNARStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 13, 0, 13);
            this.menuStrip1.Size = new System.Drawing.Size(803, 48);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
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
            this.lIMPARToolStripMenuItem.Click += new System.EventHandler(this.LIMPARToolStripMenuItem_Click);
            // 
            // rETORNARStripMenuItem
            // 
            this.rETORNARStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rETORNARStripMenuItem.Name = "rETORNARStripMenuItem";
            this.rETORNARStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.rETORNARStripMenuItem.Text = "RETORNAR";
            this.rETORNARStripMenuItem.Click += new System.EventHandler(this.RETORNARStripMenuItem_Click);
            // 
            // fileSystemWatcherIALogo
            // 
            this.fileSystemWatcherIALogo.EnableRaisingEvents = true;
            this.fileSystemWatcherIALogo.SynchronizingObject = this;
            // 
            // tb_burriceartificialTableAdapter
            // 
            this.tb_burriceartificialTableAdapter.ClearBeforeFill = true;
            // 
            // frmBurriceArtificial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.gpBoxBotoes);
            this.Controls.Add(this.gpBoxInputs);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBurriceArtificial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forms Burrice Artificial";
            this.Load += new System.EventHandler(this.FrmBurriceArtificial_Load);
            this.gpBoxBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_burriceartificialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetzumbumbaboonbagosmalevolentesbehavior)).EndInit();
            this.gpBoxInputs.ResumeLayout(false);
            this.gpBoxInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIALogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherIALogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnPosterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.GroupBox gpBoxBotoes;
        private System.Windows.Forms.Label lblNm;
        private System.Windows.Forms.Label lblLanc;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtBoxNm;
        private System.Windows.Forms.TextBox txtBoxFabricante;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxLanc;
        private System.Windows.Forms.GroupBox gpBoxInputs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nAVEGAÇÃOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALVARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cANCELARToolStripMenuItem;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pictureBoxIALogo;
        private System.IO.FileSystemWatcher fileSystemWatcherIALogo;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bURRICEARTIFICIALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATEGORIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fABRICANTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tESTECONEXÃOToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBoxCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnSelecionarImagem;
        private System.Windows.Forms.ToolStripMenuItem lIMPARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rETORNARStripMenuItem;
        private dataSetzumbumbaboonbagosmalevolentesbehavior dataSetzumbumbaboonbagosmalevolentesbehavior;
        private System.Windows.Forms.BindingSource tb_burriceartificialBindingSource;
        private dataSetzumbumbaboonbagosmalevolentesbehaviorTableAdapters.tb_burriceartificialTableAdapter tb_burriceartificialTableAdapter;
        private System.Windows.Forms.Button btnFabricanteVisualizar;
        private System.Windows.Forms.Button btnCategoriaVisualizar;
    }
}