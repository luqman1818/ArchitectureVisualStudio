﻿namespace Demo123
{
    partial class frmModifUser
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
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblLocalite = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtLocalite = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(65, 69);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(63, 20);
            this.lblPrenom.TabIndex = 0;
            this.lblPrenom.Text = "prénom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(64, 109);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(40, 20);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "nom";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(64, 154);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "date";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(65, 192);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(66, 20);
            this.lblAdresse.TabIndex = 3;
            this.lblAdresse.Text = "adresse";
            // 
            // lblLocalite
            // 
            this.lblLocalite.AutoSize = true;
            this.lblLocalite.Location = new System.Drawing.Point(64, 236);
            this.lblLocalite.Name = "lblLocalite";
            this.lblLocalite.Size = new System.Drawing.Size(58, 20);
            this.lblLocalite.TabIndex = 4;
            this.lblLocalite.Text = "localité";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(64, 285);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(105, 20);
            this.lblMdp.TabIndex = 5;
            this.lblMdp.Text = "mot de passe";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(243, 63);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 26);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(243, 109);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 26);
            this.txtNom.TabIndex = 7;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(243, 154);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 26);
            this.txtDate.TabIndex = 8;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(243, 192);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(100, 26);
            this.txtAdresse.TabIndex = 9;
            // 
            // txtLocalite
            // 
            this.txtLocalite.Location = new System.Drawing.Point(243, 236);
            this.txtLocalite.Name = "txtLocalite";
            this.txtLocalite.Size = new System.Drawing.Size(100, 26);
            this.txtLocalite.TabIndex = 10;
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(243, 285);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(100, 26);
            this.txtMdp.TabIndex = 11;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(503, 330);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(109, 47);
            this.btnValider.TabIndex = 12;
            this.btnValider.Text = "valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // frmModifUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtLocalite);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblLocalite);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblPrenom);
            this.Name = "frmModifUser";
            this.Text = "ModifUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblLocalite;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtLocalite;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button btnValider;
    }
}