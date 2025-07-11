﻿using System;
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
    public partial class frmMaillot : Form
    {
        private static readonly HttpClient client = new HttpClient();

        private List<Shirt> allShirts = new List<Shirt>();
        public frmMaillot()
        {
            InitializeComponent();
            // Configuration de base une seule fois
            client.BaseAddress = new Uri("http://luqfoot.test/api/");
        }

        private async void frmMaillot_Load(object sender, EventArgs e)
        {
            //dgvMaillot.Rows.Add("1", "Chelsea", "S", "80");
            //dgvMaillot.Rows.Add("2", "Ac Milan", "S", "90");
            //dgvMaillot.Rows.Add("3", "Real Madrid", "L", "80");

            await ChargerUtilisateursAsync();

        }

       




        private  void btnAjoutMaillot_Click(object sender, EventArgs e)
        {
            frmAjoutMaillot frm = new frmAjoutMaillot(true);
            frm.ShowDialog();
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

                    HttpResponseMessage response = await client.GetAsync("shirts");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var shirts = JsonConvert.DeserializeObject<List<Shirt>>(jsonString);

                        //dgvMaillot.AutoGenerateColumns = false;
                        dgvMaillot.DataSource = shirts;
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
            //if(e.RowIndex >= 0)
            //{
            //    using(frmAjoutMaillot frmAjoutMaillot = new frmAjoutMaillot())
            //    {
            //        frmAjoutMaillot.ShowDialog();
            //    }
            //}
        }

        private async void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            if (dgvMaillot.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un shirt à supprimer.");
                return;
            }

            var result = MessageBox.Show("Voulez-vous vraiment supprimer ce shirt ?", "Confirmation", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
                return;

            int id = Convert.ToInt32(dgvMaillot.SelectedRows[0].Cells["id"].Value);
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

                    HttpResponseMessage response = await client.DeleteAsync($"shirts/{id}");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Shirt supprimé avec succès !");
                        await ChargerUtilisateursAsync();
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

    //    private void btnFiltrer_Click(object sender, EventArgs e)
    //    {
    //        string filtre = txtFiltreNom.Text.Trim();

    //        if (string.IsNullOrEmpty(filtre))
    //        {
    //            dgvMaillot.DataSource = allShirts;
    //            return;
    //        }

    //        if (int.TryParse(filtre, out int idRecherche))
    //        {
    //            // Filtrage par ID
    //            var filtered = allShirts
    //                .Where(s => s.id_shi == idRecherche)
    //                .ToList();

    //            dgvMaillot.DataSource = filtered;

    //            if (filtered.Count == 0)
    //                MessageBox.Show("Aucun maillot trouvé avec l'ID " + idRecherche);
    //        }
    //        else
    //        {
    //            MessageBox.Show("Veuillez entrer un ID valide (nombre entier).");
    //        }
    //    }
    }
}
