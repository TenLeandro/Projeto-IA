using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burrice_Artificial
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void BtnBurriceArtificial_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmBurriceArtificial formsSIM = new frmBurriceArtificial();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void BtnConecTest_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmConecTest formsSIM = new frmConecTest();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void BtnFornecedor_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCategoria formsSIM = new frmCategoria();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void BtnFabricante_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmFabricante formsSIM = new frmFabricante();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
