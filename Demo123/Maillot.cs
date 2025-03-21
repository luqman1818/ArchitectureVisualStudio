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
    public partial class frmMaillot : Form
    {
        public frmMaillot()
        {
            InitializeComponent();
        }

        private void frmMaillot_Load(object sender, EventArgs e)
        {
            dgvMaillot.Rows.Add("1", "Chelsea", "S", "80");
            dgvMaillot.Rows.Add("2", "Ac Milan", "S", "90");
            dgvMaillot.Rows.Add("3", "Real Madrid", "L", "80");

            }

        private void btnAjoutMaillot_Click(object sender, EventArgs e)
        {
            frmAjoutMaillot frm = new frmAjoutMaillot(true);
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                using(frmAjoutMaillot frmAjoutMaillot = new frmAjoutMaillot())
                {
                    frmAjoutMaillot.ShowDialog();
                }
            }
        }
    }
}
