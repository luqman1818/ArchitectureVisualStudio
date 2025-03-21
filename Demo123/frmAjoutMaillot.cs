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
    public partial class frmAjoutMaillot : Form
    {
        public frmAjoutMaillot(Boolean modif = false)
        {
            InitializeComponent();
            btnMettreAJour.Visible = !modif;
            btnSupprimer.Visible = !modif;
            btnAjouter.Visible = modif;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAjoutMaillot_Load(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
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
