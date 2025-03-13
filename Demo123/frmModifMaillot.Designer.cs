namespace Demo123
{
    partial class frmModifMaillot
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
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(77, 94);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(40, 20);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "nom";
            this.lblNom.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(77, 151);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(33, 20);
            this.lblPrix.TabIndex = 1;
            this.lblPrix.Text = "prix";
            // 
            // lblTaille
            // 
            this.lblTaille.AutoSize = true;
            this.lblTaille.Location = new System.Drawing.Point(77, 212);
            this.lblTaille.Name = "lblTaille";
            this.lblTaille.Size = new System.Drawing.Size(41, 20);
            this.lblTaille.TabIndex = 2;
            this.lblTaille.Text = "taille";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(246, 87);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 26);
            this.txtNom.TabIndex = 3;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(246, 151);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(100, 26);
            this.txtPrix.TabIndex = 4;
            // 
            // txtTaille
            // 
            this.txtTaille.Location = new System.Drawing.Point(246, 212);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(100, 26);
            this.txtTaille.TabIndex = 5;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(491, 327);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(98, 39);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // frmModifMaillot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtTaille);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblTaille);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblNom);
            this.Name = "frmModifMaillot";
            this.Text = "frmModifMaillot";
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
        private System.Windows.Forms.Button btnValider;
    }
}