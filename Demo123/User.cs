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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                using(frmUser frmUser = new frmUser())
                {
                    frmUser.ShowDialog();
                }
            }

        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();

            // Définir les colonnes du DataTable (TRÈS IMPORTANT !)
            //dt.Columns.Add("ID", typeof(string)); // Définir une colonne "ID" de type string
            //dt.Columns.Add("Nom", typeof(string)); // Définir une colonne "Nom" de type string
            //dt.Columns.Add("Prénom", typeof(string)); // Définir une colonne "Prénom" de type string
            //dt.Columns.Add("Date", typeof(string)); // Définir une colonne "Date" de type string
            //dt.Columns.Add("Adresse", typeof(string)); // Définir une colonne "Adresse" de type string
            //dt.Columns.Add("Ville", typeof(string)); // Définir une colonne "Ville" de type string
            //dt.Columns.Add("Code Postal", typeof(string)); // Définir une colonne "Code Postal" de type string


            // Ajouter une ligne de données
            dgvUser.Rows.Add("1", "Marc", "Dupont", "12/12/2023", "Rue sonnex 13", "Grand-Saconnex", "1234");
            dgvUser.Rows.Add("2", "Paul", "Dupont", "12/12/2020", "Rue sonnex 12", "Grand-Saconnex", "1235");
            dgvUser.Rows.Add("3", "Luca", "Dupont", "12/02/2021", "Rue sonnex 11", "Grand-Saconnex", "1236");

            // Définir le DataSource du DataGridView
            //dgvUser.DataSource = dt;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAjoutUser f=new frmAjoutUser();
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmModifUser f=new frmModifUser();
            f.Show();
        }

        private void dgvUser_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dgvUser_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                using( frmModifUser f=new frmModifUser())
                {
                    f.ShowDialog();
                }
            }
        }
    }
}
