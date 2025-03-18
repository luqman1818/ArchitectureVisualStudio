namespace Demo123
{
    partial class frmUser
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
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnModifUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.prenom,
            this.nom,
            this.date,
            this.adresse,
            this.localite,
            this.mdp});
            this.dgvUser.Location = new System.Drawing.Point(23, 58);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 62;
            this.dgvUser.RowTemplate.Height = 28;
            this.dgvUser.Size = new System.Drawing.Size(1106, 150);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick_1);
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
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(821, 351);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(97, 59);
            this.btnAjout.TabIndex = 1;
            this.btnAjout.Text = "ajouter utilisateur";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModifUser
            // 
            this.btnModifUser.Location = new System.Drawing.Point(568, 360);
            this.btnModifUser.Name = "btnModifUser";
            this.btnModifUser.Size = new System.Drawing.Size(135, 50);
            this.btnModifUser.TabIndex = 2;
            this.btnModifUser.Text = "modifier utilisateur";
            this.btnModifUser.UseVisualStyleBackColor = true;
            this.btnModifUser.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 526);
            this.Controls.Add(this.btnModifUser);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.dgvUser);
            this.Name = "frmUser";
            this.Text = "User";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn localite;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdp;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnModifUser;
    }
}