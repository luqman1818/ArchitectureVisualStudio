namespace Demo123
{
    partial class FrmCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCommande = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_personne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCommande
            // 
            this.dgvCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_personne,
            this.nom,
            this.taille,
            this.prix});
            this.dgvCommande.Location = new System.Drawing.Point(64, 48);
            this.dgvCommande.Name = "dgvCommande";
            this.dgvCommande.RowHeadersWidth = 62;
            this.dgvCommande.RowTemplate.Height = 28;
            this.dgvCommande.Size = new System.Drawing.Size(978, 172);
            this.dgvCommande.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "n°";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 150;
            // 
            // id_personne
            // 
            this.id_personne.HeaderText = "n° personne";
            this.id_personne.MinimumWidth = 8;
            this.id_personne.Name = "id_personne";
            this.id_personne.Width = 150;
            // 
            // nom
            // 
            this.nom.HeaderText = "nom club";
            this.nom.MinimumWidth = 8;
            this.nom.Name = "nom";
            this.nom.Width = 150;
            // 
            // taille
            // 
            this.taille.HeaderText = "taille";
            this.taille.MinimumWidth = 8;
            this.taille.Name = "taille";
            this.taille.Width = 150;
            // 
            // prix
            // 
            this.prix.HeaderText = "prix";
            this.prix.MinimumWidth = 8;
            this.prix.Name = "prix";
            this.prix.Width = 150;
            // 
            // FrmCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 450);
            this.Controls.Add(this.dgvCommande);
            this.Name = "FrmCommande";
            this.Text = "FrmCommande";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_personne;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn taille;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
    }
}