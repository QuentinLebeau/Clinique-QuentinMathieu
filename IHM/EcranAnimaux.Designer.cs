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
            this.groupBox_animaux1 = new System.Windows.Forms.GroupBox();
            this.BTN_animaux_annuler = new System.Windows.Forms.Button();
            this.BTN_animaux_valider = new System.Windows.Forms.Button();
            this.BTN_animaux_DossierMedical = new System.Windows.Forms.Button();
            this.groupBox_animaux_client = new System.Windows.Forms.GroupBox();
            this.LBL_animaux_code = new System.Windows.Forms.Label();
            this.LBL_animaux_nom = new System.Windows.Forms.Label();
            this.LBL_animaux_espece = new System.Windows.Forms.Label();
            this.LBL_animaux_Race = new System.Windows.Forms.Label();
            this.LBL_animaux_tatouage = new System.Windows.Forms.Label();
            this.combo_animaux_Clients = new System.Windows.Forms.ComboBox();
            this.TXT_animaux_code = new System.Windows.Forms.TextBox();
            this.TXT_animaux_nom = new System.Windows.Forms.TextBox();
            this.TXT_animaux_tatouage = new System.Windows.Forms.TextBox();
            this.combo_animaux_sexe = new System.Windows.Forms.ComboBox();
            this.combo_animaux_espece = new System.Windows.Forms.ComboBox();
            this.combo_animaux_race = new System.Windows.Forms.ComboBox();
            this.TXT_animaux_couleur = new System.Windows.Forms.TextBox();
            this.LBL_animaux_couleur = new System.Windows.Forms.Label();
            this.groupBox_animaux1.SuspendLayout();
            this.groupBox_animaux_client.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_animaux1
            // 
            this.groupBox_animaux1.Controls.Add(this.BTN_animaux_annuler);
            this.groupBox_animaux1.Controls.Add(this.BTN_animaux_valider);
            this.groupBox_animaux1.Controls.Add(this.BTN_animaux_DossierMedical);
            this.groupBox_animaux1.Location = new System.Drawing.Point(0, 0);
            this.groupBox_animaux1.Name = "groupBox_animaux1";
            this.groupBox_animaux1.Size = new System.Drawing.Size(478, 62);
            this.groupBox_animaux1.TabIndex = 0;
            this.groupBox_animaux1.TabStop = false;
            // 
            // BTN_animaux_annuler
            // 
            this.BTN_animaux_annuler.Location = new System.Drawing.Point(375, 20);
            this.BTN_animaux_annuler.Name = "BTN_animaux_annuler";
            this.BTN_animaux_annuler.Size = new System.Drawing.Size(75, 23);
            this.BTN_animaux_annuler.TabIndex = 2;
            this.BTN_animaux_annuler.Text = "Annuler";
            this.BTN_animaux_annuler.UseVisualStyleBackColor = true;
            // 
            // BTN_animaux_valider
            // 
            this.BTN_animaux_valider.Location = new System.Drawing.Point(283, 20);
            this.BTN_animaux_valider.Name = "BTN_animaux_valider";
            this.BTN_animaux_valider.Size = new System.Drawing.Size(75, 23);
            this.BTN_animaux_valider.TabIndex = 1;
            this.BTN_animaux_valider.Text = "Valider";
            this.BTN_animaux_valider.UseVisualStyleBackColor = true;
            // 
            // BTN_animaux_DossierMedical
            // 
            this.BTN_animaux_DossierMedical.Location = new System.Drawing.Point(13, 20);
            this.BTN_animaux_DossierMedical.Name = "BTN_animaux_DossierMedical";
            this.BTN_animaux_DossierMedical.Size = new System.Drawing.Size(75, 23);
            this.BTN_animaux_DossierMedical.TabIndex = 0;
            this.BTN_animaux_DossierMedical.Text = "Dossier";
            this.BTN_animaux_DossierMedical.UseVisualStyleBackColor = true;
            // 
            // groupBox_animaux_client
            // 
            this.groupBox_animaux_client.Controls.Add(this.combo_animaux_Clients);
            this.groupBox_animaux_client.Location = new System.Drawing.Point(0, 79);
            this.groupBox_animaux_client.Name = "groupBox_animaux_client";
            this.groupBox_animaux_client.Size = new System.Drawing.Size(478, 65);
            this.groupBox_animaux_client.TabIndex = 3;
            this.groupBox_animaux_client.TabStop = false;
            this.groupBox_animaux_client.Text = "Client :";
            // 
            // LBL_animaux_code
            // 
            this.LBL_animaux_code.AutoSize = true;
            this.LBL_animaux_code.Location = new System.Drawing.Point(38, 166);
            this.LBL_animaux_code.Name = "LBL_animaux_code";
            this.LBL_animaux_code.Size = new System.Drawing.Size(32, 13);
            this.LBL_animaux_code.TabIndex = 4;
            this.LBL_animaux_code.Text = "Code";
            // 
            // LBL_animaux_nom
            // 
            this.LBL_animaux_nom.AutoSize = true;
            this.LBL_animaux_nom.Location = new System.Drawing.Point(38, 216);
            this.LBL_animaux_nom.Name = "LBL_animaux_nom";
            this.LBL_animaux_nom.Size = new System.Drawing.Size(29, 13);
            this.LBL_animaux_nom.TabIndex = 5;
            this.LBL_animaux_nom.Text = "Nom";
            // 
            // LBL_animaux_espece
            // 
            this.LBL_animaux_espece.AutoSize = true;
            this.LBL_animaux_espece.Location = new System.Drawing.Point(38, 372);
            this.LBL_animaux_espece.Name = "LBL_animaux_espece";
            this.LBL_animaux_espece.Size = new System.Drawing.Size(43, 13);
            this.LBL_animaux_espece.TabIndex = 6;
            this.LBL_animaux_espece.Text = "Espèce";
            // 
            // LBL_animaux_Race
            // 
            this.LBL_animaux_Race.AutoSize = true;
            this.LBL_animaux_Race.Location = new System.Drawing.Point(271, 372);
            this.LBL_animaux_Race.Name = "LBL_animaux_Race";
            this.LBL_animaux_Race.Size = new System.Drawing.Size(33, 13);
            this.LBL_animaux_Race.TabIndex = 7;
            this.LBL_animaux_Race.Text = "Race";
            // 
            // LBL_animaux_tatouage
            // 
            this.LBL_animaux_tatouage.AutoSize = true;
            this.LBL_animaux_tatouage.Location = new System.Drawing.Point(38, 454);
            this.LBL_animaux_tatouage.Name = "LBL_animaux_tatouage";
            this.LBL_animaux_tatouage.Size = new System.Drawing.Size(53, 13);
            this.LBL_animaux_tatouage.TabIndex = 8;
            this.LBL_animaux_tatouage.Text = "Tatouage";
            // 
            // combo_animaux_Clients
            // 
            this.combo_animaux_Clients.FormattingEnabled = true;
            this.combo_animaux_Clients.Location = new System.Drawing.Point(41, 19);
            this.combo_animaux_Clients.Name = "combo_animaux_Clients";
            this.combo_animaux_Clients.Size = new System.Drawing.Size(121, 21);
            this.combo_animaux_Clients.TabIndex = 0;
            // 
            // TXT_animaux_code
            // 
            this.TXT_animaux_code.Location = new System.Drawing.Point(97, 163);
            this.TXT_animaux_code.Name = "TXT_animaux_code";
            this.TXT_animaux_code.Size = new System.Drawing.Size(100, 20);
            this.TXT_animaux_code.TabIndex = 9;
            // 
            // TXT_animaux_nom
            // 
            this.TXT_animaux_nom.Location = new System.Drawing.Point(97, 213);
            this.TXT_animaux_nom.Name = "TXT_animaux_nom";
            this.TXT_animaux_nom.Size = new System.Drawing.Size(100, 20);
            this.TXT_animaux_nom.TabIndex = 10;
            // 
            // TXT_animaux_tatouage
            // 
            this.TXT_animaux_tatouage.Location = new System.Drawing.Point(97, 451);
            this.TXT_animaux_tatouage.Name = "TXT_animaux_tatouage";
            this.TXT_animaux_tatouage.Size = new System.Drawing.Size(100, 20);
            this.TXT_animaux_tatouage.TabIndex = 12;
            // 
            // combo_animaux_sexe
            // 
            this.combo_animaux_sexe.FormattingEnabled = true;
            this.combo_animaux_sexe.Location = new System.Drawing.Point(237, 213);
            this.combo_animaux_sexe.Name = "combo_animaux_sexe";
            this.combo_animaux_sexe.Size = new System.Drawing.Size(121, 21);
            this.combo_animaux_sexe.TabIndex = 14;
            // 
            // combo_animaux_espece
            // 
            this.combo_animaux_espece.FormattingEnabled = true;
            this.combo_animaux_espece.Location = new System.Drawing.Point(97, 369);
            this.combo_animaux_espece.Name = "combo_animaux_espece";
            this.combo_animaux_espece.Size = new System.Drawing.Size(121, 21);
            this.combo_animaux_espece.TabIndex = 15;
            // 
            // combo_animaux_race
            // 
            this.combo_animaux_race.FormattingEnabled = true;
            this.combo_animaux_race.Location = new System.Drawing.Point(329, 369);
            this.combo_animaux_race.Name = "combo_animaux_race";
            this.combo_animaux_race.Size = new System.Drawing.Size(121, 21);
            this.combo_animaux_race.TabIndex = 16;
            // 
            // TXT_animaux_couleur
            // 
            this.TXT_animaux_couleur.Location = new System.Drawing.Point(97, 271);
            this.TXT_animaux_couleur.Name = "TXT_animaux_couleur";
            this.TXT_animaux_couleur.Size = new System.Drawing.Size(100, 20);
            this.TXT_animaux_couleur.TabIndex = 17;
            // 
            // LBL_animaux_couleur
            // 
            this.LBL_animaux_couleur.AutoSize = true;
            this.LBL_animaux_couleur.Location = new System.Drawing.Point(38, 274);
            this.LBL_animaux_couleur.Name = "LBL_animaux_couleur";
            this.LBL_animaux_couleur.Size = new System.Drawing.Size(43, 13);
            this.LBL_animaux_couleur.TabIndex = 18;
            this.LBL_animaux_couleur.Text = "Couleur";
            // 
            // EcranAnimaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 513);
            this.Controls.Add(this.LBL_animaux_couleur);
            this.Controls.Add(this.TXT_animaux_couleur);
            this.Controls.Add(this.combo_animaux_race);
            this.Controls.Add(this.combo_animaux_espece);
            this.Controls.Add(this.combo_animaux_sexe);
            this.Controls.Add(this.TXT_animaux_tatouage);
            this.Controls.Add(this.TXT_animaux_nom);
            this.Controls.Add(this.TXT_animaux_code);
            this.Controls.Add(this.LBL_animaux_tatouage);
            this.Controls.Add(this.LBL_animaux_Race);
            this.Controls.Add(this.LBL_animaux_espece);
            this.Controls.Add(this.LBL_animaux_nom);
            this.Controls.Add(this.LBL_animaux_code);
            this.Controls.Add(this.groupBox_animaux_client);
            this.Controls.Add(this.groupBox_animaux1);
            this.Name = "EcranAnimaux";
            this.Text = "Animaux";
            this.groupBox_animaux1.ResumeLayout(false);
            this.groupBox_animaux_client.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_animaux1;
        private System.Windows.Forms.Button BTN_animaux_annuler;
        private System.Windows.Forms.Button BTN_animaux_valider;
        private System.Windows.Forms.Button BTN_animaux_DossierMedical;
        private System.Windows.Forms.GroupBox groupBox_animaux_client;
        private System.Windows.Forms.Label LBL_animaux_code;
        private System.Windows.Forms.Label LBL_animaux_nom;
        private System.Windows.Forms.Label LBL_animaux_espece;
        private System.Windows.Forms.Label LBL_animaux_Race;
        private System.Windows.Forms.Label LBL_animaux_tatouage;
        private System.Windows.Forms.ComboBox combo_animaux_Clients;
        private System.Windows.Forms.TextBox TXT_animaux_code;
        private System.Windows.Forms.TextBox TXT_animaux_nom;
        private System.Windows.Forms.TextBox TXT_animaux_tatouage;
        private System.Windows.Forms.ComboBox combo_animaux_sexe;
        private System.Windows.Forms.ComboBox combo_animaux_espece;
        private System.Windows.Forms.ComboBox combo_animaux_race;
        private System.Windows.Forms.TextBox TXT_animaux_couleur;
        private System.Windows.Forms.Label LBL_animaux_couleur;
    }
}