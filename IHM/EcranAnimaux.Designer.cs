namespace Clinique
{
    partial class EcranAnimaux
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
            this.BTN_animaux_annuler = new System.Windows.Forms.Button();
            this.BTN_animaux_valider = new System.Windows.Forms.Button();
            this.BTN_animaux_DossierMedical = new System.Windows.Forms.Button();
            this.LBL_animaux_tatouage = new System.Windows.Forms.Label();
            this.TXT_animaux_tatouage = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_animaux_sexe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_animaux_code = new System.Windows.Forms.TextBox();
            this.LBL_animaux_code = new System.Windows.Forms.Label();
            this.TXT_animaux_nom = new System.Windows.Forms.TextBox();
            this.LBL_animaux_nom = new System.Windows.Forms.Label();
            this.LBL_animaux_couleur = new System.Windows.Forms.Label();
            this.TXT_animaux_couleur = new System.Windows.Forms.TextBox();
            this.combo_animaux_Clients = new System.Windows.Forms.ComboBox();
            this.combo_animaux_race = new System.Windows.Forms.ComboBox();
            this.combo_animaux_espece = new System.Windows.Forms.ComboBox();
            this.LBL_animaux_Race = new System.Windows.Forms.Label();
            this.LBL_animaux_espece = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_animaux_annuler
            // 
            this.BTN_animaux_annuler.Location = new System.Drawing.Point(395, 12);
            this.BTN_animaux_annuler.Name = "BTN_animaux_annuler";
            this.BTN_animaux_annuler.Size = new System.Drawing.Size(75, 23);
            this.BTN_animaux_annuler.TabIndex = 2;
            this.BTN_animaux_annuler.Text = "Annuler";
            this.BTN_animaux_annuler.UseVisualStyleBackColor = true;
            // 
            // BTN_animaux_valider
            // 
            this.BTN_animaux_valider.Location = new System.Drawing.Point(208, 12);
            this.BTN_animaux_valider.Name = "BTN_animaux_valider";
            this.BTN_animaux_valider.Size = new System.Drawing.Size(75, 23);
            this.BTN_animaux_valider.TabIndex = 1;
            this.BTN_animaux_valider.Text = "Valider";
            this.BTN_animaux_valider.UseVisualStyleBackColor = true;
            // 
            // BTN_animaux_DossierMedical
            // 
            this.BTN_animaux_DossierMedical.Location = new System.Drawing.Point(12, 12);
            this.BTN_animaux_DossierMedical.Name = "BTN_animaux_DossierMedical";
            this.BTN_animaux_DossierMedical.Size = new System.Drawing.Size(75, 23);
            this.BTN_animaux_DossierMedical.TabIndex = 0;
            this.BTN_animaux_DossierMedical.Text = "Dossier";
            this.BTN_animaux_DossierMedical.UseVisualStyleBackColor = true;
            // 
            // LBL_animaux_tatouage
            // 
            this.LBL_animaux_tatouage.AutoSize = true;
            this.LBL_animaux_tatouage.Location = new System.Drawing.Point(214, 79);
            this.LBL_animaux_tatouage.Name = "LBL_animaux_tatouage";
            this.LBL_animaux_tatouage.Size = new System.Drawing.Size(53, 13);
            this.LBL_animaux_tatouage.TabIndex = 8;
            this.LBL_animaux_tatouage.Text = "Tatouage";
            // 
            // TXT_animaux_tatouage
            // 
            this.TXT_animaux_tatouage.Location = new System.Drawing.Point(273, 81);
            this.TXT_animaux_tatouage.Name = "TXT_animaux_tatouage";
            this.TXT_animaux_tatouage.Size = new System.Drawing.Size(164, 20);
            this.TXT_animaux_tatouage.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.combo_animaux_race);
            this.groupBox1.Controls.Add(this.combo_animaux_Clients);
            this.groupBox1.Controls.Add(this.combo_animaux_espece);
            this.groupBox1.Controls.Add(this.LBL_animaux_Race);
            this.groupBox1.Controls.Add(this.LBL_animaux_couleur);
            this.groupBox1.Controls.Add(this.LBL_animaux_espece);
            this.groupBox1.Controls.Add(this.TXT_animaux_tatouage);
            this.groupBox1.Controls.Add(this.LBL_animaux_tatouage);
            this.groupBox1.Controls.Add(this.TXT_animaux_couleur);
            this.groupBox1.Controls.Add(this.TXT_animaux_nom);
            this.groupBox1.Controls.Add(this.LBL_animaux_nom);
            this.groupBox1.Controls.Add(this.TXT_animaux_code);
            this.groupBox1.Controls.Add(this.LBL_animaux_code);
            this.groupBox1.Location = new System.Drawing.Point(16, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 150);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal";
            // 
            // combo_animaux_sexe
            // 
            this.combo_animaux_sexe.FormattingEnabled = true;
            this.combo_animaux_sexe.Location = new System.Drawing.Point(72, 64);
            this.combo_animaux_sexe.Name = "combo_animaux_sexe";
            this.combo_animaux_sexe.Size = new System.Drawing.Size(398, 21);
            this.combo_animaux_sexe.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Client";
            // 
            // TXT_animaux_code
            // 
            this.TXT_animaux_code.Location = new System.Drawing.Point(61, 28);
            this.TXT_animaux_code.Name = "TXT_animaux_code";
            this.TXT_animaux_code.Size = new System.Drawing.Size(376, 20);
            this.TXT_animaux_code.TabIndex = 11;
            // 
            // LBL_animaux_code
            // 
            this.LBL_animaux_code.AutoSize = true;
            this.LBL_animaux_code.Location = new System.Drawing.Point(19, 32);
            this.LBL_animaux_code.Name = "LBL_animaux_code";
            this.LBL_animaux_code.Size = new System.Drawing.Size(32, 13);
            this.LBL_animaux_code.TabIndex = 10;
            this.LBL_animaux_code.Text = "Code";
            this.LBL_animaux_code.Click += new System.EventHandler(this.LBL_animaux_code_Click);
            // 
            // TXT_animaux_nom
            // 
            this.TXT_animaux_nom.Location = new System.Drawing.Point(61, 54);
            this.TXT_animaux_nom.Name = "TXT_animaux_nom";
            this.TXT_animaux_nom.Size = new System.Drawing.Size(147, 20);
            this.TXT_animaux_nom.TabIndex = 13;
            // 
            // LBL_animaux_nom
            // 
            this.LBL_animaux_nom.AutoSize = true;
            this.LBL_animaux_nom.Location = new System.Drawing.Point(22, 58);
            this.LBL_animaux_nom.Name = "LBL_animaux_nom";
            this.LBL_animaux_nom.Size = new System.Drawing.Size(29, 13);
            this.LBL_animaux_nom.TabIndex = 12;
            this.LBL_animaux_nom.Text = "Nom";
            // 
            // LBL_animaux_couleur
            // 
            this.LBL_animaux_couleur.AutoSize = true;
            this.LBL_animaux_couleur.Location = new System.Drawing.Point(8, 83);
            this.LBL_animaux_couleur.Name = "LBL_animaux_couleur";
            this.LBL_animaux_couleur.Size = new System.Drawing.Size(43, 13);
            this.LBL_animaux_couleur.TabIndex = 20;
            this.LBL_animaux_couleur.Text = "Couleur";
            // 
            // TXT_animaux_couleur
            // 
            this.TXT_animaux_couleur.Location = new System.Drawing.Point(61, 80);
            this.TXT_animaux_couleur.Name = "TXT_animaux_couleur";
            this.TXT_animaux_couleur.Size = new System.Drawing.Size(147, 20);
            this.TXT_animaux_couleur.TabIndex = 19;
            // 
            // combo_animaux_Clients
            // 
            this.combo_animaux_Clients.FormattingEnabled = true;
            this.combo_animaux_Clients.Location = new System.Drawing.Point(273, 54);
            this.combo_animaux_Clients.Name = "combo_animaux_Clients";
            this.combo_animaux_Clients.Size = new System.Drawing.Size(164, 21);
            this.combo_animaux_Clients.TabIndex = 21;
            // 
            // combo_animaux_race
            // 
            this.combo_animaux_race.FormattingEnabled = true;
            this.combo_animaux_race.Location = new System.Drawing.Point(61, 106);
            this.combo_animaux_race.Name = "combo_animaux_race";
            this.combo_animaux_race.Size = new System.Drawing.Size(147, 21);
            this.combo_animaux_race.TabIndex = 24;
            // 
            // combo_animaux_espece
            // 
            this.combo_animaux_espece.FormattingEnabled = true;
            this.combo_animaux_espece.Location = new System.Drawing.Point(273, 107);
            this.combo_animaux_espece.Name = "combo_animaux_espece";
            this.combo_animaux_espece.Size = new System.Drawing.Size(164, 21);
            this.combo_animaux_espece.TabIndex = 23;
            // 
            // LBL_animaux_Race
            // 
            this.LBL_animaux_Race.AutoSize = true;
            this.LBL_animaux_Race.Location = new System.Drawing.Point(18, 109);
            this.LBL_animaux_Race.Name = "LBL_animaux_Race";
            this.LBL_animaux_Race.Size = new System.Drawing.Size(33, 13);
            this.LBL_animaux_Race.TabIndex = 22;
            this.LBL_animaux_Race.Text = "Race";
            // 
            // LBL_animaux_espece
            // 
            this.LBL_animaux_espece.AutoSize = true;
            this.LBL_animaux_espece.Location = new System.Drawing.Point(224, 110);
            this.LBL_animaux_espece.Name = "LBL_animaux_espece";
            this.LBL_animaux_espece.Size = new System.Drawing.Size(43, 13);
            this.LBL_animaux_espece.TabIndex = 21;
            this.LBL_animaux_espece.Text = "Espèce";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Sexe";
            // 
            // EcranAnimaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 267);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_animaux_annuler);
            this.Controls.Add(this.BTN_animaux_valider);
            this.Controls.Add(this.BTN_animaux_DossierMedical);
            this.Controls.Add(this.combo_animaux_sexe);
            this.Name = "EcranAnimaux";
            this.Text = "Animaux";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_animaux_annuler;
        private System.Windows.Forms.Button BTN_animaux_valider;
        private System.Windows.Forms.Button BTN_animaux_DossierMedical;
        private System.Windows.Forms.Label LBL_animaux_tatouage;
        private System.Windows.Forms.TextBox TXT_animaux_tatouage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_animaux_nom;
        private System.Windows.Forms.Label LBL_animaux_nom;
        private System.Windows.Forms.TextBox TXT_animaux_code;
        private System.Windows.Forms.Label LBL_animaux_code;
        private System.Windows.Forms.ComboBox combo_animaux_sexe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_animaux_race;
        private System.Windows.Forms.ComboBox combo_animaux_Clients;
        private System.Windows.Forms.ComboBox combo_animaux_espece;
        private System.Windows.Forms.Label LBL_animaux_Race;
        private System.Windows.Forms.Label LBL_animaux_couleur;
        private System.Windows.Forms.Label LBL_animaux_espece;
        private System.Windows.Forms.TextBox TXT_animaux_couleur;
    }
}