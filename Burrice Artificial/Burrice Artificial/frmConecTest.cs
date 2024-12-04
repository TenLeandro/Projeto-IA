using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.Remoting.Contexts;
using System.Xml.Linq;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burrice_Artificial
{
    public partial class frmConecTest : Form
    {
        string strconn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Downloads\\Projeto IA\\Burrice Artificial\\Burrice Artificial\\bdzumbumbaboonbagosmalevolentesbehavior.mdf;Connect Timeout = 30";
        public frmConecTest()
        {
            InitializeComponent();
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
            this.Visible = false;
            frmBurriceArtificial formsSIM = new frmBurriceArtificial();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void CATEGORIAToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void TESTECONEXÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este é o Forms atual, bobinho! ( ^ - ^ )");
        }

        private void CADASTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SALVARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DELETARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CANCELARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnBurriceArtificial_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM tb_burriceartificial;", conn);
            try
            {
                conn.Open(); // abre a conexão com o banco 

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(); // da, adapta o banco de dados ao nosso projeto

                DataSet ds = new DataSet();

                da.SelectCommand = cmd; // adapta cmd ao projeto 

                da.Fill(ds); // preenche todas as informações dentro do 


                dataGridViewIA.DataSource = ds; //Datagridview recebe ds 

                dataGridViewIA.DataMember = ds.Tables[0].TableName;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Não foi possível conectar: {error.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM tb_categoria;", conn);
            try
            {
                conn.Open(); // abre a conexão com o banco 

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(); // da, adapta o banco de dados ao nosso projeto

                DataSet ds = new DataSet();

                da.SelectCommand = cmd; // adapta cmd ao projeto 

                da.Fill(ds); // preenche todas as informações dentro do 


                dataGridViewIA.DataSource = ds; //Datagridview recebe ds 

                dataGridViewIA.DataMember = ds.Tables[0].TableName;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Não foi possível conectar: {error.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void BtnFabricante_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM tb_fabricante;", conn);
            try
            {
                conn.Open(); // abre a conexão com o banco 

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(); // da, adapta o banco de dados ao nosso projeto

                DataSet ds = new DataSet();

                da.SelectCommand = cmd; // adapta cmd ao projeto 

                da.Fill(ds); // preenche todas as informações dentro do 


                dataGridViewIA.DataSource = ds; //Datagridview recebe ds 

                dataGridViewIA.DataMember = ds.Tables[0].TableName;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Não foi possível conectar: {error.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void NAVEGAÇÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmConecTest_Load(object sender, EventArgs e)
        {

        }

        private void RETORNARStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMenu formsSIM = new frmMenu();
            formsSIM.ShowDialog();
            this.Visible = false;
        }
    }
}
