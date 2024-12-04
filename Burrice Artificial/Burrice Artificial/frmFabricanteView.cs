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
    public partial class frmFabricanteView : Form
    {
        string strconn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Downloads\\Projeto IA\\Burrice Artificial\\Burrice Artificial\\bdzumbumbaboonbagosmalevolentesbehavior.mdf;Connect Timeout = 30";
        public frmFabricanteView()
        {
            InitializeComponent();
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

        private void FrmFabricanteVisualização_Load(object sender, EventArgs e)
        {

        }

        private void RETORNARStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridViewIA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
