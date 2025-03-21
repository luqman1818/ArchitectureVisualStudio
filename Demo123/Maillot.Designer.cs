namespace Demo123
{
    partial class frmMaillot
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
            this.btnAjoutMaillot = new System.Windows.Forms.Button();
            this.dgvMaillot = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaillot)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjoutMaillot
            // 
            this.btnAjoutMaillot.Location = new System.Drawing.Point(426, 401);
            this.btnAjoutMaillot.Name = "btnAjoutMaillot";
            this.btnAjoutMaillot.Size = new System.Drawing.Size(153, 40);
            this.btnAjoutMaillot.TabIndex = 1;
            this.btnAjoutMaillot.Text = "ajouter des maillots";
            this.btnAjoutMaillot.UseVisualStyleBackColor = true;
            this.btnAjoutMaillot.Click += new System.EventHandler(this.btnAjoutMaillot_Click);
            // 
            // dgvMaillot
            // 
            this.dgvMaillot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaillot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nom,
            this.taille,
            this.prix});
            this.dgvMaillot.Location = new System.Drawing.Point(65, 132);
            this.dgvMaillot.Name = "dgvMaillot";
            this.dgvMaillot.RowHeadersWidth = 62;
            this.dgvMaillot.RowTemplate.Height = 28;
            this.dgvMaillot.Size = new System.Drawing.Size(866, 150);
            this.dgvMaillot.TabIndex = 0;
            this.dgvMaillot.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 150;
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
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
            // frmMaillot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1148, 520);
            this.Controls.Add(this.dgvMaillot);
            this.Controls.Add(this.btnAjoutMaillot);
            this.Name = "frmMaillot";
            this.Text = "Maillot";
            this.Load += new System.EventHandler(this.frmMaillot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaillot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAjoutMaillot;
        private System.Windows.Forms.DataGridView dgvMaillot;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn taille;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
    }
}