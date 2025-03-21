namespace Demo123
{
    partial class frmAjoutEmploye
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblLocalite = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtLocalite = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.btvAjouter = new System.Windows.Forms.Button();
            this.btnMettreAJour = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(81, 59);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "id";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(81, 104);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(63, 20);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "prénom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(82, 148);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(40, 20);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "nom";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(82, 201);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 20);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "date";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(81, 254);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(66, 20);
            this.lblAdresse.TabIndex = 8;
            this.lblAdresse.Text = "adresse";
            // 
            // lblLocalite
            // 
            this.lblLocalite.AutoSize = true;
            this.lblLocalite.Location = new System.Drawing.Point(82, 311);
            this.lblLocalite.Name = "lblLocalite";
            this.lblLocalite.Size = new System.Drawing.Size(58, 20);
            this.lblLocalite.TabIndex = 10;
            this.lblLocalite.Text = "localite";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(81, 358);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(105, 20);
            this.lblMdp.TabIndex = 12;
            this.lblMdp.Text = "mot de passe";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(81, 406);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(35, 20);
            this.lblRole.TabIndex = 14;
            this.lblRole.Text = "rôle";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(327, 56);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(327, 101);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 26);
            this.txtPrenom.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(328, 148);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 26);
            this.txtNom.TabIndex = 5;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(328, 201);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 26);
            this.txtDate.TabIndex = 7;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(327, 254);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(100, 26);
            this.txtAdresse.TabIndex = 9;
            // 
            // txtLocalite
            // 
            this.txtLocalite.Location = new System.Drawing.Point(327, 308);
            this.txtLocalite.Name = "txtLocalite";
            this.txtLocalite.Size = new System.Drawing.Size(100, 26);
            this.txtLocalite.TabIndex = 11;
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(327, 355);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(100, 26);
            this.txtMdp.TabIndex = 13;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(328, 403);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(100, 26);
            this.txtRole.TabIndex = 15;
            // 
            // btvAjouter
            // 
            this.btvAjouter.Location = new System.Drawing.Point(599, 148);
            this.btvAjouter.Name = "btvAjouter";
            this.btvAjouter.Size = new System.Drawing.Size(95, 38);
            this.btvAjouter.TabIndex = 16;
            this.btvAjouter.Text = "&Ajouter";
            this.btvAjouter.UseVisualStyleBackColor = true;
            this.btvAjouter.Click += new System.EventHandler(this.btvValider_Click);
            // 
            // btnMettreAJour
            // 
            this.btnMettreAJour.Location = new System.Drawing.Point(578, 217);
            this.btnMettreAJour.Name = "btnMettreAJour";
            this.btnMettreAJour.Size = new System.Drawing.Size(139, 44);
            this.btnMettreAJour.TabIndex = 17;
            this.btnMettreAJour.Text = "&Mettre à jour";
            this.btnMettreAJour.UseVisualStyleBackColor = true;
            this.btnMettreAJour.Click += new System.EventHandler(this.btnMettreAJour_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Location = new System.Drawing.Point(599, 299);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(97, 35);
            this.BtnSupprimer.TabIndex = 18;
            this.BtnSupprimer.Text = "&Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // frmAjoutEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.btnMettreAJour);
            this.Controls.Add(this.btvAjouter);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtLocalite);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblLocalite);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblId);
            this.Name = "frmAjoutEmploye";
            this.Text = "frmAjoutEmploye";
            this.Load += new System.EventHandler(this.frmAjoutEmploye_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblLocalite;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtLocalite;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Button btvAjouter;
        private System.Windows.Forms.Button btnMettreAJour;
        private System.Windows.Forms.Button BtnSupprimer;
    }
}