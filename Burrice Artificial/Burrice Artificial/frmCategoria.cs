﻿using System.Data.SqlClient;
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
    public partial class frmCategoria : Form
    {
        public bool saveOrEdit = false;
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void enableInputs()
        {
            txtBoxNm.Enabled = true;
            comboBoxProfissao.Enabled = true;
            txtBoxID.Enabled = true;

            btnBuscar.Enabled = false;

            sALVARToolStripMenuItem.Enabled = true;
            cANCELARToolStripMenuItem.Enabled = true;
            lIMPARToolStripMenuItem.Enabled = true;
        }
        private void disableInputs()
        {
            txtBoxNm.Enabled = false;
            comboBoxProfissao.Enabled = false;
            txtBoxID.Enabled = false;

            btnBuscar.Enabled = true;

            sALVARToolStripMenuItem.Enabled = false;
            cANCELARToolStripMenuItem.Enabled = false;
            lIMPARToolStripMenuItem.Enabled = false;

            cADASTRARToolStripMenuItem.Enabled = true;
            dELETARToolStripMenuItem.Enabled = true;
            eDITARToolStripMenuItem.Enabled = true;
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
            comboBoxProfissao.SelectedIndex = -1;
            txtBoxID.Text = "";
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

        private void FORNECEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este é o Forms atual, bobinho! ( ^ - ^ )");
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
                tb_categoriaBindingSource.AddNew();

                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Downloads\\Projeto IA\\Burrice Artificial\\Burrice Artificial\\bdzumbumbaboonbagosmalevolentesbehavior.mdf;Connect Timeout = 30");
                conn.Open();
                string queryMax = "SELECT MAX(pk_categoria) FROM tb_categoria";
                string queryCount = "SELECT COUNT(*) FROM tb_categoria";

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

                switch (saveOrEdit)
                {
                    case false: // salvar
                        string cmdSave = "INSERT INTO tb_categoria (nome, profissao) VALUES ('" + txtBoxNm.Text + "', '" + comboBoxProfissao.SelectedItem.ToString() + "')";

                        using (SqlCommand Command = new SqlCommand(cmdSave, conn)) { Command.ExecuteNonQuery(); }                        

                        MessageBox.Show("salvou");
                        break;
                    case true: // editar
                        string cmdEdit = "UPDATE tb_categoria SET nome = '" + txtBoxNm.Text + "', profissao = '" + comboBoxProfissao.SelectedItem.ToString() + "' WHERE pk_categoria = '" + txtBoxID.Text + "'";

                        using (SqlCommand Command = new SqlCommand(cmdEdit, conn)) { Command.ExecuteNonQuery(); }

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

            string cmdEdit = "DELETE FROM tb_categoria WHERE pk_categoria = '" + txtBoxID.Text + "'";

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
        }

        private void RETORNARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disableInputs();
            txtBoxID.Enabled = false;
            txtBoxID.ReadOnly = true;

            tb_categoriaBindingSource.CancelEdit();
        }
        public bool searchButton = false;

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
                        int findPosition = tb_categoriaBindingSource.Find("pk_categoria", tbId);

                        tb_categoriaBindingSource.Position = findPosition;

                        disableInputs();

                        txtBoxID.Enabled = false;
                        txtBoxID.ReadOnly = true;

                        cANCELARToolStripMenuItem.Enabled = false;

                        btnPrimeiro.Enabled = true;
                        btnProximo.Enabled = true;
                        btnPosterior.Enabled = true;
                        btnUltimo.Enabled = true;
                        break;
                }
            }
            catch (Exception error)
            {
                // MessageBox.Show(error.Message);
            }
        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            tb_categoriaBindingSource.MoveFirst();
        }

        private void BtnPosterior_Click(object sender, EventArgs e)
        {
            tb_categoriaBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            tb_categoriaBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            tb_categoriaBindingSource.MoveLast();
        }

        private void TESTECONEXÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmConecTest formsSIM = new frmConecTest();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetzumbumbaboonbagosmalevolentesbehavior1.tb_categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_categoriaTableAdapter.Fill(this.dataSetzumbumbaboonbagosmalevolentesbehavior.tb_categoria);
        }

        private void TxtBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxNm_TextChanged(object sender, EventArgs e)
        {

        }

        private void LImparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearForms();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void RETORNARStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMenu formsSIM = new frmMenu();
            formsSIM.ShowDialog();
            this.Visible = false;
        }
    }
}
