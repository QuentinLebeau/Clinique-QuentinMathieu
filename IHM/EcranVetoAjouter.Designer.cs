namespace Clinique
{
    partial class EcranVetoAjouter
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
            this.LBL_ajoutVeto_Nom = new System.Windows.Forms.Label();
            this.LBL_ajoutVeto_MotDePasse = new System.Windows.Forms.Label();
            this.TXT_ajoutVeto_Nom = new System.Windows.Forms.TextBox();
            this.TXT_ajoutVeto_motPasse = new System.Windows.Forms.TextBox();
            this.BTN_ajoutVeto_ajouter = new System.Windows.Forms.Button();
            this.BYN_ajotuVeto_Annuler = new System.Windows.Forms.Button();
            this.TXT_ajoutVeto_prenom = new System.Windows.Forms.TextBox();
            this.LBL_ajoutVeto_prenom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_ajoutVeto_Nom
            // 
            this.LBL_ajoutVeto_Nom.AutoSize = true;
            this.LBL_ajoutVeto_Nom.Location = new System.Drawing.Point(13, 25);
            this.LBL_ajoutVeto_Nom.Name = "LBL_ajoutVeto_Nom";
            this.LBL_ajoutVeto_Nom.Size = new System.Drawing.Size(29, 13);
            this.LBL_ajoutVeto_Nom.TabIndex = 0;
            this.LBL_ajoutVeto_Nom.Text = "Nom";
            // 
            // LBL_ajoutVeto_MotDePasse
            // 
            this.LBL_ajoutVeto_MotDePasse.AutoSize = true;
            this.LBL_ajoutVeto_MotDePasse.Location = new System.Drawing.Point(194, 25);
            this.LBL_ajoutVeto_MotDePasse.Name = "LBL_ajoutVeto_MotDePasse";
            this.LBL_ajoutVeto_MotDePasse.Size = new System.Drawing.Size(74, 13);
            this.LBL_ajoutVeto_MotDePasse.TabIndex = 1;
            this.LBL_ajoutVeto_MotDePasse.Text = "Mot De Passe";
            // 
            // TXT_ajoutVeto_Nom
            // 
            this.TXT_ajoutVeto_Nom.Location = new System.Drawing.Point(72, 22);
            this.TXT_ajoutVeto_Nom.Name = "TXT_ajoutVeto_Nom";
            this.TXT_ajoutVeto_Nom.Size = new System.Drawing.Size(100, 20);
            this.TXT_ajoutVeto_Nom.TabIndex = 2;
            // 
            // TXT_ajoutVeto_motPasse
            // 
            this.TXT_ajoutVeto_motPasse.Location = new System.Drawing.Point(274, 22);
            this.TXT_ajoutVeto_motPasse.Name = "TXT_ajoutVeto_motPasse";
            this.TXT_ajoutVeto_motPasse.Size = new System.Drawing.Size(100, 20);
            this.TXT_ajoutVeto_motPasse.TabIndex = 3;
            // 
            // BTN_ajoutVeto_ajouter
            // 
            this.BTN_ajoutVeto_ajouter.Location = new System.Drawing.Point(111, 80);
            this.BTN_ajoutVeto_ajouter.Name = "BTN_ajoutVeto_ajouter";
            this.BTN_ajoutVeto_ajouter.Size = new System.Drawing.Size(75, 23);
            this.BTN_ajoutVeto_ajouter.TabIndex = 4;
            this.BTN_ajoutVeto_ajouter.Text = "Ajouter";
            this.BTN_ajoutVeto_ajouter.UseVisualStyleBackColor = true;
            this.BTN_ajoutVeto_ajouter.Click += new System.EventHandler(this.BTN_ajoutVeto_ajouter_Click);
            // 
            // BYN_ajotuVeto_Annuler
            // 
            this.BYN_ajotuVeto_Annuler.Location = new System.Drawing.Point(222, 80);
            this.BYN_ajotuVeto_Annuler.Name = "BYN_ajotuVeto_Annuler";
            this.BYN_ajotuVeto_Annuler.Size = new System.Drawing.Size(75, 23);
            this.BYN_ajotuVeto_Annuler.TabIndex = 5;
            this.BYN_ajotuVeto_Annuler.Text = "Annuler";
            this.BYN_ajotuVeto_Annuler.UseVisualStyleBackColor = true;
            this.BYN_ajotuVeto_Annuler.Click += new System.EventHandler(this.BYN_ajotuVeto_Annuler_Click);
            // 
            // TXT_ajoutVeto_prenom
            // 
            this.TXT_ajoutVeto_prenom.Location = new System.Drawing.Point(72, 52);
            this.TXT_ajoutVeto_prenom.Name = "TXT_ajoutVeto_prenom";
            this.TXT_ajoutVeto_prenom.Size = new System.Drawing.Size(100, 20);
            this.TXT_ajoutVeto_prenom.TabIndex = 6;
            // 
            // LBL_ajoutVeto_prenom
            // 
            this.LBL_ajoutVeto_prenom.AutoSize = true;
            this.LBL_ajoutVeto_prenom.Location = new System.Drawing.Point(16, 55);
            this.LBL_ajoutVeto_prenom.Name = "LBL_ajoutVeto_prenom";
            this.LBL_ajoutVeto_prenom.Size = new System.Drawing.Size(43, 13);
            this.LBL_ajoutVeto_prenom.TabIndex = 7;
            this.LBL_ajoutVeto_prenom.Text = "Prenom";
            // 
            // EcranVetoAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 118);
            this.Controls.Add(this.LBL_ajoutVeto_prenom);
            this.Controls.Add(this.TXT_ajoutVeto_prenom);
            this.Controls.Add(this.BYN_ajotuVeto_Annuler);
            this.Controls.Add(this.BTN_ajoutVeto_ajouter);
            this.Controls.Add(this.TXT_ajoutVeto_motPasse);
            this.Controls.Add(this.TXT_ajoutVeto_Nom);
            this.Controls.Add(this.LBL_ajoutVeto_MotDePasse);
            this.Controls.Add(this.LBL_ajoutVeto_Nom);
            this.Name = "EcranVetoAjouter";
            this.Text = "Ajouter Vétérinaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_ajoutVeto_Nom;
        private System.Windows.Forms.Label LBL_ajoutVeto_MotDePasse;
        private System.Windows.Forms.TextBox TXT_ajoutVeto_Nom;
        private System.Windows.Forms.TextBox TXT_ajoutVeto_motPasse;
        private System.Windows.Forms.Button BTN_ajoutVeto_ajouter;
        private System.Windows.Forms.Button BYN_ajotuVeto_Annuler;
        private System.Windows.Forms.TextBox TXT_ajoutVeto_prenom;
        private System.Windows.Forms.Label LBL_ajoutVeto_prenom;
    }
}