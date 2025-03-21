namespace Demo123
{
    partial class frmAjoutCommande
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
            this.lblNomClub = new System.Windows.Forms.Label();
            this.lblTaille = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txtNomClub = new System.Windows.Forms.TextBox();
            this.txtTaille = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnMettreAJour = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomClub
            // 
            this.lblNomClub.AutoSize = true;
            this.lblNomClub.Location = new System.Drawing.Point(103, 64);
            this.lblNomClub.Name = "lblNomClub";
            this.lblNomClub.Size = new System.Drawing.Size(73, 20);
            this.lblNomClub.TabIndex = 0;
            this.lblNomClub.Text = "nom club";
            // 
            // lblTaille
            // 
            this.lblTaille.AutoSize = true;
            this.lblTaille.Location = new System.Drawing.Point(107, 135);
            this.lblTaille.Name = "lblTaille";
            this.lblTaille.Size = new System.Drawing.Size(41, 20);
            this.lblTaille.TabIndex = 2;
            this.lblTaille.Text = "taille";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(107, 210);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(33, 20);
            this.lblPrix.TabIndex = 4;
            this.lblPrix.Text = "prix";
            // 
            // txtNomClub
            // 
            this.txtNomClub.Location = new System.Drawing.Point(271, 57);
            this.txtNomClub.Name = "txtNomClub";
            this.txtNomClub.Size = new System.Drawing.Size(100, 26);
            this.txtNomClub.TabIndex = 1;
            // 
            // txtTaille
            // 
            this.txtTaille.Location = new System.Drawing.Point(271, 135);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(100, 26);
            this.txtTaille.TabIndex = 3;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(271, 204);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(100, 26);
            this.txtPrix.TabIndex = 5;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(541, 64);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(152, 41);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnMettreAJour
            // 
            this.btnMettreAJour.Location = new System.Drawing.Point(541, 135);
            this.btnMettreAJour.Name = "btnMettreAJour";
            this.btnMettreAJour.Size = new System.Drawing.Size(152, 34);
            this.btnMettreAJour.TabIndex = 7;
            this.btnMettreAJour.Text = "Mettre à jour";
            this.btnMettreAJour.UseVisualStyleBackColor = true;
            this.btnMettreAJour.Click += new System.EventHandler(this.btnMettreAJour_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(541, 210);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(152, 33);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // frmAjoutCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnMettreAJour);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtTaille);
            this.Controls.Add(this.txtNomClub);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblTaille);
            this.Controls.Add(this.lblNomClub);
            this.Name = "frmAjoutCommande";
            this.Text = "frmAjoutCommande";
            this.Load += new System.EventHandler(this.frmAjoutCommande_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomClub;
        private System.Windows.Forms.Label lblTaille;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txtNomClub;
        private System.Windows.Forms.TextBox txtTaille;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnMettreAJour;
        private System.Windows.Forms.Button btnSupprimer;
    }
}