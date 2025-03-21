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
    public partial class frmAjoutEmploye : Form
    {
        public frmAjoutEmploye(Boolean modif =false)
        {
            InitializeComponent();
            
            BtnSupprimer.Visible = !modif;
            btnMettreAJour.Visible = !modif;
            btvAjouter.Visible = modif;
        }

        private void btvValider_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAjoutEmploye_Load(object sender, EventArgs e)
        {

        }

        private void btnMettreAJour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
