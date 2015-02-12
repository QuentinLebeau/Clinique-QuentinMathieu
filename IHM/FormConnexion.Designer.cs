namespace clinique
{
    partial class FormConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_ConnexionValider = new System.Windows.Forms.Button();
            this.LBL_ConnexionNom = new System.Windows.Forms.Label();
            this.LBL_ConnexionMdp = new System.Windows.Forms.Label();
            this.TXT_ConnxionNom = new System.Windows.Forms.TextBox();
            this.TXT_ConnexionMdp = new System.Windows.Forms.TextBox();
            this.LBL_connexion_erreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_ConnexionValider
            // 
            this.BTN_ConnexionValider.Location = new System.Drawing.Point(89, 120);
            this.BTN_ConnexionValider.Name = "BTN_ConnexionValider";
            this.BTN_ConnexionValider.Size = new System.Drawing.Size(89, 27);
            this.BTN_ConnexionValider.TabIndex = 0;
            this.BTN_ConnexionValider.Text = "Valider";
            this.BTN_ConnexionValider.UseVisualStyleBackColor = true;
            this.BTN_ConnexionValider.Click += new System.EventHandler(this.BTN_ConnexionValider_Click);
            // 
            // LBL_ConnexionNom
            // 
            this.LBL_ConnexionNom.AutoSize = true;
            this.LBL_ConnexionNom.Location = new System.Drawing.Point(23, 25);
            this.LBL_ConnexionNom.Name = "LBL_ConnexionNom";
            this.LBL_ConnexionNom.Size = new System.Drawing.Size(29, 13);
            this.LBL_ConnexionNom.TabIndex = 2;
            this.LBL_ConnexionNom.Text = "Nom";
            // 
            // LBL_ConnexionMdp
            // 
            this.LBL_ConnexionMdp.AutoSize = true;
            this.LBL_ConnexionMdp.Location = new System.Drawing.Point(23, 63);
            this.LBL_ConnexionMdp.Name = "LBL_ConnexionMdp";
            this.LBL_ConnexionMdp.Size = new System.Drawing.Size(71, 13);
            this.LBL_ConnexionMdp.TabIndex = 3;
            this.LBL_ConnexionMdp.Text = "Mot de passe";
            // 
            // TXT_ConnxionNom
            // 
            this.TXT_ConnxionNom.Location = new System.Drawing.Point(102, 22);
            this.TXT_ConnxionNom.Name = "TXT_ConnxionNom";
            this.TXT_ConnxionNom.Size = new System.Drawing.Size(134, 20);
            this.TXT_ConnxionNom.TabIndex = 4;
            this.TXT_ConnxionNom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TXT_ConnxionNom_MouseClick);
            // 
            // TXT_ConnexionMdp
            // 
            this.TXT_ConnexionMdp.Location = new System.Drawing.Point(102, 60);
            this.TXT_ConnexionMdp.Name = "TXT_ConnexionMdp";
            this.TXT_ConnexionMdp.PasswordChar = '*';
            this.TXT_ConnexionMdp.Size = new System.Drawing.Size(134, 20);
            this.TXT_ConnexionMdp.TabIndex = 5;
            this.TXT_ConnexionMdp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TXT_ConnexionMdp_MouseClick);
            // 
            // LBL_connexion_erreur
            // 
            this.LBL_connexion_erreur.AutoSize = true;
            this.LBL_connexion_erreur.Location = new System.Drawing.Point(23, 98);
            this.LBL_connexion_erreur.Name = "LBL_connexion_erreur";
            this.LBL_connexion_erreur.Size = new System.Drawing.Size(35, 13);
            this.LBL_connexion_erreur.TabIndex = 6;
            this.LBL_connexion_erreur.Text = "label1";
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 159);
            this.Controls.Add(this.LBL_connexion_erreur);
            this.Controls.Add(this.TXT_ConnexionMdp);
            this.Controls.Add(this.TXT_ConnxionNom);
            this.Controls.Add(this.LBL_ConnexionMdp);
            this.Controls.Add(this.LBL_ConnexionNom);
            this.Controls.Add(this.BTN_ConnexionValider);
            this.Name = "FormConnexion";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_ConnexionValider;
        private System.Windows.Forms.Label LBL_ConnexionNom;
        private System.Windows.Forms.Label LBL_ConnexionMdp;
        private System.Windows.Forms.TextBox TXT_ConnxionNom;
        private System.Windows.Forms.TextBox TXT_ConnexionMdp;
        private System.Windows.Forms.Label LBL_connexion_erreur;
    }
}

