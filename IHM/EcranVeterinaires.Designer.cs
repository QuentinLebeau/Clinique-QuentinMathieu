namespace clinique
{
    partial class EcranVeterinaires
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
            this.BTN_ReinitialiserVeto = new System.Windows.Forms.Button();
            this.BTN_SupprimerVeto = new System.Windows.Forms.Button();
            this.BTN_ajouterVeto = new System.Windows.Forms.Button();
            this.DataGridVeto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVeto)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_ReinitialiserVeto
            // 
            this.BTN_ReinitialiserVeto.Location = new System.Drawing.Point(325, 11);
            this.BTN_ReinitialiserVeto.Name = "BTN_ReinitialiserVeto";
            this.BTN_ReinitialiserVeto.Size = new System.Drawing.Size(150, 23);
            this.BTN_ReinitialiserVeto.TabIndex = 2;
            this.BTN_ReinitialiserVeto.Text = "Changer de mot de passe";
            this.BTN_ReinitialiserVeto.UseVisualStyleBackColor = true;
            this.BTN_ReinitialiserVeto.Click += new System.EventHandler(this.BTN_ReinitialiserVeto_Click);
            // 
            // BTN_SupprimerVeto
            // 
            this.BTN_SupprimerVeto.Location = new System.Drawing.Point(169, 11);
            this.BTN_SupprimerVeto.Name = "BTN_SupprimerVeto";
            this.BTN_SupprimerVeto.Size = new System.Drawing.Size(150, 23);
            this.BTN_SupprimerVeto.TabIndex = 1;
            this.BTN_SupprimerVeto.Text = "Supprimer";
            this.BTN_SupprimerVeto.UseVisualStyleBackColor = true;
            this.BTN_SupprimerVeto.Click += new System.EventHandler(this.BTN_SupprimerVeto_Click);
            // 
            // BTN_ajouterVeto
            // 
            this.BTN_ajouterVeto.Location = new System.Drawing.Point(13, 11);
            this.BTN_ajouterVeto.Name = "BTN_ajouterVeto";
            this.BTN_ajouterVeto.Size = new System.Drawing.Size(150, 23);
            this.BTN_ajouterVeto.TabIndex = 0;
            this.BTN_ajouterVeto.Text = "Ajouter";
            this.BTN_ajouterVeto.UseVisualStyleBackColor = true;
            this.BTN_ajouterVeto.Click += new System.EventHandler(this.BTN_ajouterVeto_Click);
            // 
            // DataGridVeto
            // 
            this.DataGridVeto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridVeto.Location = new System.Drawing.Point(13, 40);
            this.DataGridVeto.Name = "DataGridVeto";
            this.DataGridVeto.Size = new System.Drawing.Size(461, 184);
            this.DataGridVeto.TabIndex = 1;
            this.DataGridVeto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridVeto_CellContentClick);
            // 
            // EcranVeterinaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 237);
            this.Controls.Add(this.DataGridVeto);
            this.Controls.Add(this.BTN_ReinitialiserVeto);
            this.Controls.Add(this.BTN_ajouterVeto);
            this.Controls.Add(this.BTN_SupprimerVeto);
            this.Name = "EcranVeterinaires";
            this.Text = "EcranVeterinaires";
            this.Load += new System.EventHandler(this.EcranVeterinaires_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVeto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_ReinitialiserVeto;
        private System.Windows.Forms.Button BTN_SupprimerVeto;
        private System.Windows.Forms.Button BTN_ajouterVeto;
        private System.Windows.Forms.DataGridView DataGridVeto;
    }
}