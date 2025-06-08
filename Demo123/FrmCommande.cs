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
    public partial class FrmCommande : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public FrmCommande()
        {
            InitializeComponent();

            client.BaseAddress = new Uri("http://luqfoot.test/api/");
        }

        private void dgvCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private async void FrmCommande_Load(object sender, EventArgs e)
        {
            //dgvCommande.Rows.Add("1","1" ,"Chelsea", "S", "80");
            //dgvCommande.Rows.Add("2", "2", "Ac Milan", "S", "90");
            //dgvCommande.Rows.Add("3", "3", "Real Madrid", "L", "80");

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

                    HttpResponseMessage response = await client.GetAsync("orders");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var shirts = JsonConvert.DeserializeObject<List<Order>>(jsonString);
                        dgvCommande.DataSource = shirts;
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmAjoutCommande frmAjoutCommande   = new frmAjoutCommande(true);
            frmAjoutCommande.ShowDialog();
        }
    }
}
