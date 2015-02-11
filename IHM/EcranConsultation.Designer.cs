namespace Clinique
{
    partial class EcranConsultation
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
            this.BTN_AnnulerConsu = new System.Windows.Forms.Button();
            this.BTN_ValiderConsu = new System.Windows.Forms.Button();
            this.BTN_DossierMedical = new System.Windows.Forms.Button();
            this.groupBox_consultation_animal = new System.Windows.Forms.GroupBox();
            this.TXT_Tatouage = new System.Windows.Forms.TextBox();
            this.TXT_Sexe = new System.Windows.Forms.TextBox();
            this.TXT_Race = new System.Windows.Forms.TextBox();
            this.TXT_Couleur = new System.Windows.Forms.TextBox();
            this.TXT_NomAnimal = new System.Windows.Forms.TextBox();
            this.TXT_Espece = new System.Windows.Forms.TextBox();
            this.TXT_CodeAnimal = new System.Windows.Forms.TextBox();
            this.LBL_consultation_tatouage = new System.Windows.Forms.Label();
            this.LBL_consultation_sexe = new System.Windows.Forms.Label();
            this.LBL_consultation_couleur = new System.Windows.Forms.Label();
            this.LBL_consultation_race = new System.Windows.Forms.Label();
            this.LBL_consultation_nom = new System.Windows.Forms.Label();
            this.LBL_consultation_espece = new System.Windows.Forms.Label();
            this.LBL_consultation_code = new System.Windows.Forms.Label();
            this.groupBox_consultation_actes = new System.Windows.Forms.GroupBox();
            this.LBL_NbActe = new System.Windows.Forms.Label();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.BTN_Enregistrer = new System.Windows.Forms.Button();
            this.BTN_AjouterActe = new System.Windows.Forms.Button();
            this.COMBO_Veto = new System.Windows.Forms.ComboBox();
            this.DATE_Acte = new System.Windows.Forms.DateTimePicker();
            this.GRID_LigneConsu = new System.Windows.Forms.DataGridView();
            this.LBL_consulation_total = new System.Windows.Forms.Label();
            this.TXT_Total = new System.Windows.Forms.TextBox();
            this.COMBO_TypeActe = new System.Windows.Forms.ComboBox();
            this.COMBO_LibelleActe = new System.Windows.Forms.ComboBox();
            this.LBL_consultation_libelle = new System.Windows.Forms.Label();
            this.LBL_consultation_type = new System.Windows.Forms.Label();
            this.LBL_consultation_veterinaire = new System.Windows.Forms.Label();
            this.LBL_consultation_dateActe = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LBL_consultation_prix = new System.Windows.Forms.Label();
            this.LBL_consultation_maxi = new System.Windows.Forms.Label();
            this.LBL_consultation_min = new System.Windows.Forms.Label();
            this.TXT_Prix = new System.Windows.Forms.TextBox();
            this.TXT_Maxi = new System.Windows.Forms.TextBox();
            this.TXT_Mini = new System.Windows.Forms.TextBox();
            this.LBL_consultation_commentaire = new System.Windows.Forms.Label();
            this.TXT_Commentaire = new System.Windows.Forms.RichTextBox();
            this.groupBox_consultation_animal.SuspendLayout();
            this.groupBox_consultation_actes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_LigneConsu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_AnnulerConsu
            // 
            this.BTN_AnnulerConsu.Enabled = false;
            this.BTN_AnnulerConsu.Location = new System.Drawing.Point(590, 12);
            this.BTN_AnnulerConsu.Name = "BTN_AnnulerConsu";
            this.BTN_AnnulerConsu.Size = new System.Drawing.Size(144, 23);
            this.BTN_AnnulerConsu.TabIndex = 2;
            this.BTN_AnnulerConsu.Text = "Annuler";
            this.BTN_AnnulerConsu.UseVisualStyleBackColor = true;
            this.BTN_AnnulerConsu.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTN_ValiderConsu
            // 
            this.BTN_ValiderConsu.Enabled = false;
            this.BTN_ValiderConsu.Location = new System.Drawing.Point(12, 12);
            this.BTN_ValiderConsu.Name = "BTN_ValiderConsu";
            this.BTN_ValiderConsu.Size = new System.Drawing.Size(144, 23);
            this.BTN_ValiderConsu.TabIndex = 1;
            this.BTN_ValiderConsu.Text = "Valider";
            this.BTN_ValiderConsu.UseVisualStyleBackColor = true;
            this.BTN_ValiderConsu.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_DossierMedical
            // 
            this.BTN_DossierMedical.Location = new System.Drawing.Point(311, 12);
            this.BTN_DossierMedical.Name = "BTN_DossierMedical";
            this.BTN_DossierMedical.Size = new System.Drawing.Size(144, 23);
            this.BTN_DossierMedical.TabIndex = 0;
            this.BTN_DossierMedical.Text = "Dossier medical";
            this.BTN_DossierMedical.UseVisualStyleBackColor = true;
            this.BTN_DossierMedical.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox_consultation_animal
            // 
            this.groupBox_consultation_animal.Controls.Add(this.TXT_Tatouage);
            this.groupBox_consultation_animal.Controls.Add(this.TXT_Sexe);
            this.groupBox_consultation_animal.Controls.Add(this.TXT_Race);
            this.groupBox_consultation_animal.Controls.Add(this.TXT_Couleur);
            this.groupBox_consultation_animal.Controls.Add(this.TXT_NomAnimal);
            this.groupBox_consultation_animal.Controls.Add(this.TXT_Espece);
            this.groupBox_consultation_animal.Controls.Add(this.TXT_CodeAnimal);
            this.groupBox_consultation_animal.Controls.Add(this.LBL_consultation_tatouage);
            this.groupBox_consultation_animal.Controls.Add(this.LBL_consultation_sexe);
            this.groupBox_consultation_animal.Controls.Add(this.LBL_consultation_couleur);
            this.groupBox_consultation_animal.Controls.Add(this.LBL_consultation_race);
            this.groupBox_consultation_animal.Controls.Add(this.LBL_consultation_nom);
            this.groupBox_consultation_animal.Controls.Add(this.LBL_consultation_espece);
            this.groupBox_consultation_animal.Controls.Add(this.LBL_consultation_code);
            this.groupBox_consultation_animal.Location = new System.Drawing.Point(12, 51);
            this.groupBox_consultation_animal.Name = "groupBox_consultation_animal";
            this.groupBox_consultation_animal.Size = new System.Drawing.Size(722, 81);
            this.groupBox_consultation_animal.TabIndex = 1;
            this.groupBox_consultation_animal.TabStop = false;
            this.groupBox_consultation_animal.Text = "Animal";
            this.groupBox_consultation_animal.Enter += new System.EventHandler(this.groupBox_consultation_animal_Enter);
            // 
            // TXT_Tatouage
            // 
            this.TXT_Tatouage.Enabled = false;
            this.TXT_Tatouage.Location = new System.Drawing.Point(433, 45);
            this.TXT_Tatouage.Name = "TXT_Tatouage";
            this.TXT_Tatouage.Size = new System.Drawing.Size(232, 20);
            this.TXT_Tatouage.TabIndex = 13;
            this.TXT_Tatouage.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // TXT_Sexe
            // 
            this.TXT_Sexe.Enabled = false;
            this.TXT_Sexe.Location = new System.Drawing.Point(628, 19);
            this.TXT_Sexe.Name = "TXT_Sexe";
            this.TXT_Sexe.Size = new System.Drawing.Size(37, 20);
            this.TXT_Sexe.TabIndex = 12;
            this.TXT_Sexe.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // TXT_Race
            // 
            this.TXT_Race.Enabled = false;
            this.TXT_Race.Location = new System.Drawing.Point(235, 45);
            this.TXT_Race.Name = "TXT_Race";
            this.TXT_Race.Size = new System.Drawing.Size(134, 20);
            this.TXT_Race.TabIndex = 11;
            this.TXT_Race.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // TXT_Couleur
            // 
            this.TXT_Couleur.Enabled = false;
            this.TXT_Couleur.Location = new System.Drawing.Point(433, 19);
            this.TXT_Couleur.Name = "TXT_Couleur";
            this.TXT_Couleur.Size = new System.Drawing.Size(134, 20);
            this.TXT_Couleur.TabIndex = 10;
            this.TXT_Couleur.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // TXT_NomAnimal
            // 
            this.TXT_NomAnimal.Enabled = false;
            this.TXT_NomAnimal.Location = new System.Drawing.Point(235, 19);
            this.TXT_NomAnimal.Name = "TXT_NomAnimal";
            this.TXT_NomAnimal.Size = new System.Drawing.Size(134, 20);
            this.TXT_NomAnimal.TabIndex = 9;
            this.TXT_NomAnimal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TXT_Espece
            // 
            this.TXT_Espece.Enabled = false;
            this.TXT_Espece.Location = new System.Drawing.Point(56, 45);
            this.TXT_Espece.Name = "TXT_Espece";
            this.TXT_Espece.Size = new System.Drawing.Size(134, 20);
            this.TXT_Espece.TabIndex = 8;
            this.TXT_Espece.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TXT_CodeAnimal
            // 
            this.TXT_CodeAnimal.Enabled = false;
            this.TXT_CodeAnimal.Location = new System.Drawing.Point(56, 19);
            this.TXT_CodeAnimal.Name = "TXT_CodeAnimal";
            this.TXT_CodeAnimal.Size = new System.Drawing.Size(134, 20);
            this.TXT_CodeAnimal.TabIndex = 7;
            this.TXT_CodeAnimal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LBL_consultation_tatouage
            // 
            this.LBL_consultation_tatouage.AutoSize = true;
            this.LBL_consultation_tatouage.Location = new System.Drawing.Point(374, 48);
            this.LBL_consultation_tatouage.Name = "LBL_consultation_tatouage";
            this.LBL_consultation_tatouage.Size = new System.Drawing.Size(53, 13);
            this.LBL_consultation_tatouage.TabIndex = 6;
            this.LBL_consultation_tatouage.Text = "Tatouage";
            this.LBL_consultation_tatouage.Click += new System.EventHandler(this.LBL_consultation_tatouage_Click);
            // 
            // LBL_consultation_sexe
            // 
            this.LBL_consultation_sexe.AutoSize = true;
            this.LBL_consultation_sexe.Location = new System.Drawing.Point(591, 22);
            this.LBL_consultation_sexe.Name = "LBL_consultation_sexe";
            this.LBL_consultation_sexe.Size = new System.Drawing.Size(31, 13);
            this.LBL_consultation_sexe.TabIndex = 5;
            this.LBL_consultation_sexe.Text = "Sexe";
            this.LBL_consultation_sexe.Click += new System.EventHandler(this.LBL_consultation_sexe_Click);
            // 
            // LBL_consultation_couleur
            // 
            this.LBL_consultation_couleur.AutoSize = true;
            this.LBL_consultation_couleur.Location = new System.Drawing.Point(384, 19);
            this.LBL_consultation_couleur.Name = "LBL_consultation_couleur";
            this.LBL_consultation_couleur.Size = new System.Drawing.Size(43, 13);
            this.LBL_consultation_couleur.TabIndex = 4;
            this.LBL_consultation_couleur.Text = "Couleur";
            this.LBL_consultation_couleur.Click += new System.EventHandler(this.LBL_consultation_couleur_Click);
            // 
            // LBL_consultation_race
            // 
            this.LBL_consultation_race.AutoSize = true;
            this.LBL_consultation_race.Location = new System.Drawing.Point(200, 48);
            this.LBL_consultation_race.Name = "LBL_consultation_race";
            this.LBL_consultation_race.Size = new System.Drawing.Size(33, 13);
            this.LBL_consultation_race.TabIndex = 3;
            this.LBL_consultation_race.Text = "Race";
            this.LBL_consultation_race.Click += new System.EventHandler(this.LBL_consultation_race_Click);
            // 
            // LBL_consultation_nom
            // 
            this.LBL_consultation_nom.AutoSize = true;
            this.LBL_consultation_nom.Location = new System.Drawing.Point(200, 22);
            this.LBL_consultation_nom.Name = "LBL_consultation_nom";
            this.LBL_consultation_nom.Size = new System.Drawing.Size(29, 13);
            this.LBL_consultation_nom.TabIndex = 2;
            this.LBL_consultation_nom.Text = "Nom";
            this.LBL_consultation_nom.Click += new System.EventHandler(this.LBL_consultation_nom_Click);
            // 
            // LBL_consultation_espece
            // 
            this.LBL_consultation_espece.AutoSize = true;
            this.LBL_consultation_espece.Location = new System.Drawing.Point(7, 48);
            this.LBL_consultation_espece.Name = "LBL_consultation_espece";
            this.LBL_consultation_espece.Size = new System.Drawing.Size(43, 13);
            this.LBL_consultation_espece.TabIndex = 1;
            this.LBL_consultation_espece.Text = "Espèce";
            this.LBL_consultation_espece.Click += new System.EventHandler(this.LBL_consultation_espece_Click);
            // 
            // LBL_consultation_code
            // 
            this.LBL_consultation_code.AutoSize = true;
            this.LBL_consultation_code.Location = new System.Drawing.Point(18, 22);
            this.LBL_consultation_code.Name = "LBL_consultation_code";
            this.LBL_consultation_code.Size = new System.Drawing.Size(32, 13);
            this.LBL_consultation_code.TabIndex = 0;
            this.LBL_consultation_code.Text = "Code";
            this.LBL_consultation_code.Click += new System.EventHandler(this.LBL_consultation_code_Click);
            // 
            // groupBox_consultation_actes
            // 
            this.groupBox_consultation_actes.Controls.Add(this.LBL_NbActe);
            this.groupBox_consultation_actes.Controls.Add(this.BTN_Supprimer);
            this.groupBox_consultation_actes.Controls.Add(this.BTN_Enregistrer);
            this.groupBox_consultation_actes.Controls.Add(this.BTN_AjouterActe);
            this.groupBox_consultation_actes.Controls.Add(this.COMBO_Veto);
            this.groupBox_consultation_actes.Controls.Add(this.DATE_Acte);
            this.groupBox_consultation_actes.Controls.Add(this.GRID_LigneConsu);
            this.groupBox_consultation_actes.Controls.Add(this.LBL_consulation_total);
            this.groupBox_consultation_actes.Controls.Add(this.TXT_Total);
            this.groupBox_consultation_actes.Controls.Add(this.COMBO_TypeActe);
            this.groupBox_consultation_actes.Controls.Add(this.COMBO_LibelleActe);
            this.groupBox_consultation_actes.Controls.Add(this.LBL_consultation_libelle);
            this.groupBox_consultation_actes.Controls.Add(this.LBL_consultation_type);
            this.groupBox_consultation_actes.Controls.Add(this.LBL_consultation_veterinaire);
            this.groupBox_consultation_actes.Controls.Add(this.LBL_consultation_dateActe);
            this.groupBox_consultation_actes.Controls.Add(this.groupBox2);
            this.groupBox_consultation_actes.Location = new System.Drawing.Point(12, 219);
            this.groupBox_consultation_actes.Name = "groupBox_consultation_actes";
            this.groupBox_consultation_actes.Size = new System.Drawing.Size(722, 301);
            this.groupBox_consultation_actes.TabIndex = 3;
            this.groupBox_consultation_actes.TabStop = false;
            this.groupBox_consultation_actes.Text = "Actes";
            this.groupBox_consultation_actes.Enter += new System.EventHandler(this.groupBox_consultation_actes_Enter);
            // 
            // LBL_NbActe
            // 
            this.LBL_NbActe.AutoSize = true;
            this.LBL_NbActe.Location = new System.Drawing.Point(53, 1);
            this.LBL_NbActe.Name = "LBL_NbActe";
            this.LBL_NbActe.Size = new System.Drawing.Size(13, 13);
            this.LBL_NbActe.TabIndex = 18;
            this.LBL_NbActe.Text = "0";
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Enabled = false;
            this.BTN_Supprimer.Location = new System.Drawing.Point(327, 267);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(144, 23);
            this.BTN_Supprimer.TabIndex = 17;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // BTN_Enregistrer
            // 
            this.BTN_Enregistrer.Enabled = false;
            this.BTN_Enregistrer.Location = new System.Drawing.Point(170, 267);
            this.BTN_Enregistrer.Name = "BTN_Enregistrer";
            this.BTN_Enregistrer.Size = new System.Drawing.Size(144, 23);
            this.BTN_Enregistrer.TabIndex = 16;
            this.BTN_Enregistrer.Text = "Enregistrer";
            this.BTN_Enregistrer.UseVisualStyleBackColor = true;
            this.BTN_Enregistrer.Click += new System.EventHandler(this.BTN_Enregistrer_Click);
            // 
            // BTN_AjouterActe
            // 
            this.BTN_AjouterActe.Location = new System.Drawing.Point(10, 267);
            this.BTN_AjouterActe.Name = "BTN_AjouterActe";
            this.BTN_AjouterActe.Size = new System.Drawing.Size(144, 23);
            this.BTN_AjouterActe.TabIndex = 15;
            this.BTN_AjouterActe.Text = "Ajouter";
            this.BTN_AjouterActe.UseVisualStyleBackColor = true;
            this.BTN_AjouterActe.Click += new System.EventHandler(this.BTN_AjouterActe_Click);
            // 
            // COMBO_Veto
            // 
            this.COMBO_Veto.Enabled = false;
            this.COMBO_Veto.FormattingEnabled = true;
            this.COMBO_Veto.Location = new System.Drawing.Point(433, 20);
            this.COMBO_Veto.Name = "COMBO_Veto";
            this.COMBO_Veto.Size = new System.Drawing.Size(270, 21);
            this.COMBO_Veto.TabIndex = 14;
            // 
            // DATE_Acte
            // 
            this.DATE_Acte.Enabled = false;
            this.DATE_Acte.Location = new System.Drawing.Point(69, 17);
            this.DATE_Acte.Name = "DATE_Acte";
            this.DATE_Acte.Size = new System.Drawing.Size(255, 20);
            this.DATE_Acte.TabIndex = 13;
            this.DATE_Acte.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // GRID_LigneConsu
            // 
            this.GRID_LigneConsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_LigneConsu.Location = new System.Drawing.Point(10, 113);
            this.GRID_LigneConsu.Name = "GRID_LigneConsu";
            this.GRID_LigneConsu.Size = new System.Drawing.Size(461, 145);
            this.GRID_LigneConsu.TabIndex = 12;
            this.GRID_LigneConsu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LBL_consulation_total
            // 
            this.LBL_consulation_total.AutoSize = true;
            this.LBL_consulation_total.Location = new System.Drawing.Point(497, 195);
            this.LBL_consulation_total.Name = "LBL_consulation_total";
            this.LBL_consulation_total.Size = new System.Drawing.Size(91, 13);
            this.LBL_consulation_total.TabIndex = 11;
            this.LBL_consulation_total.Text = "Total consultation";
            this.LBL_consulation_total.Click += new System.EventHandler(this.label8_Click);
            // 
            // TXT_Total
            // 
            this.TXT_Total.Enabled = false;
            this.TXT_Total.Location = new System.Drawing.Point(594, 192);
            this.TXT_Total.Name = "TXT_Total";
            this.TXT_Total.Size = new System.Drawing.Size(100, 20);
            this.TXT_Total.TabIndex = 10;
            this.TXT_Total.Text = "0";
            this.TXT_Total.TextChanged += new System.EventHandler(this.TXT_consultation_total_TextChanged);
            // 
            // COMBO_TypeActe
            // 
            this.COMBO_TypeActe.Enabled = false;
            this.COMBO_TypeActe.FormattingEnabled = true;
            this.COMBO_TypeActe.Location = new System.Drawing.Point(69, 57);
            this.COMBO_TypeActe.Name = "COMBO_TypeActe";
            this.COMBO_TypeActe.Size = new System.Drawing.Size(157, 21);
            this.COMBO_TypeActe.TabIndex = 9;
            this.COMBO_TypeActe.SelectedIndexChanged += new System.EventHandler(this.combo_consultation_type_SelectedIndexChanged);
            this.COMBO_TypeActe.SelectionChangeCommitted += new System.EventHandler(this.COMBO_TypeActe_SelectionChangeCommitted);
            // 
            // COMBO_LibelleActe
            // 
            this.COMBO_LibelleActe.Enabled = false;
            this.COMBO_LibelleActe.FormattingEnabled = true;
            this.COMBO_LibelleActe.Location = new System.Drawing.Point(316, 57);
            this.COMBO_LibelleActe.Name = "COMBO_LibelleActe";
            this.COMBO_LibelleActe.Size = new System.Drawing.Size(152, 21);
            this.COMBO_LibelleActe.TabIndex = 8;
            this.COMBO_LibelleActe.SelectedIndexChanged += new System.EventHandler(this.combo_consultation_libelle_SelectedIndexChanged);
            this.COMBO_LibelleActe.SelectionChangeCommitted += new System.EventHandler(this.COMBO_LibelleActe_SelectionChangeCommitted);
            // 
            // LBL_consultation_libelle
            // 
            this.LBL_consultation_libelle.AutoSize = true;
            this.LBL_consultation_libelle.Location = new System.Drawing.Point(273, 60);
            this.LBL_consultation_libelle.Name = "LBL_consultation_libelle";
            this.LBL_consultation_libelle.Size = new System.Drawing.Size(37, 13);
            this.LBL_consultation_libelle.TabIndex = 7;
            this.LBL_consultation_libelle.Text = "Libellé";
            this.LBL_consultation_libelle.Click += new System.EventHandler(this.LBL_consultation_libelle_Click);
            // 
            // LBL_consultation_type
            // 
            this.LBL_consultation_type.AutoSize = true;
            this.LBL_consultation_type.Location = new System.Drawing.Point(32, 57);
            this.LBL_consultation_type.Name = "LBL_consultation_type";
            this.LBL_consultation_type.Size = new System.Drawing.Size(31, 13);
            this.LBL_consultation_type.TabIndex = 6;
            this.LBL_consultation_type.Text = "Type";
            this.LBL_consultation_type.Click += new System.EventHandler(this.LBL_consultation_type_Click);
            // 
            // LBL_consultation_veterinaire
            // 
            this.LBL_consultation_veterinaire.AutoSize = true;
            this.LBL_consultation_veterinaire.Location = new System.Drawing.Point(370, 20);
            this.LBL_consultation_veterinaire.Name = "LBL_consultation_veterinaire";
            this.LBL_consultation_veterinaire.Size = new System.Drawing.Size(57, 13);
            this.LBL_consultation_veterinaire.TabIndex = 5;
            this.LBL_consultation_veterinaire.Text = "Vétérinaire";
            this.LBL_consultation_veterinaire.Click += new System.EventHandler(this.LBL_consultation_veterinaire_Click);
            // 
            // LBL_consultation_dateActe
            // 
            this.LBL_consultation_dateActe.AutoSize = true;
            this.LBL_consultation_dateActe.Location = new System.Drawing.Point(33, 20);
            this.LBL_consultation_dateActe.Name = "LBL_consultation_dateActe";
            this.LBL_consultation_dateActe.Size = new System.Drawing.Size(30, 13);
            this.LBL_consultation_dateActe.TabIndex = 4;
            this.LBL_consultation_dateActe.Text = "Date";
            this.LBL_consultation_dateActe.Click += new System.EventHandler(this.LBL_consultation_dateActe_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LBL_consultation_prix);
            this.groupBox2.Controls.Add(this.LBL_consultation_maxi);
            this.groupBox2.Controls.Add(this.LBL_consultation_min);
            this.groupBox2.Controls.Add(this.TXT_Prix);
            this.groupBox2.Controls.Add(this.TXT_Maxi);
            this.groupBox2.Controls.Add(this.TXT_Mini);
            this.groupBox2.Location = new System.Drawing.Point(515, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // LBL_consultation_prix
            // 
            this.LBL_consultation_prix.AutoSize = true;
            this.LBL_consultation_prix.Location = new System.Drawing.Point(6, 69);
            this.LBL_consultation_prix.Name = "LBL_consultation_prix";
            this.LBL_consultation_prix.Size = new System.Drawing.Size(24, 13);
            this.LBL_consultation_prix.TabIndex = 5;
            this.LBL_consultation_prix.Text = "Prix";
            this.LBL_consultation_prix.Click += new System.EventHandler(this.label7_Click);
            // 
            // LBL_consultation_maxi
            // 
            this.LBL_consultation_maxi.AutoSize = true;
            this.LBL_consultation_maxi.Location = new System.Drawing.Point(6, 43);
            this.LBL_consultation_maxi.Name = "LBL_consultation_maxi";
            this.LBL_consultation_maxi.Size = new System.Drawing.Size(29, 13);
            this.LBL_consultation_maxi.TabIndex = 4;
            this.LBL_consultation_maxi.Text = "Maxi";
            this.LBL_consultation_maxi.Click += new System.EventHandler(this.label6_Click);
            // 
            // LBL_consultation_min
            // 
            this.LBL_consultation_min.AutoSize = true;
            this.LBL_consultation_min.Location = new System.Drawing.Point(6, 16);
            this.LBL_consultation_min.Name = "LBL_consultation_min";
            this.LBL_consultation_min.Size = new System.Drawing.Size(26, 13);
            this.LBL_consultation_min.TabIndex = 3;
            this.LBL_consultation_min.Text = "Mini";
            this.LBL_consultation_min.Click += new System.EventHandler(this.LBL_consultation_min_Click);
            // 
            // TXT_Prix
            // 
            this.TXT_Prix.Enabled = false;
            this.TXT_Prix.Location = new System.Drawing.Point(38, 66);
            this.TXT_Prix.Name = "TXT_Prix";
            this.TXT_Prix.Size = new System.Drawing.Size(100, 20);
            this.TXT_Prix.TabIndex = 2;
            this.TXT_Prix.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // TXT_Maxi
            // 
            this.TXT_Maxi.Enabled = false;
            this.TXT_Maxi.Location = new System.Drawing.Point(38, 40);
            this.TXT_Maxi.Name = "TXT_Maxi";
            this.TXT_Maxi.Size = new System.Drawing.Size(100, 20);
            this.TXT_Maxi.TabIndex = 1;
            this.TXT_Maxi.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // TXT_Mini
            // 
            this.TXT_Mini.Enabled = false;
            this.TXT_Mini.Location = new System.Drawing.Point(38, 13);
            this.TXT_Mini.Name = "TXT_Mini";
            this.TXT_Mini.Size = new System.Drawing.Size(100, 20);
            this.TXT_Mini.TabIndex = 0;
            this.TXT_Mini.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // LBL_consultation_commentaire
            // 
            this.LBL_consultation_commentaire.AutoSize = true;
            this.LBL_consultation_commentaire.Location = new System.Drawing.Point(15, 168);
            this.LBL_consultation_commentaire.Name = "LBL_consultation_commentaire";
            this.LBL_consultation_commentaire.Size = new System.Drawing.Size(68, 13);
            this.LBL_consultation_commentaire.TabIndex = 4;
            this.LBL_consultation_commentaire.Text = "Commentaire";
            this.LBL_consultation_commentaire.Click += new System.EventHandler(this.LBL_consultation_commentaire_Click);
            // 
            // TXT_Commentaire
            // 
            this.TXT_Commentaire.Location = new System.Drawing.Point(89, 138);
            this.TXT_Commentaire.Name = "TXT_Commentaire";
            this.TXT_Commentaire.Size = new System.Drawing.Size(645, 75);
            this.TXT_Commentaire.TabIndex = 5;
            this.TXT_Commentaire.Text = "";
            this.TXT_Commentaire.TextChanged += new System.EventHandler(this.LargeTXT_consultation_commentaire_TextChanged);
            // 
            // EcranConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 581);
            this.Controls.Add(this.BTN_DossierMedical);
            this.Controls.Add(this.BTN_AnnulerConsu);
            this.Controls.Add(this.TXT_Commentaire);
            this.Controls.Add(this.BTN_ValiderConsu);
            this.Controls.Add(this.LBL_consultation_commentaire);
            this.Controls.Add(this.groupBox_consultation_actes);
            this.Controls.Add(this.groupBox_consultation_animal);
            this.Name = "EcranConsultation";
            this.Text = "Consultation";
            this.groupBox_consultation_animal.ResumeLayout(false);
            this.groupBox_consultation_animal.PerformLayout();
            this.groupBox_consultation_actes.ResumeLayout(false);
            this.groupBox_consultation_actes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_LigneConsu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_consultation_animal;
        private System.Windows.Forms.GroupBox groupBox_consultation_actes;
        private System.Windows.Forms.Button BTN_AnnulerConsu;
        private System.Windows.Forms.Button BTN_ValiderConsu;
        private System.Windows.Forms.Button BTN_DossierMedical;
        private System.Windows.Forms.TextBox TXT_Tatouage;
        private System.Windows.Forms.TextBox TXT_Sexe;
        private System.Windows.Forms.TextBox TXT_Race;
        private System.Windows.Forms.TextBox TXT_Couleur;
        private System.Windows.Forms.TextBox TXT_NomAnimal;
        private System.Windows.Forms.TextBox TXT_Espece;
        private System.Windows.Forms.TextBox TXT_CodeAnimal;
        private System.Windows.Forms.Label LBL_consultation_tatouage;
        private System.Windows.Forms.Label LBL_consultation_sexe;
        private System.Windows.Forms.Label LBL_consultation_couleur;
        private System.Windows.Forms.Label LBL_consultation_race;
        private System.Windows.Forms.Label LBL_consultation_nom;
        private System.Windows.Forms.Label LBL_consultation_espece;
        private System.Windows.Forms.Label LBL_consultation_code;
        private System.Windows.Forms.Label LBL_consultation_commentaire;
        private System.Windows.Forms.RichTextBox TXT_Commentaire;
        private System.Windows.Forms.DataGridView GRID_LigneConsu;
        private System.Windows.Forms.Label LBL_consulation_total;
        private System.Windows.Forms.TextBox TXT_Total;
        private System.Windows.Forms.ComboBox COMBO_TypeActe;
        private System.Windows.Forms.ComboBox COMBO_LibelleActe;
        private System.Windows.Forms.Label LBL_consultation_libelle;
        private System.Windows.Forms.Label LBL_consultation_type;
        private System.Windows.Forms.Label LBL_consultation_veterinaire;
        private System.Windows.Forms.Label LBL_consultation_dateActe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LBL_consultation_prix;
        private System.Windows.Forms.Label LBL_consultation_maxi;
        private System.Windows.Forms.Label LBL_consultation_min;
        private System.Windows.Forms.TextBox TXT_Prix;
        private System.Windows.Forms.TextBox TXT_Maxi;
        private System.Windows.Forms.TextBox TXT_Mini;
        private System.Windows.Forms.DateTimePicker DATE_Acte;
        private System.Windows.Forms.ComboBox COMBO_Veto;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Button BTN_Enregistrer;
        private System.Windows.Forms.Button BTN_AjouterActe;
        private System.Windows.Forms.Label LBL_NbActe;
    }
}