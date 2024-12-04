using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burrice_Artificial
{
    public partial class frmBurriceArtificial : Form
    {
        private OpenFileDialog ofd = new OpenFileDialog();
        public Image picture;
        string strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Downloads\\Projeto IA\\Burrice Artificial\\Burrice Artificial\\bdzumbumbaboonbagosmalevolentesbehavior.mdf;Connect Timeout = 30";
        public bool saveOrEdit = false;
        public frmBurriceArtificial()
        {
            InitializeComponent();
            imageLoad("1");
        }
        private void enableInputs()
        {
            txtBoxNm.Enabled = true;
            maskedTxtBoxLanc.Enabled = true;
            txtBoxFabricante.Enabled = true;
            txtBoxCategoria.Enabled = true;
            pictureBoxIALogo.Enabled = true;
            btnSelecionarImagem.Enabled = true;
            txtBoxID.Enabled = true;

            btnBuscar.Enabled = false;

            sALVARToolStripMenuItem.Enabled = true;
            cANCELARToolStripMenuItem.Enabled = true;
            lIMPARToolStripMenuItem.Enabled = true;

            btnPrimeiro.Enabled = false;
            btnProximo.Enabled = false;
            btnPosterior.Enabled = false;
            btnUltimo.Enabled = false;
        }
        private void disableInputs()
        {
            txtBoxNm.Enabled = false;
            maskedTxtBoxLanc.Enabled = false;
            txtBoxFabricante.Enabled = false;
            txtBoxCategoria.Enabled = false;
            pictureBoxIALogo.Enabled = false;
            btnSelecionarImagem.Enabled = false;
            txtBoxID.Enabled = false;

            btnBuscar.Enabled = true;

            sALVARToolStripMenuItem.Enabled = false;
            cANCELARToolStripMenuItem.Enabled = false;
            lIMPARToolStripMenuItem.Enabled = false;

            cADASTRARToolStripMenuItem.Enabled = true;
            dELETARToolStripMenuItem.Enabled = true;
            eDITARToolStripMenuItem.Enabled = true;

            btnPrimeiro.Enabled = true;
            btnProximo.Enabled = true;
            btnPosterior.Enabled = true;
            btnUltimo.Enabled = true;
        }
        private void disableEditButtons(string button)
        {
            switch (button)
            {
                case "cadastrar":
                    dELETARToolStripMenuItem.Enabled = false;
                    eDITARToolStripMenuItem.Enabled = false;
                    break;
                case "editar":
                    cADASTRARToolStripMenuItem.Enabled = false;
                    dELETARToolStripMenuItem.Enabled = false;
                    break;
                case "buscar":
                    cADASTRARToolStripMenuItem.Enabled = false;
                    eDITARToolStripMenuItem.Enabled = false;
                    dELETARToolStripMenuItem.Enabled = false;
                    break;
            }
        }
        private void clearForms()
        {
            txtBoxNm.Text = "";
            maskedTxtBoxLanc.Text = "";
            txtBoxFabricante.Text = "0";
            txtBoxCategoria.Text = "0";
            pictureBoxIALogo.Image = null;
            txtBoxID.Text = "";
        }
        private void imageLoad(string tbId)
        {
            try
            {
                if (string.IsNullOrEmpty(tbId))
                {
                    MessageBox.Show("Por favor, insira um ID válido.");
                    return;
                }

                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Downloads\\Projeto IA\\Burrice Artificial\\Burrice Artificial\\bdzumbumbaboonbagosmalevolentesbehavior.mdf;Connect Timeout = 30";
                string query = "SELECT logo FROM tb_burriceartificial WHERE pk_burriceartificial = @id";

                DataTable dataTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@id", tbId);
                    adapter.Fill(dataTable);
                }

                if (dataTable.Rows.Count > 0)
                {
                    byte[] imageBytes = (byte[])dataTable.Rows[0]["logo"];

                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBoxIALogo.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception error)
            {
             //   MessageBox.Show($"Deu erro: {error.Message}");
            }
        }
        private void LblID_Click(object sender, EventArgs e)
        {

        }

        private void LblLogo_Click(object sender, EventArgs e)
        {

        }

        private void RETORNARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disableInputs();
            txtBoxID.Enabled = false;
            txtBoxID.ReadOnly = true;
            imageLoad(txtBoxID.Text);

            tb_burriceartificialBindingSource.CancelEdit();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (txtBoxID.ReadOnly)
                {
                    case true:
                        txtBoxID.Enabled = true;
                        txtBoxID.ReadOnly = false;

                        disableEditButtons("buscar");
                        cANCELARToolStripMenuItem.Enabled = true;

                        btnPrimeiro.Enabled = false;
                        btnProximo.Enabled = false;
                        btnPosterior.Enabled = false;
                        btnUltimo.Enabled = false;
                        break;
                    case false:
                        int tbId = int.Parse(txtBoxID.Text);
                        int findPosition = tb_burriceartificialBindingSource.Find("pk_burriceartificial", tbId);

                        tb_burriceartificialBindingSource.Position = findPosition;

                        disableInputs();

                        txtBoxID.Enabled = false;
                        txtBoxID.ReadOnly = true;

                        cANCELARToolStripMenuItem.Enabled = false;

                        btnPrimeiro.Enabled = true;
                        btnProximo.Enabled = true;
                        btnPosterior.Enabled = true;
                        btnUltimo.Enabled = true;

                        imageLoad(txtBoxID.Text);
                        break;
                }
            }
            catch (Exception error)
            {
               // MessageBox.Show(error.Message);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxIALogo_Click(object sender, EventArgs e)
        {
            
        }

        private void MENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMenu formsSIM = new frmMenu();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void BURRICEARTIFICIALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este é o Forms atual, bobinho! ( ^ - ^ )");
        }

        private void FORNECEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCategoria formsSIM = new frmCategoria();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void FABRICANTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmFabricante formsSIM = new frmFabricante();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void CADASTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                enableInputs();
                clearForms();
                disableEditButtons("cadastrar");
                saveOrEdit = false;
                tb_burriceartificialBindingSource.AddNew();

                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Downloads\\Projeto IA\\Burrice Artificial\\Burrice Artificial\\bdzumbumbaboonbagosmalevolentesbehavior.mdf;Connect Timeout = 30");
                conn.Open();
                string queryMax = "SELECT MAX(pk_burriceartificial) FROM tb_burriceartificial";
                string queryCount = "SELECT COUNT(*) FROM tb_burriceartificial";

                using (SqlCommand command = new SqlCommand(queryCount, conn))
                {
                    int recordCount = (int)command.ExecuteScalar();

                    if (recordCount >= 0)
                    {
                        using (SqlCommand commando = new SqlCommand(queryMax, conn))
                        {
                            object result = commando.ExecuteScalar();
                            if (result != DBNull.Value)
                            {
                                int lastId = Convert.ToInt32(result) + 1;
                                txtBoxID.Text = $"{lastId}";
                            }
                            else
                            {
                                MessageBox.Show("A tabela está vazia.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        };
                    }
                    else
                    {
                        int idPog = int.Parse(txtBoxID.Text);
                        if (idPog < 0)
                        {
                            idPog = idPog * (-1);
                        }
                        txtBoxID.Text = $"{idPog}";
                    }
                }

                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Deu erro: {error.Message}");
            }
        }

        private void SALVARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Downloads\\Projeto IA\\Burrice Artificial\\Burrice Artificial\\bdzumbumbaboonbagosmalevolentesbehavior.mdf;Connect Timeout = 30");
                conn.Open();

                string name = txtBoxNm.Text;
                string releaseDate = maskedTxtBoxLanc.Text;
                string viktor = txtBoxFabricante.Text;
                string category = txtBoxCategoria.Text;
                string tbId = txtBoxID.Text;

                byte[] image = transfigurasaoInerte(picture); // PROBLEMA É A IMAGEM INDO PRO BD AAAAAAAAAAAH


                switch (saveOrEdit)
                {
                    case false: // salvar

                        string cmdSave = "INSERT INTO tb_burriceartificial (nome, ano_lanc, logo, fk_fabricante, fk_categoria) VALUES (@nome, @ano, @logo, @fabricante, @categoria)";

                        // SqlCommand Command = new SqlCommand(cmdSave, conn)
                        using (conn) {
                            SqlCommand cmd = new SqlCommand(cmdSave, conn);

                            cmd.Parameters.AddWithValue("@nome", name);
                            cmd.Parameters.AddWithValue("@ano", releaseDate);
                            cmd.Parameters.AddWithValue("@logo", image);
                            cmd.Parameters.AddWithValue("@fabricante", viktor);
                            cmd.Parameters.AddWithValue("@categoria", category);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("salvou");
                        break;
                    case true: // editar

                        string cmdEdit = "UPDATE tb_burriceartificial SET nome = @nome, ano_lanc = @ano, logo = @logo, fk_fabricante = @fabricante, fk_categoria = @categoria WHERE pk_burriceartificial = @id";

                        // SqlCommand Command = new SqlCommand(cmdSave, conn)
                        using (conn)
                        {
                            SqlCommand cmd = new SqlCommand(cmdEdit, conn);

                            cmd.Parameters.AddWithValue("@nome", name);
                            cmd.Parameters.AddWithValue("@ano", releaseDate);
                            cmd.Parameters.AddWithValue("@logo", image);
                            cmd.Parameters.AddWithValue("@fabricante", viktor);
                            cmd.Parameters.AddWithValue("@categoria", category);
                            cmd.Parameters.AddWithValue("@id", tbId);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("editou");
                        break;
                }

                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Deu erro: {error.Message}");
            }
            finally
            {
                disableInputs();
            }
        }

        private void DELETARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Downloads\\Projeto IA\\Burrice Artificial\\Burrice Artificial\\bdzumbumbaboonbagosmalevolentesbehavior.mdf;Connect Timeout = 30");
            conn.Open();

            string cmdEdit = "DELETE FROM tb_burriceartificial WHERE pk_burriceartificial = '" + txtBoxID.Text + "'";

            using (SqlCommand Command = new SqlCommand(cmdEdit, conn)) { Command.ExecuteNonQuery(); }

            MessageBox.Show("deletou");

            disableInputs();
            clearForms();
        }

        private void EDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveOrEdit = true;
            enableInputs();
            disableEditButtons("editar");
            imageLoad(txtBoxID.Text);
        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            tb_burriceartificialBindingSource.MoveFirst();
            imageLoad(txtBoxID.Text);
        }

        private void BtnPosterior_Click(object sender, EventArgs e)
        {
            tb_burriceartificialBindingSource.MovePrevious();
            imageLoad(txtBoxID.Text);
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            tb_burriceartificialBindingSource.MoveNext();
            imageLoad(txtBoxID.Text);
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            tb_burriceartificialBindingSource.MoveLast();
            imageLoad(txtBoxID.Text);
        }

        private void TESTECONEXÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmConecTest formsSIM = new frmConecTest();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void FrmBurriceArtificial_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetzumbumbaboonbagosmalevolentesbehavior.tb_burriceartificial'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_burriceartificialTableAdapter.Fill(this.dataSetzumbumbaboonbagosmalevolentesbehavior.tb_burriceartificial);

        }

        private byte[] transfigurasaoInerte(Image picture) // faso a menor ideia doq esta acontecendo aqui :ppp
        {
            using (MemoryStream ms = new MemoryStream())
            {
                picture.Save(ms, picture.RawFormat);
                return ms.ToArray();
            }
        }

        private void BtnSelecionarImagem_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.picture = Image.FromFile(ofd.FileName);
                this.pictureBoxIALogo.Image = picture;
            }
        }

        private void RETORNARStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMenu formsSIM = new frmMenu();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void LIMPARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearForms();
        }

        private void BtnCategoriaVisualizar_Click(object sender, EventArgs e)
        {
            frmCategoriaView formsSIM = new frmCategoriaView();
            formsSIM.ShowDialog();
        }

        private void BtnFabricanteVisualizar_Click(object sender, EventArgs e)
        {
            frmFabricanteView formsSIM = new frmFabricanteView();
            formsSIM.ShowDialog();
        }

        private void TxtBoxFabricante_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
