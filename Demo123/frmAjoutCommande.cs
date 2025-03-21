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
    public partial class frmAjoutCommande : Form
    {
        public frmAjoutCommande(Boolean modif = false)
        {
            InitializeComponent();
            btnSupprimer.Visible = !modif;
            btnMettreAJour.Visible = !modif;
            btnAjouter.Visible = modif;
        }

        private void frmAjoutCommande_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMettreAJour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
