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
    }
}
