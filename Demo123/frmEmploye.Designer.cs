namespace Demo123
{
    partial class frmEmploye
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
            this.dgvEmploye = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploye)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmploye
            // 
            this.dgvEmploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmploye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.prenom,
            this.nom,
            this.date,
            this.adresse,
            this.localite,
            this.mdp,
            this.role});
            this.dgvEmploye.Location = new System.Drawing.Point(12, 118);
            this.dgvEmploye.Name = "dgvEmploye";
            this.dgvEmploye.RowHeadersWidth = 62;
            this.dgvEmploye.RowTemplate.Height = 28;
            this.dgvEmploye.Size = new System.Drawing.Size(1036, 150);
            this.dgvEmploye.TabIndex = 0;
            this.dgvEmploye.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmploye_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 150;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "prénom";
            this.prenom.MinimumWidth = 8;
            this.prenom.Name = "prenom";
            this.prenom.Width = 150;
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.MinimumWidth = 8;
            this.nom.Name = "nom";
            this.nom.Width = 150;
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            this.date.Width = 150;
            // 
            // adresse
            // 
            this.adresse.HeaderText = "adresse";
            this.adresse.MinimumWidth = 8;
            this.adresse.Name = "adresse";
            this.adresse.Width = 150;
            // 
            // localite
            // 
            this.localite.HeaderText = "localité";
            this.localite.MinimumWidth = 8;
            this.localite.Name = "localite";
            this.localite.Width = 150;
            // 
            // mdp
            // 
            this.mdp.HeaderText = "mot de passe";
            this.mdp.MinimumWidth = 8;
            this.mdp.Name = "mdp";
            this.mdp.Width = 150;
            // 
            // role
            // 
            this.role.HeaderText = "rôle";
            this.role.MinimumWidth = 8;
            this.role.Name = "role";
            this.role.Width = 150;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(670, 343);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(107, 48);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // frmEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvEmploye);
            this.Name = "frmEmploye";
            this.Text = "frmEmploye";
            this.Load += new System.EventHandler(this.frmEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmploye;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn localite;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdp;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.Button btnAjouter;
    }
}