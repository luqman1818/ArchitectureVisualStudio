//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Demo123
{
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();

        }

        private  void btnConnexion_Click(object sender, EventArgs e)
        {
            //frmApp f=new frmApp();
            //f.Show();

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://luqfoot.test/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var payload = new
            {
                email_use = txtNom.Text,
                mdp_use = txtMdp.Text
            };

            string json = JsonConvert.SerializeObject(payload);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PostAsync("login", content).Result;

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                MessageBox.Show("Réponse brute : " + result);
                var res = JsonConvert.DeserializeObject<AccessToken>(result);
                Storage.setToken(res.token);
                MessageBox.Show("Token reçu : " + res.token);
                this.Close();
            }
            else
            {
                //lblError.Text = "Erreur de connexion";
                var errorContent = response.Content.ReadAsStringAsync().Result;
                MessageBox.Show("Erreur de connexion : " + errorContent);
            }

            //string email = txtNom.Text.Trim();
            //string password = txtMdp.Text.Trim();

            //if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            //{
            //    MessageBox.Show("Veuillez entrer un email et un mot de passe.");
            //    return;
            //}

            //try
            //{
            //    var client = new HttpClient();
            //    client.BaseAddress = new Uri("http://luqfoot.test/api/");
            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //    var payload = new
            //    {
            //        email_use = email,
            //        mdp_use = password
            //    };

            //    string json = JsonConvert.SerializeObject(payload);
            //    var content = new StringContent(json, Encoding.UTF8, "application/json");

            //    var response = await client.PostAsync("login", content);
            //    var responseBody = await response.Content.ReadAsStringAsync();



            //    if (response.IsSuccessStatusCode)
            //    {
            //        var res = JsonConvert.DeserializeObject<AccessToken>(responseBody);
            //        if (res?.token == null)
            //        {
            //            MessageBox.Show("Connexion échouée : le token est manquant.");
            //            return;
            //        }

            //        Storage.setToken(res.token);

            //        // Ouvre frmApp
            //        frmApp f = new frmApp();
            //        f.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        // Affiche le message d'erreur retourné par l'API
            //        MessageBox.Show("Erreur : " + responseBody);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Une erreur est survenue : " + ex.Message);
            //}


        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {

        }
    }
}
