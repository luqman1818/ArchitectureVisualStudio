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
    public partial class frmEmploye : Form
    {
        public frmEmploye()
        {
            InitializeComponent();
        }

        private void frmEmploye_Load(object sender, EventArgs e)
        {
            dgvEmploye.Rows.Add("1", "marc", "Hugo", "12/12/2023", "Rue son 13", "Meyrin", "1234","vendeur");
            dgvEmploye.Rows.Add("2", "seb", "Dupont", "12/12/2020", "Rue dole 12", "Vernier", "1235", "vendeur");
            dgvEmploye.Rows.Add("3", "Luca", "Hugo", "12/02/2021", "Rue poli 11", "onex", "1236", "développer");
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmAjoutEmploye frmAjoutEmploye = new frmAjoutEmploye();
            frmAjoutEmploye.Show();
        }
    }
}
