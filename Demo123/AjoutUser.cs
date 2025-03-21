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
    public partial class frmAjoutUser : Form
    {
        public frmAjoutUser(Boolean modif = false)
        {
            InitializeComponent();
            btnMettreAjour.Visible = !modif;
            btnSupprimer.Visible = !modif;
            btnAjouter.Visible = modif;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMettreAjour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAjoutUser_Load(object sender, EventArgs e)
        {

        }

        private void lblLocalité_Click(object sender, EventArgs e)
        {

        }
    }
}
