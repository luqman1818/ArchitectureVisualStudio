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
    public partial class FrmCommande : Form
    {
        public FrmCommande()
        {
            InitializeComponent();
        }

        private void dgvCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (frmAjoutCommande frmAjoutCommande = new frmAjoutCommande())
                {
                    frmAjoutCommande.ShowDialog();
                }
            }
        }

        private void FrmCommande_Load(object sender, EventArgs e)
        {
            dgvCommande.Rows.Add("1","1" ,"Chelsea", "S", "80");
            dgvCommande.Rows.Add("2", "2", "Ac Milan", "S", "90");
            dgvCommande.Rows.Add("3", "3", "Real Madrid", "L", "80");
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmAjoutCommande frmAjoutCommande   = new frmAjoutCommande(true);
            frmAjoutCommande.Show();
        }
    }
}
