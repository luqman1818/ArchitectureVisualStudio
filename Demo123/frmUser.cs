using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Demo123
{
    public partial class frmUser : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public frmUser()
        {
            InitializeComponent();

            client.BaseAddress = new Uri("http://luqfoot.test/api/");
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.RowIndex >= 0)
            //{
            //    using(frmUser frmUser = new frmUser())
            //    {
            //        frmUser.ShowDialog();
            //    }
            //}

        }

        private async void frmUser_Load(object sender, EventArgs e)
        {

            //dgvUser.Rows.Add("1", "Marc", "Dupont", "12/12/2023", "Rue sonnex 13", "Grand-Saconnex", "1234");
            //dgvUser.Rows.Add("2", "Paul", "Dupont", "12/12/2020", "Rue sonnex 12", "Grand-Saconnex", "1235");
            //dgvUser.Rows.Add("3", "Luca", "Dupont", "12/02/2021", "Rue sonnex 11", "Grand-Saconnex", "1236");

            await ChargerUtilisateursAsync();

        }
        private async Task ChargerUtilisateursAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://luqfoot.test/api/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // Ajouter le token ici
                    var token = Storage.getToken();
                    if (string.IsNullOrEmpty(token))
                    {
                        MessageBox.Show("Token introuvable.");
                        return;
                    }

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    HttpResponseMessage response = await client.GetAsync("users");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var shirts = JsonConvert.DeserializeObject<List<User>>(jsonString);
                        dgvUser.DataSource = shirts;
                    }
                    else
                    {
                        var error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Erreur lors de la récupération : " + error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAjoutUser f=new frmAjoutUser(true);
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmAjoutEmploye f =new frmAjoutEmploye(true);
            f.ShowDialog();
        }

        private void dgvUser_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dgvUser_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.RowIndex >= 0)
            //{
            //    using( frmAjoutUser f=new frmAjoutUser())
            //    {
            //        f.ShowDialog();
            //    }
            //}
        }

        private async void btnMettreAJour_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à supprimer.");
                return;
            }

            var result = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Confirmation", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
                return;

            int id = Convert.ToInt32(dgvUser.SelectedRows[0].Cells["id_use"].Value);
            var token = Storage.getToken();

            if (string.IsNullOrEmpty(token))
            {
                MessageBox.Show("Token introuvable.");
                return;
            }

            btnSupprimer.Enabled = false;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://luqfoot.test/api/");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    HttpResponseMessage response = await client.DeleteAsync($"users/{id}");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Utilisateur supprimé avec succès !");
                        await ChargerUtilisateursAsync(); // Recharge la liste des utilisateurs
                    }
                    else
                    {
                        var error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Erreur lors de la suppression : " + error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                btnSupprimer.Enabled = true;
            }
        }
    }
}
