namespace Demo123
{
    partial class frmAjoutMaillot
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblTaille = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtTaille = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnMettreAJour = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(86, 82);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(40, 20);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "nom";
            this.lblNom.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(86, 129);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(33, 20);
            this.lblPrix.TabIndex = 2;
            this.lblPrix.Text = "prix";
            // 
            // lblTaille
            // 
            this.lblTaille.AutoSize = true;
            this.lblTaille.Location = new System.Drawing.Point(86, 183);
            this.lblTaille.Name = "lblTaille";
            this.lblTaille.Size = new System.Drawing.Size(41, 20);
            this.lblTaille.TabIndex = 4;
            this.lblTaille.Text = "taille";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(235, 76);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 26);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(235, 129);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(100, 26);
            this.txtPrix.TabIndex = 3;
            // 
            // txtTaille
            // 
            this.txtTaille.Location = new System.Drawing.Point(235, 185);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(100, 26);
            this.txtTaille.TabIndex = 5;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(529, 90);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(121, 48);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnMettreAJour
            // 
            this.btnMettreAJour.Location = new System.Drawing.Point(529, 183);
            this.btnMettreAJour.Name = "btnMettreAJour";
            this.btnMettreAJour.Size = new System.Drawing.Size(121, 48);
            this.btnMettreAJour.TabIndex = 7;
            this.btnMettreAJour.Text = "&Mettre à jour";
            this.btnMettreAJour.UseVisualStyleBackColor = true;
            this.btnMettreAJour.Click += new System.EventHandler(this.btnMettreAJour_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(529, 278);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(121, 45);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // frmAjoutMaillot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnMettreAJour);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtTaille);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblTaille);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblNom);
            this.Name = "frmAjoutMaillot";
            this.Text = "frmAjoutMaillot";
            this.Load += new System.EventHandler(this.frmAjoutMaillot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblTaille;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.TextBox txtTaille;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnMettreAJour;
        private System.Windows.Forms.Button btnSupprimer;
    }
}