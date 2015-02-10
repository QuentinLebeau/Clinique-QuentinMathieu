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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_consultation_annuler = new System.Windows.Forms.Button();
            this.BTN_consultation_valider = new System.Windows.Forms.Button();
            this.BTN_consultation_DossierMedical = new System.Windows.Forms.Button();
            this.groupBox_consultation_animal = new System.Windows.Forms.GroupBox();
            this.TXT_consultation_tatouageAnimal = new System.Windows.Forms.TextBox();
            this.TXT_consultation_sexeAnimal = new System.Windows.Forms.TextBox();
            this.TXT_consultation_raceAnimal = new System.Windows.Forms.TextBox();
            this.TXT_consultation_couleurAnimal = new System.Windows.Forms.TextBox();
            this.TXT_consultation_nomAnimal = new System.Windows.Forms.TextBox();
            this.TXT_consultation_especeAnimal = new System.Windows.Forms.TextBox();
            this.TXT_consultation_codeAnimal = new System.Windows.Forms.TextBox();
            this.LBL_consultation_tatouage = new System.Windows.Forms.Label();
            this.LBL_consultation_sexe = new System.Windows.Forms.Label();
            this.LBL_consultation_couleur = new System.Windows.Forms.Label();
            this.LBL_consultation_race = new System.Windows.Forms.Label();
            this.LBL_consultation_nom = new System.Windows.Forms.Label();
            this.LBL_consultation_espece = new System.Windows.Forms.Label();
            this.LBL_consultation_code = new System.Windows.Forms.Label();
            this.groupBox_consultation_actes = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_consultation = new System.Windows.Forms.DataGridView();
            this.LBL_consulation_total = new System.Windows.Forms.Label();
            this.TXT_consultation_total = new System.Windows.Forms.TextBox();
            this.combo_consultation_type = new System.Windows.Forms.ComboBox();
            this.combo_consultation_libelle = new System.Windows.Forms.ComboBox();
            this.LBL_consultation_libelle = new System.Windows.Forms.Label();
            this.LBL_consultation_type = new System.Windows.Forms.Label();
            this.LBL_consultation_veterinaire = new System.Windows.Forms.Label();
            this.LBL_consultation_dateActe = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LBL_consultation_prix = new System.Windows.Forms.Label();
            this.LBL_consultation_maxi = new System.Windows.Forms.Label();
            this.LBL_consultation_min = new System.Windows.Forms.Label();
            this.TXT_consultation_prix = new System.Windows.Forms.TextBox();
            this.TXT_consultation_maxi = new System.Windows.Forms.TextBox();
            this.TXT_consultation_mini = new System.Windows.Forms.TextBox();
            this.TXT_consultation_veto = new System.Windows.Forms.TextBox();
            this.TXT_consultation_NbActes = new System.Windows.Forms.TextBox();
            this.LBL_consultation_commentaire = new System.Windows.Forms.Label();
            this.LargeTXT_consultation_commentaire = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox_consultation_animal.SuspendLayout();
            this.groupBox_consultation_actes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_consultation)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_consultation_annuler);
            this.groupBox1.Controls.Add(this.BTN_consultation_valider);
            this.groupBox1.Controls.Add(this.BTN_consultation_DossierMedical);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BTN_consultation_annuler
            // 
            this.BTN_consultation_annuler.Location = new System.Drawing.Point(426, 28);
            this.BTN_consultation_annuler.Name = "BTN_consultation_annuler";
            this.BTN_consultation_annuler.Size = new System.Drawing.Size(75, 23);
            this.BTN_consultation_annuler.TabIndex = 2;
            this.BTN_consultation_annuler.Text = "Annuler";
            this.BTN_consultation_annuler.UseVisualStyleBackColor = true;
            this.BTN_consultation_annuler.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTN_consultation_valider
            // 
            this.BTN_consultation_valider.Location = new System.Drawing.Point(257, 29);
            this.BTN_consultation_valider.Name = "BTN_consultation_valider";
            this.BTN_consultation_valider.Size = new System.Drawing.Size(75, 23);
            this.BTN_consultation_valider.TabIndex = 1;
            this.BTN_consultation_valider.Text = "Valider";
            this.BTN_consultation_valider.UseVisualStyleBackColor = true;
            this.BTN_consultation_valider.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_consultation_DossierMedical
            // 
            this.BTN_consultation_DossierMedical.Location = new System.Drawing.Point(21, 29);
            this.BTN_consultation_DossierMedical.Name = "BTN_consultation_DossierMedical";
            this.BTN_consultation_DossierMedical.Size = new System.Drawing.Size(144, 23);
            this.BTN_consultation_DossierMedical.TabIndex = 0;
            this.BTN_consultation_DossierMedical.Text = "Dossier medical";
            this.BTN_consultation_DossierMedical.UseVisualStyleBackColor = true;
            this.BTN_consultation_DossierMedical.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox_consultation_animal
            // 
            this.groupBox_consultation_animal.Controls.Add(this.TXT_consultation_tatouageAnimal);
            this.groupBox_consultation_animal.Controls.Add(this.TXT_consultation_sexeAnimal);
            this.groupBox_consultation_animal.Controls.Add(this.TXT_consultation_raceAnimal);
            this.groupBox_consultation_animal.Controls.Add(this.TXT_consultation_couleurAnimal);
            this.groupBox_consultation_animal.Controls.Add(this.TXT_consultation_nomAnimal);
            this.groupBox_consultation_animal.Controls.Add(this.TXT_consultation_especeAnimal);
            this.groupBox_consultation_animal.Controls.Add(this.TXT_consultation_codeAnimal);
            this.groupBox_consultation_animal.Controls.Add(this.LBL_consultation_tatouage);
            this.groupBox_consultation_animal.Controls.Add(this.LBL_consultation_sexe);
            this.groupBox_consultation_animal.Controls.Add(this.LBL_consultation_couleur);
            this.groupBox_consultation_animal.Controls.Add(this.LBL_consultation_race);
            this.groupBox_consultation_animal.Controls.Add(this.LBL_consultation_nom);
            this.groupBox_consultation_animal.Controls.Add(this.LBL_consultation_espece);
            this.groupBox_consultation_animal.Controls.Add(this.LBL_consultation_code);
            this.groupBox_consultation_animal.Location = new System.Drawing.Point(12, 107);
            this.groupBox_consultation_animal.Name = "groupBox_consultation_animal";
            this.groupBox_consultation_animal.Size = new System.Drawing.Size(649, 118);
            this.groupBox_consultation_animal.TabIndex = 1;
            this.groupBox_consultation_animal.TabStop = false;
            this.groupBox_consultation_animal.Text = "Animal";
            this.groupBox_consultation_animal.Enter += new System.EventHandler(this.groupBox_consultation_animal_Enter);
            // 
            // TXT_consultation_tatouageAnimal
            // 
            this.TXT_consultation_tatouageAnimal.Enabled = false;
            this.TXT_consultation_tatouageAnimal.Location = new System.Drawing.Point(231, 89);
            this.TXT_consultation_tatouageAnimal.Name = "TXT_consultation_tatouageAnimal";
            this.TXT_consultation_tatouageAnimal.Size = new System.Drawing.Size(100, 20);
            this.TXT_consultation_tatouageAnimal.TabIndex = 13;
            this.TXT_consultation_tatouageAnimal.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // TXT_consultation_sexeAnimal
            // 
            this.TXT_consultation_sexeAnimal.Enabled = false;
            this.TXT_consultation_sexeAnimal.Location = new System.Drawing.Point(543, 56);
            this.TXT_consultation_sexeAnimal.Name = "TXT_consultation_sexeAnimal";
            this.TXT_consultation_sexeAnimal.Size = new System.Drawing.Size(100, 20);
            this.TXT_consultation_sexeAnimal.TabIndex = 12;
            this.TXT_consultation_sexeAnimal.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // TXT_consultation_raceAnimal
            // 
            this.TXT_consultation_raceAnimal.Enabled = false;
            this.TXT_consultation_raceAnimal.Location = new System.Drawing.Point(390, 56);
            this.TXT_consultation_raceAnimal.Name = "TXT_consultation_raceAnimal";
            this.TXT_consultation_raceAnimal.Size = new System.Drawing.Size(100, 20);
            this.TXT_consultation_raceAnimal.TabIndex = 11;
            this.TXT_consultation_raceAnimal.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // TXT_consultation_couleurAnimal
            // 
            this.TXT_consultation_couleurAnimal.Enabled = false;
            this.TXT_consultation_couleurAnimal.Location = new System.Drawing.Point(390, 25);
            this.TXT_consultation_couleurAnimal.Name = "TXT_consultation_couleurAnimal";
            this.TXT_consultation_couleurAnimal.Size = new System.Drawing.Size(100, 20);
            this.TXT_consultation_couleurAnimal.TabIndex = 10;
            this.TXT_consultation_couleurAnimal.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // TXT_consultation_nomAnimal
            // 
            this.TXT_consultation_nomAnimal.Enabled = false;
            this.TXT_consultation_nomAnimal.Location = new System.Drawing.Point(213, 25);
            this.TXT_consultation_nomAnimal.Name = "TXT_consultation_nomAnimal";
            this.TXT_consultation_nomAnimal.Size = new System.Drawing.Size(100, 20);
            this.TXT_consultation_nomAnimal.TabIndex = 9;
            this.TXT_consultation_nomAnimal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TXT_consultation_especeAnimal
            // 
            this.TXT_consultation_especeAnimal.Enabled = false;
            this.TXT_consultation_especeAnimal.Location = new System.Drawing.Point(213, 56);
            this.TXT_consultation_especeAnimal.Name = "TXT_consultation_especeAnimal";
            this.TXT_consultation_especeAnimal.Size = new System.Drawing.Size(100, 20);
            this.TXT_consultation_especeAnimal.TabIndex = 8;
            this.TXT_consultation_especeAnimal.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TXT_consultation_codeAnimal
            // 
            this.TXT_consultation_codeAnimal.Enabled = false;
            this.TXT_consultation_codeAnimal.Location = new System.Drawing.Point(65, 26);
            this.TXT_consultation_codeAnimal.Name = "TXT_consultation_codeAnimal";
            this.TXT_consultation_codeAnimal.Size = new System.Drawing.Size(100, 20);
            this.TXT_consultation_codeAnimal.TabIndex = 7;
            this.TXT_consultation_codeAnimal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LBL_consultation_tatouage
            // 
            this.LBL_consultation_tatouage.AutoSize = true;
            this.LBL_consultation_tatouage.Location = new System.Drawing.Point(172, 92);
            this.LBL_consultation_tatouage.Name = "LBL_consultation_tatouage";
            this.LBL_consultation_tatouage.Size = new System.Drawing.Size(53, 13);
            this.LBL_consultation_tatouage.TabIndex = 6;
            this.LBL_consultation_tatouage.Text = "Tatouage";
            this.LBL_consultation_tatouage.Click += new System.EventHandler(this.LBL_consultation_tatouage_Click);
            // 
            // LBL_consultation_sexe
            // 
            this.LBL_consultation_sexe.AutoSize = true;
            this.LBL_consultation_sexe.Location = new System.Drawing.Point(502, 59);
            this.LBL_consultation_sexe.Name = "LBL_consultation_sexe";
            this.LBL_consultation_sexe.Size = new System.Drawing.Size(31, 13);
            this.LBL_consultation_sexe.TabIndex = 5;
            this.LBL_consultation_sexe.Text = "Sexe";
            this.LBL_consultation_sexe.Click += new System.EventHandler(this.LBL_consultation_sexe_Click);
            // 
            // LBL_consultation_couleur
            // 
            this.LBL_consultation_couleur.AutoSize = true;
            this.LBL_consultation_couleur.Location = new System.Drawing.Point(340, 29);
            this.LBL_consultation_couleur.Name = "LBL_consultation_couleur";
            this.LBL_consultation_couleur.Size = new System.Drawing.Size(43, 13);
            this.LBL_consultation_couleur.TabIndex = 4;
            this.LBL_consultation_couleur.Text = "Couleur";
            this.LBL_consultation_couleur.Click += new System.EventHandler(this.LBL_consultation_couleur_Click);
            // 
            // LBL_consultation_race
            // 
            this.LBL_consultation_race.AutoSize = true;
            this.LBL_consultation_race.Location = new System.Drawing.Point(340, 59);
            this.LBL_consultation_race.Name = "LBL_consultation_race";
            this.LBL_consultation_race.Size = new System.Drawing.Size(33, 13);
            this.LBL_consultation_race.TabIndex = 3;
            this.LBL_consultation_race.Text = "Race";
            this.LBL_consultation_race.Click += new System.EventHandler(this.LBL_consultation_race_Click);
            // 
            // LBL_consultation_nom
            // 
            this.LBL_consultation_nom.AutoSize = true;
            this.LBL_consultation_nom.Location = new System.Drawing.Point(171, 28);
            this.LBL_consultation_nom.Name = "LBL_consultation_nom";
            this.LBL_consultation_nom.Size = new System.Drawing.Size(29, 13);
            this.LBL_consultation_nom.TabIndex = 2;
            this.LBL_consultation_nom.Text = "Nom";
            this.LBL_consultation_nom.Click += new System.EventHandler(this.LBL_consultation_nom_Click);
            // 
            // LBL_consultation_espece
            // 
            this.LBL_consultation_espece.AutoSize = true;
            this.LBL_consultation_espece.Location = new System.Drawing.Point(172, 59);
            this.LBL_consultation_espece.Name = "LBL_consultation_espece";
            this.LBL_consultation_espece.Size = new System.Drawing.Size(43, 13);
            this.LBL_consultation_espece.TabIndex = 1;
            this.LBL_consultation_espece.Text = "Espèce";
            this.LBL_consultation_espece.Click += new System.EventHandler(this.LBL_consultation_espece_Click);
            // 
            // LBL_consultation_code
            // 
            this.LBL_consultation_code.AutoSize = true;
            this.LBL_consultation_code.Location = new System.Drawing.Point(24, 29);
            this.LBL_consultation_code.Name = "LBL_consultation_code";
            this.LBL_consultation_code.Size = new System.Drawing.Size(32, 13);
            this.LBL_consultation_code.TabIndex = 0;
            this.LBL_consultation_code.Text = "Code";
            this.LBL_consultation_code.Click += new System.EventHandler(this.LBL_consultation_code_Click);
            // 
            // groupBox_consultation_actes
            // 
            this.groupBox_consultation_actes.Controls.Add(this.dateTimePicker1);
            this.groupBox_consultation_actes.Controls.Add(this.dataGridView_consultation);
            this.groupBox_consultation_actes.Controls.Add(this.LBL_consulation_total);
            this.groupBox_consultation_actes.Controls.Add(this.TXT_consultation_total);
            this.groupBox_consultation_actes.Controls.Add(this.combo_consultation_type);
            this.groupBox_consultation_actes.Controls.Add(this.combo_consultation_libelle);
            this.groupBox_consultation_actes.Controls.Add(this.LBL_consultation_libelle);
            this.groupBox_consultation_actes.Controls.Add(this.LBL_consultation_type);
            this.groupBox_consultation_actes.Controls.Add(this.LBL_consultation_veterinaire);
            this.groupBox_consultation_actes.Controls.Add(this.LBL_consultation_dateActe);
            this.groupBox_consultation_actes.Controls.Add(this.groupBox2);
            this.groupBox_consultation_actes.Controls.Add(this.TXT_consultation_veto);
            this.groupBox_consultation_actes.Controls.Add(this.TXT_consultation_NbActes);
            this.groupBox_consultation_actes.Location = new System.Drawing.Point(12, 319);
            this.groupBox_consultation_actes.Name = "groupBox_consultation_actes";
            this.groupBox_consultation_actes.Size = new System.Drawing.Size(722, 250);
            this.groupBox_consultation_actes.TabIndex = 3;
            this.groupBox_consultation_actes.TabStop = false;
            this.groupBox_consultation_actes.Text = "Actes";
            this.groupBox_consultation_actes.Enter += new System.EventHandler(this.groupBox_consultation_actes_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView_consultation
            // 
            this.dataGridView_consultation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_consultation.Location = new System.Drawing.Point(6, 113);
            this.dataGridView_consultation.Name = "dataGridView_consultation";
            this.dataGridView_consultation.Size = new System.Drawing.Size(465, 127);
            this.dataGridView_consultation.TabIndex = 12;
            this.dataGridView_consultation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LBL_consulation_total
            // 
            this.LBL_consulation_total.AutoSize = true;
            this.LBL_consulation_total.Location = new System.Drawing.Point(474, 227);
            this.LBL_consulation_total.Name = "LBL_consulation_total";
            this.LBL_consulation_total.Size = new System.Drawing.Size(91, 13);
            this.LBL_consulation_total.TabIndex = 11;
            this.LBL_consulation_total.Text = "Total consultation";
            this.LBL_consulation_total.Click += new System.EventHandler(this.label8_Click);
            // 
            // TXT_consultation_total
            // 
            this.TXT_consultation_total.Enabled = false;
            this.TXT_consultation_total.Location = new System.Drawing.Point(571, 224);
            this.TXT_consultation_total.Name = "TXT_consultation_total";
            this.TXT_consultation_total.Size = new System.Drawing.Size(100, 20);
            this.TXT_consultation_total.TabIndex = 10;
            this.TXT_consultation_total.TextChanged += new System.EventHandler(this.TXT_consultation_total_TextChanged);
            // 
            // combo_consultation_type
            // 
            this.combo_consultation_type.FormattingEnabled = true;
            this.combo_consultation_type.Location = new System.Drawing.Point(69, 83);
            this.combo_consultation_type.Name = "combo_consultation_type";
            this.combo_consultation_type.Size = new System.Drawing.Size(121, 21);
            this.combo_consultation_type.TabIndex = 9;
            this.combo_consultation_type.SelectedIndexChanged += new System.EventHandler(this.combo_consultation_type_SelectedIndexChanged);
            // 
            // combo_consultation_libelle
            // 
            this.combo_consultation_libelle.FormattingEnabled = true;
            this.combo_consultation_libelle.Location = new System.Drawing.Point(244, 83);
            this.combo_consultation_libelle.Name = "combo_consultation_libelle";
            this.combo_consultation_libelle.Size = new System.Drawing.Size(121, 21);
            this.combo_consultation_libelle.TabIndex = 8;
            this.combo_consultation_libelle.SelectedIndexChanged += new System.EventHandler(this.combo_consultation_libelle_SelectedIndexChanged);
            // 
            // LBL_consultation_libelle
            // 
            this.LBL_consultation_libelle.AutoSize = true;
            this.LBL_consultation_libelle.Location = new System.Drawing.Point(196, 89);
            this.LBL_consultation_libelle.Name = "LBL_consultation_libelle";
            this.LBL_consultation_libelle.Size = new System.Drawing.Size(37, 13);
            this.LBL_consultation_libelle.TabIndex = 7;
            this.LBL_consultation_libelle.Text = "Libellé";
            this.LBL_consultation_libelle.Click += new System.EventHandler(this.LBL_consultation_libelle_Click);
            // 
            // LBL_consultation_type
            // 
            this.LBL_consultation_type.AutoSize = true;
            this.LBL_consultation_type.Location = new System.Drawing.Point(27, 89);
            this.LBL_consultation_type.Name = "LBL_consultation_type";
            this.LBL_consultation_type.Size = new System.Drawing.Size(31, 13);
            this.LBL_consultation_type.TabIndex = 6;
            this.LBL_consultation_type.Text = "Type";
            this.LBL_consultation_type.Click += new System.EventHandler(this.LBL_consultation_type_Click);
            // 
            // LBL_consultation_veterinaire
            // 
            this.LBL_consultation_veterinaire.AutoSize = true;
            this.LBL_consultation_veterinaire.Location = new System.Drawing.Point(297, 39);
            this.LBL_consultation_veterinaire.Name = "LBL_consultation_veterinaire";
            this.LBL_consultation_veterinaire.Size = new System.Drawing.Size(57, 13);
            this.LBL_consultation_veterinaire.TabIndex = 5;
            this.LBL_consultation_veterinaire.Text = "Vétérinaire";
            this.LBL_consultation_veterinaire.Click += new System.EventHandler(this.LBL_consultation_veterinaire_Click);
            // 
            // LBL_consultation_dateActe
            // 
            this.LBL_consultation_dateActe.AutoSize = true;
            this.LBL_consultation_dateActe.Location = new System.Drawing.Point(24, 39);
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
            this.groupBox2.Controls.Add(this.TXT_consultation_prix);
            this.groupBox2.Controls.Add(this.TXT_consultation_maxi);
            this.groupBox2.Controls.Add(this.TXT_consultation_mini);
            this.groupBox2.Location = new System.Drawing.Point(498, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // LBL_consultation_prix
            // 
            this.LBL_consultation_prix.AutoSize = true;
            this.LBL_consultation_prix.Location = new System.Drawing.Point(32, 77);
            this.LBL_consultation_prix.Name = "LBL_consultation_prix";
            this.LBL_consultation_prix.Size = new System.Drawing.Size(24, 13);
            this.LBL_consultation_prix.TabIndex = 5;
            this.LBL_consultation_prix.Text = "Prix";
            this.LBL_consultation_prix.Click += new System.EventHandler(this.label7_Click);
            // 
            // LBL_consultation_maxi
            // 
            this.LBL_consultation_maxi.AutoSize = true;
            this.LBL_consultation_maxi.Location = new System.Drawing.Point(32, 51);
            this.LBL_consultation_maxi.Name = "LBL_consultation_maxi";
            this.LBL_consultation_maxi.Size = new System.Drawing.Size(29, 13);
            this.LBL_consultation_maxi.TabIndex = 4;
            this.LBL_consultation_maxi.Text = "Maxi";
            this.LBL_consultation_maxi.Click += new System.EventHandler(this.label6_Click);
            // 
            // LBL_consultation_min
            // 
            this.LBL_consultation_min.AutoSize = true;
            this.LBL_consultation_min.Location = new System.Drawing.Point(32, 24);
            this.LBL_consultation_min.Name = "LBL_consultation_min";
            this.LBL_consultation_min.Size = new System.Drawing.Size(26, 13);
            this.LBL_consultation_min.TabIndex = 3;
            this.LBL_consultation_min.Text = "Mini";
            this.LBL_consultation_min.Click += new System.EventHandler(this.LBL_consultation_min_Click);
            // 
            // TXT_consultation_prix
            // 
            this.TXT_consultation_prix.Enabled = false;
            this.TXT_consultation_prix.Location = new System.Drawing.Point(106, 74);
            this.TXT_consultation_prix.Name = "TXT_consultation_prix";
            this.TXT_consultation_prix.Size = new System.Drawing.Size(100, 20);
            this.TXT_consultation_prix.TabIndex = 2;
            this.TXT_consultation_prix.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // TXT_consultation_maxi
            // 
            this.TXT_consultation_maxi.Enabled = false;
            this.TXT_consultation_maxi.Location = new System.Drawing.Point(106, 48);
            this.TXT_consultation_maxi.Name = "TXT_consultation_maxi";
            this.TXT_consultation_maxi.Size = new System.Drawing.Size(100, 20);
            this.TXT_consultation_maxi.TabIndex = 1;
            this.TXT_consultation_maxi.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // TXT_consultation_mini
            // 
            this.TXT_consultation_mini.Enabled = false;
            this.TXT_consultation_mini.Location = new System.Drawing.Point(106, 21);
            this.TXT_consultation_mini.Name = "TXT_consultation_mini";
            this.TXT_consultation_mini.Size = new System.Drawing.Size(100, 20);
            this.TXT_consultation_mini.TabIndex = 0;
            this.TXT_consultation_mini.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // TXT_consultation_veto
            // 
            this.TXT_consultation_veto.Enabled = false;
            this.TXT_consultation_veto.Location = new System.Drawing.Point(371, 33);
            this.TXT_consultation_veto.Name = "TXT_consultation_veto";
            this.TXT_consultation_veto.Size = new System.Drawing.Size(100, 20);
            this.TXT_consultation_veto.TabIndex = 2;
            this.TXT_consultation_veto.TextChanged += new System.EventHandler(this.TXT_consultation_veto_TextChanged);
            // 
            // TXT_consultation_NbActes
            // 
            this.TXT_consultation_NbActes.Enabled = false;
            this.TXT_consultation_NbActes.Location = new System.Drawing.Point(90, 0);
            this.TXT_consultation_NbActes.Name = "TXT_consultation_NbActes";
            this.TXT_consultation_NbActes.Size = new System.Drawing.Size(100, 20);
            this.TXT_consultation_NbActes.TabIndex = 0;
            this.TXT_consultation_NbActes.TextChanged += new System.EventHandler(this.TXT_consultation_NbActes_TextChanged);
            // 
            // LBL_consultation_commentaire
            // 
            this.LBL_consultation_commentaire.AutoSize = true;
            this.LBL_consultation_commentaire.Location = new System.Drawing.Point(36, 245);
            this.LBL_consultation_commentaire.Name = "LBL_consultation_commentaire";
            this.LBL_consultation_commentaire.Size = new System.Drawing.Size(68, 13);
            this.LBL_consultation_commentaire.TabIndex = 4;
            this.LBL_consultation_commentaire.Text = "Commentaire";
            this.LBL_consultation_commentaire.Click += new System.EventHandler(this.LBL_consultation_commentaire_Click);
            // 
            // LargeTXT_consultation_commentaire
            // 
            this.LargeTXT_consultation_commentaire.Location = new System.Drawing.Point(137, 231);
            this.LargeTXT_consultation_commentaire.Name = "LargeTXT_consultation_commentaire";
            this.LargeTXT_consultation_commentaire.Size = new System.Drawing.Size(524, 82);
            this.LargeTXT_consultation_commentaire.TabIndex = 5;
            this.LargeTXT_consultation_commentaire.Text = "";
            this.LargeTXT_consultation_commentaire.TextChanged += new System.EventHandler(this.LargeTXT_consultation_commentaire_TextChanged);
            // 
            // EcranConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 581);
            this.Controls.Add(this.LargeTXT_consultation_commentaire);
            this.Controls.Add(this.LBL_consultation_commentaire);
            this.Controls.Add(this.groupBox_consultation_actes);
            this.Controls.Add(this.groupBox_consultation_animal);
            this.Controls.Add(this.groupBox1);
            this.Name = "EcranConsultation";
            this.Text = "Consultation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox_consultation_animal.ResumeLayout(false);
            this.groupBox_consultation_animal.PerformLayout();
            this.groupBox_consultation_actes.ResumeLayout(false);
            this.groupBox_consultation_actes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_consultation)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_consultation_animal;
        private System.Windows.Forms.GroupBox groupBox_consultation_actes;
        private System.Windows.Forms.Button BTN_consultation_annuler;
        private System.Windows.Forms.Button BTN_consultation_valider;
        private System.Windows.Forms.Button BTN_consultation_DossierMedical;
        private System.Windows.Forms.TextBox TXT_consultation_tatouageAnimal;
        private System.Windows.Forms.TextBox TXT_consultation_sexeAnimal;
        private System.Windows.Forms.TextBox TXT_consultation_raceAnimal;
        private System.Windows.Forms.TextBox TXT_consultation_couleurAnimal;
        private System.Windows.Forms.TextBox TXT_consultation_nomAnimal;
        private System.Windows.Forms.TextBox TXT_consultation_especeAnimal;
        private System.Windows.Forms.TextBox TXT_consultation_codeAnimal;
        private System.Windows.Forms.Label LBL_consultation_tatouage;
        private System.Windows.Forms.Label LBL_consultation_sexe;
        private System.Windows.Forms.Label LBL_consultation_couleur;
        private System.Windows.Forms.Label LBL_consultation_race;
        private System.Windows.Forms.Label LBL_consultation_nom;
        private System.Windows.Forms.Label LBL_consultation_espece;
        private System.Windows.Forms.Label LBL_consultation_code;
        private System.Windows.Forms.Label LBL_consultation_commentaire;
        private System.Windows.Forms.RichTextBox LargeTXT_consultation_commentaire;
        private System.Windows.Forms.DataGridView dataGridView_consultation;
        private System.Windows.Forms.Label LBL_consulation_total;
        private System.Windows.Forms.TextBox TXT_consultation_total;
        private System.Windows.Forms.ComboBox combo_consultation_type;
        private System.Windows.Forms.ComboBox combo_consultation_libelle;
        private System.Windows.Forms.Label LBL_consultation_libelle;
        private System.Windows.Forms.Label LBL_consultation_type;
        private System.Windows.Forms.Label LBL_consultation_veterinaire;
        private System.Windows.Forms.Label LBL_consultation_dateActe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LBL_consultation_prix;
        private System.Windows.Forms.Label LBL_consultation_maxi;
        private System.Windows.Forms.Label LBL_consultation_min;
        private System.Windows.Forms.TextBox TXT_consultation_prix;
        private System.Windows.Forms.TextBox TXT_consultation_maxi;
        private System.Windows.Forms.TextBox TXT_consultation_mini;
        private System.Windows.Forms.TextBox TXT_consultation_veto;
        private System.Windows.Forms.TextBox TXT_consultation_NbActes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}