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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjoutMaillot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nom,
            this.prix,
            this.taille});
            this.dataGridView1.Location = new System.Drawing.Point(12, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(764, 150);
            this.dataGridView1.TabIndex = 0;
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
            // prix
            // 
            this.prix.HeaderText = "prix";
            this.prix.MinimumWidth = 8;
            this.prix.Name = "prix";
            this.prix.Width = 150;
            // 
            // taille
            // 
            this.taille.HeaderText = "taille";
            this.taille.MinimumWidth = 8;
            this.taille.Name = "taille";
            this.taille.Width = 150;
            // 
            // btnAjoutMaillot
            // 
            this.btnAjoutMaillot.Location = new System.Drawing.Point(426, 401);
            this.btnAjoutMaillot.Name = "btnAjoutMaillot";
            this.btnAjoutMaillot.Size = new System.Drawing.Size(153, 40);
            this.btnAjoutMaillot.TabIndex = 1;
            this.btnAjoutMaillot.Text = "ajouter des maillots";
            this.btnAjoutMaillot.UseVisualStyleBackColor = true;
            // 
            // frmMaillot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 520);
            this.Controls.Add(this.btnAjoutMaillot);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMaillot";
            this.Text = "Maillot";
            this.Load += new System.EventHandler(this.frmMaillot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn taille;
        private System.Windows.Forms.Button btnAjoutMaillot;
    }
}