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
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Demo123
{
    public partial class frmAjoutMaillot : Form
    {
        public frmAjoutMaillot(Boolean modif = false)
        {
            InitializeComponent();
            //btnMettreAJour.Visible = !modif;
            //btnSupprimer.Visible = !modif;
            //btnAjouter.Visible = modif;



        }

        private async Task AjouterShirtAsync()
        {
            try
            {
                // Vérifier que tous les champs sont remplis
                if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                    string.IsNullOrWhiteSpace(txtTaille.Text) ||
                    string.IsNullOrWhiteSpace(txtPrix.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs.");
                    return;
                }

                // Vérifier que le prix est un nombre valide
                if (!float.TryParse(txtPrix.Text, out float prix))
                {
                    MessageBox.Show("Le prix est invalide.");
                    return;
                }

                // Créer l'objet Shirt
                var shirt = new Shirt
                {
                    nom_shi = txtNom.Text,
                    taille_shi = txtTaille.Text,
                    prix_shi = prix
                };

                // Récupérer le token
                var token = Storage.getToken();
                if (string.IsNullOrEmpty(token))
                {
                    MessageBox.Show("Token introuvable.");
                    return;
                }

                // Préparer la requête POST
                var json = JsonConvert.SerializeObject(shirt);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://luqfoot.test/api/");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var response = await client.PostAsync("shirts", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Shirt ajouté avec succès !");
                        this.Close(); // Fermer le formulaire après ajout
                    }
                    else
                    {
                        var error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Erreur : " + error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur inattendue : " + ex.Message);
            }
        }

        private async Task UpdateShirtAsync()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text) ||
                    string.IsNullOrWhiteSpace(txtNom.Text) ||
                    string.IsNullOrWhiteSpace(txtTaille.Text) ||
                    string.IsNullOrWhiteSpace(txtPrix.Text))
                {
                    MessageBox.Show("Tous les champs doivent être remplis.");
                    return;
                }

                if (!int.TryParse(txtId.Text, out int id))
                {
                    MessageBox.Show("ID invalide.");
                    return;
                }

                if (!float.TryParse(txtPrix.Text, out float prix))
                {
                    MessageBox.Show("Prix invalide.");
                    return;
                }

                var shirt = new Shirt
                {
                    id_shi = id,
                    nom_shi = txtNom.Text,
                    taille_shi = txtTaille.Text,
                    prix_shi = prix
                };

                var token = Storage.getToken();
                if (string.IsNullOrEmpty(token))
                {
                    MessageBox.Show("Token introuvable.");
                    return;
                }

                var json = JsonConvert.SerializeObject(shirt);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://luqfoot.test/api/");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var response = await client.PutAsync($"shirts/{id}", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Shirt mis à jour avec succès !");
                        this.Close(); // Fermer le formulaire
                    }
                    else
                    {
                        var error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Erreur : " + error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur inattendue : " + ex.Message);
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAjoutMaillot_Load(object sender, EventArgs e)
        {

        }

        private async void btnValider_Click(object sender, EventArgs e)
        {
            //this.Close();
            await AjouterShirtAsync();
        }

        private async void btnMettreAJour_Click(object sender, EventArgs e)
        {
            //this.Close();
            await UpdateShirtAsync();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
