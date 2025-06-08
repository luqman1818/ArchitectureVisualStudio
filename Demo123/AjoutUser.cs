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
    public partial class frmAjoutUser : Form
    {
        private User _user;
        public frmAjoutUser(Boolean modif = false)
        {
            InitializeComponent();
            //btnMettreAjour.Visible = !modif;
            //btnSupprimer.Visible = !modif;
            //btnAjouter.Visible = modif;



            dtpNaissance.Format = DateTimePickerFormat.Custom;
            dtpNaissance.CustomFormat = "dd-MM-yyyy";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnValider_Click(object sender, EventArgs e)
        {
            //this.Close();

            var user = new User
            {
                prenom_use = txtPrenom.Text,
                nom_use = txtNom.Text,
                adresse_use = txtAdresse.Text,
                email_use = txtEmail.Text,
                date_naissance_use = dtpNaissance.Value.ToString("dd-MM-yyyy"),
                mdp_use = txtMdp.Text
            };

            var token = Storage.getToken();
            if (string.IsNullOrEmpty(token))
            {
                MessageBox.Show("Token introuvable.");
                return;
            }

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://luqfoot.test/api/");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var json = JsonConvert.SerializeObject(user);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync("users", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Utilisateur ajouté !");
                        this.Close();
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Erreur : " + error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private async void btnMettreAjour_Click(object sender, EventArgs e)
        {
            //this.Close();
            await UpdateUserAsync();



        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAjoutUser_Load(object sender, EventArgs e)
        {

        }
        private async Task UpdateUserAsync()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text) ||
                    string.IsNullOrWhiteSpace(txtPrenom.Text) ||
                    string.IsNullOrWhiteSpace(txtNom.Text) ||
                    string.IsNullOrWhiteSpace(txtAdresse.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtMdp.Text))
                {
                    MessageBox.Show("Tous les champs doivent être remplis.");
                    return;
                }

                if (!int.TryParse(txtId.Text, out int id))
                {
                    MessageBox.Show("ID invalide.");
                    return;
                }

                var user = new User
                {
                    id_use = id,
                    prenom_use = txtPrenom.Text,
                    nom_use = txtNom.Text,
                    adresse_use = txtAdresse.Text,
                    email_use = txtEmail.Text,
                    date_naissance_use = dtpNaissance.Value.ToString("dd-MM-yyyy"),
                    mdp_use = txtMdp.Text
                };

                var token = Storage.getToken();
                if (string.IsNullOrEmpty(token))
                {
                    MessageBox.Show("Token introuvable.");
                    return;
                }

                var json = JsonConvert.SerializeObject(user);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://luqfoot.test/api/");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var response = await client.PutAsync($"users/{id}", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Utilisateur mis à jour avec succès !");
                        this.Close(); // Fermer le formulaire ou rafraîchir si besoin
                    }
                    else
                    {
                        var error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Erreur API : " + error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur inattendue : " + ex.Message);
            }
        }





        private void lblLocalité_Click(object sender, EventArgs e)
        {

        }
    }
}
