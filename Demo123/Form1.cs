using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo123
{
    public partial class frmApp : Form
    {
        public frmApp()
        {
            InitializeComponent();
        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConnexion connectionForm = new FrmConnexion();
            connectionForm.Show();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser f = new frmUser();
            f.MdiParent = this;
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gestionMaillotToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmMaillot m = new frmMaillot();
           m.MdiParent = this;
           m.Show();
        }

        private void frmApp_Load(object sender, EventArgs e)
        {
            FrmConnexion f = new FrmConnexion();
            f.ShowDialog();

            if(Storage.getToken() == "")
            {
                this.Close();

            }

        }

        private void gestionCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCommande f= new FrmCommande();
            f.Show();
        }

        private void gestionEmployéToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmEmploye frm  = new frmEmploye();
            frm.Show();
        }
    }
}
