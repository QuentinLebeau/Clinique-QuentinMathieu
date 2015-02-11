namespace Clinique
{
    partial class EcranBaremes
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
            this.dataGridView_baremes = new System.Windows.Forms.DataGridView();
            this.LBL_baremes_codeGroupement = new System.Windows.Forms.Label();
            this.LBL_baremes_DateVigueur = new System.Windows.Forms.Label();
            this.LBL_baremes_TypeActe = new System.Windows.Forms.Label();
            this.LBL_baremes_libelle = new System.Windows.Forms.Label();
            this.LBL_baremes_tarifFixe = new System.Windows.Forms.Label();
            this.LBL_baremes_tarifMini = new System.Windows.Forms.Label();
            this.LBL_baremes_tarifMaxi = new System.Windows.Forms.Label();
            this.LBL_baremes_codeVaccin = new System.Windows.Forms.Label();
            this.TXT_baremes_codeGroupement = new System.Windows.Forms.TextBox();
            this.TXT_baremes_dateVigueur = new System.Windows.Forms.TextBox();
            this.TXT_baremes_libelle = new System.Windows.Forms.TextBox();
            this.TXT_baremes_typeActe = new System.Windows.Forms.TextBox();
            this.TXT_baremes_codeVaccin = new System.Windows.Forms.TextBox();
            this.TXT_baremes_tarifMaxi = new System.Windows.Forms.TextBox();
            this.TXT_baremes_tarifMini = new System.Windows.Forms.TextBox();
            this.TXT_baremes_tarifFixe = new System.Windows.Forms.TextBox();
            this.BTN_baremes_annuler = new System.Windows.Forms.Button();
            this.BTN_baremes_Modifier = new System.Windows.Forms.Button();
            this.groupBoxBaremesModif = new System.Windows.Forms.GroupBox();
            this.BTN_bareme_supprimer = new System.Windows.Forms.Button();
            this.BTN_baremeAjout_ajouterBareme = new System.Windows.Forms.Button();
            this.GroupBoxAjoutBareme = new System.Windows.Forms.GroupBox();
            this.BTN_baremesAjout_ajout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_baremesAjout_tarifFixe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_baremesAjout_tarifMini = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_baremesAjout_tarifMaxi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_baremesAjout_codeVaccin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TXT_baremesAjout_dateVigueur = new System.Windows.Forms.TextBox();
            this.TXT_baremesAjout_codeGroupement = new System.Windows.Forms.TextBox();
            this.comboBox_baremeAjout_TypeAct = new System.Windows.Forms.ComboBox();
            this.comboBox_ajoutBareme_Libelle = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_baremes)).BeginInit();
            this.groupBoxBaremesModif.SuspendLayout();
            this.GroupBoxAjoutBareme.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_baremes
            // 
            this.dataGridView_baremes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_baremes.Location = new System.Drawing.Point(15, 12);
            this.dataGridView_baremes.Name = "dataGridView_baremes";
            this.dataGridView_baremes.Size = new System.Drawing.Size(724, 297);
            this.dataGridView_baremes.TabIndex = 0;
            this.dataGridView_baremes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_baremes_CellClick);
            // 
            // LBL_baremes_codeGroupement
            // 
            this.LBL_baremes_codeGroupement.AutoSize = true;
            this.LBL_baremes_codeGroupement.Location = new System.Drawing.Point(22, 21);
            this.LBL_baremes_codeGroupement.Name = "LBL_baremes_codeGroupement";
            this.LBL_baremes_codeGroupement.Size = new System.Drawing.Size(65, 13);
            this.LBL_baremes_codeGroupement.TabIndex = 1;
            this.LBL_baremes_codeGroupement.Text = "Groupement";
            // 
            // LBL_baremes_DateVigueur
            // 
            this.LBL_baremes_DateVigueur.AutoSize = true;
            this.LBL_baremes_DateVigueur.Location = new System.Drawing.Point(22, 47);
            this.LBL_baremes_DateVigueur.Name = "LBL_baremes_DateVigueur";
            this.LBL_baremes_DateVigueur.Size = new System.Drawing.Size(68, 13);
            this.LBL_baremes_DateVigueur.TabIndex = 2;
            this.LBL_baremes_DateVigueur.Text = "Date vigueur";
            // 
            // LBL_baremes_TypeActe
            // 
            this.LBL_baremes_TypeActe.AutoSize = true;
            this.LBL_baremes_TypeActe.Location = new System.Drawing.Point(22, 73);
            this.LBL_baremes_TypeActe.Name = "LBL_baremes_TypeActe";
            this.LBL_baremes_TypeActe.Size = new System.Drawing.Size(56, 13);
            this.LBL_baremes_TypeActe.TabIndex = 3;
            this.LBL_baremes_TypeActe.Text = "Type Acte";
            // 
            // LBL_baremes_libelle
            // 
            this.LBL_baremes_libelle.AutoSize = true;
            this.LBL_baremes_libelle.Location = new System.Drawing.Point(22, 99);
            this.LBL_baremes_libelle.Name = "LBL_baremes_libelle";
            this.LBL_baremes_libelle.Size = new System.Drawing.Size(37, 13);
            this.LBL_baremes_libelle.TabIndex = 4;
            this.LBL_baremes_libelle.Text = "Libelle";
            // 
            // LBL_baremes_tarifFixe
            // 
            this.LBL_baremes_tarifFixe.AutoSize = true;
            this.LBL_baremes_tarifFixe.Location = new System.Drawing.Point(199, 21);
            this.LBL_baremes_tarifFixe.Name = "LBL_baremes_tarifFixe";
            this.LBL_baremes_tarifFixe.Size = new System.Drawing.Size(47, 13);
            this.LBL_baremes_tarifFixe.TabIndex = 5;
            this.LBL_baremes_tarifFixe.Text = "Tarif fixe";
            // 
            // LBL_baremes_tarifMini
            // 
            this.LBL_baremes_tarifMini.AutoSize = true;
            this.LBL_baremes_tarifMini.Location = new System.Drawing.Point(199, 47);
            this.LBL_baremes_tarifMini.Name = "LBL_baremes_tarifMini";
            this.LBL_baremes_tarifMini.Size = new System.Drawing.Size(49, 13);
            this.LBL_baremes_tarifMini.TabIndex = 6;
            this.LBL_baremes_tarifMini.Text = "Tarif mini";
            // 
            // LBL_baremes_tarifMaxi
            // 
            this.LBL_baremes_tarifMaxi.AutoSize = true;
            this.LBL_baremes_tarifMaxi.Location = new System.Drawing.Point(199, 73);
            this.LBL_baremes_tarifMaxi.Name = "LBL_baremes_tarifMaxi";
            this.LBL_baremes_tarifMaxi.Size = new System.Drawing.Size(52, 13);
            this.LBL_baremes_tarifMaxi.TabIndex = 7;
            this.LBL_baremes_tarifMaxi.Text = "Tarif maxi";
            // 
            // LBL_baremes_codeVaccin
            // 
            this.LBL_baremes_codeVaccin.AutoSize = true;
            this.LBL_baremes_codeVaccin.Location = new System.Drawing.Point(199, 99);
            this.LBL_baremes_codeVaccin.Name = "LBL_baremes_codeVaccin";
            this.LBL_baremes_codeVaccin.Size = new System.Drawing.Size(67, 13);
            this.LBL_baremes_codeVaccin.TabIndex = 8;
            this.LBL_baremes_codeVaccin.Text = "Code vaccin";
            // 
            // TXT_baremes_codeGroupement
            // 
            this.TXT_baremes_codeGroupement.Location = new System.Drawing.Point(93, 18);
            this.TXT_baremes_codeGroupement.Name = "TXT_baremes_codeGroupement";
            this.TXT_baremes_codeGroupement.Size = new System.Drawing.Size(100, 20);
            this.TXT_baremes_codeGroupement.TabIndex = 9;
            // 
            // TXT_baremes_dateVigueur
            // 
            this.TXT_baremes_dateVigueur.Location = new System.Drawing.Point(93, 44);
            this.TXT_baremes_dateVigueur.Name = "TXT_baremes_dateVigueur";
            this.TXT_baremes_dateVigueur.Size = new System.Drawing.Size(100, 20);
            this.TXT_baremes_dateVigueur.TabIndex = 10;
            // 
            // TXT_baremes_libelle
            // 
            this.TXT_baremes_libelle.Location = new System.Drawing.Point(93, 96);
            this.TXT_baremes_libelle.Name = "TXT_baremes_libelle";
            this.TXT_baremes_libelle.Size = new System.Drawing.Size(100, 20);
            this.TXT_baremes_libelle.TabIndex = 12;
            // 
            // TXT_baremes_typeActe
            // 
            this.TXT_baremes_typeActe.Location = new System.Drawing.Point(93, 69);
            this.TXT_baremes_typeActe.Name = "TXT_baremes_typeActe";
            this.TXT_baremes_typeActe.Size = new System.Drawing.Size(100, 20);
            this.TXT_baremes_typeActe.TabIndex = 13;
            // 
            // TXT_baremes_codeVaccin
            // 
            this.TXT_baremes_codeVaccin.Location = new System.Drawing.Point(272, 96);
            this.TXT_baremes_codeVaccin.Name = "TXT_baremes_codeVaccin";
            this.TXT_baremes_codeVaccin.Size = new System.Drawing.Size(100, 20);
            this.TXT_baremes_codeVaccin.TabIndex = 14;
            // 
            // TXT_baremes_tarifMaxi
            // 
            this.TXT_baremes_tarifMaxi.Location = new System.Drawing.Point(272, 70);
            this.TXT_baremes_tarifMaxi.Name = "TXT_baremes_tarifMaxi";
            this.TXT_baremes_tarifMaxi.Size = new System.Drawing.Size(100, 20);
            this.TXT_baremes_tarifMaxi.TabIndex = 15;
            // 
            // TXT_baremes_tarifMini
            // 
            this.TXT_baremes_tarifMini.Location = new System.Drawing.Point(272, 44);
            this.TXT_baremes_tarifMini.Name = "TXT_baremes_tarifMini";
            this.TXT_baremes_tarifMini.Size = new System.Drawing.Size(100, 20);
            this.TXT_baremes_tarifMini.TabIndex = 16;
            // 
            // TXT_baremes_tarifFixe
            // 
            this.TXT_baremes_tarifFixe.Location = new System.Drawing.Point(272, 18);
            this.TXT_baremes_tarifFixe.Name = "TXT_baremes_tarifFixe";
            this.TXT_baremes_tarifFixe.Size = new System.Drawing.Size(100, 20);
            this.TXT_baremes_tarifFixe.TabIndex = 17;
            // 
            // BTN_baremes_annuler
            // 
            this.BTN_baremes_annuler.Location = new System.Drawing.Point(378, 44);
            this.BTN_baremes_annuler.Name = "BTN_baremes_annuler";
            this.BTN_baremes_annuler.Size = new System.Drawing.Size(75, 23);
            this.BTN_baremes_annuler.TabIndex = 18;
            this.BTN_baremes_annuler.Text = "Annuler";
            this.BTN_baremes_annuler.UseVisualStyleBackColor = true;
            // 
            // BTN_baremes_Modifier
            // 
            this.BTN_baremes_Modifier.Location = new System.Drawing.Point(378, 16);
            this.BTN_baremes_Modifier.Name = "BTN_baremes_Modifier";
            this.BTN_baremes_Modifier.Size = new System.Drawing.Size(75, 23);
            this.BTN_baremes_Modifier.TabIndex = 19;
            this.BTN_baremes_Modifier.Text = "Modifier";
            this.BTN_baremes_Modifier.UseVisualStyleBackColor = true;
            this.BTN_baremes_Modifier.Click += new System.EventHandler(this.BTN_baremes_Modifier_Click);
            // 
            // groupBoxBaremesModif
            // 
            this.groupBoxBaremesModif.Controls.Add(this.BTN_bareme_supprimer);
            this.groupBoxBaremesModif.Controls.Add(this.BTN_baremeAjout_ajouterBareme);
            this.groupBoxBaremesModif.Controls.Add(this.BTN_baremes_Modifier);
            this.groupBoxBaremesModif.Controls.Add(this.LBL_baremes_codeGroupement);
            this.groupBoxBaremesModif.Controls.Add(this.BTN_baremes_annuler);
            this.groupBoxBaremesModif.Controls.Add(this.LBL_baremes_DateVigueur);
            this.groupBoxBaremesModif.Controls.Add(this.TXT_baremes_tarifFixe);
            this.groupBoxBaremesModif.Controls.Add(this.LBL_baremes_TypeActe);
            this.groupBoxBaremesModif.Controls.Add(this.TXT_baremes_tarifMini);
            this.groupBoxBaremesModif.Controls.Add(this.LBL_baremes_libelle);
            this.groupBoxBaremesModif.Controls.Add(this.TXT_baremes_tarifMaxi);
            this.groupBoxBaremesModif.Controls.Add(this.LBL_baremes_tarifFixe);
            this.groupBoxBaremesModif.Controls.Add(this.TXT_baremes_codeVaccin);
            this.groupBoxBaremesModif.Controls.Add(this.LBL_baremes_tarifMini);
            this.groupBoxBaremesModif.Controls.Add(this.TXT_baremes_typeActe);
            this.groupBoxBaremesModif.Controls.Add(this.LBL_baremes_tarifMaxi);
            this.groupBoxBaremesModif.Controls.Add(this.TXT_baremes_libelle);
            this.groupBoxBaremesModif.Controls.Add(this.LBL_baremes_codeVaccin);
            this.groupBoxBaremesModif.Controls.Add(this.TXT_baremes_dateVigueur);
            this.groupBoxBaremesModif.Controls.Add(this.TXT_baremes_codeGroupement);
            this.groupBoxBaremesModif.Location = new System.Drawing.Point(15, 315);
            this.groupBoxBaremesModif.Name = "groupBoxBaremesModif";
            this.groupBoxBaremesModif.Size = new System.Drawing.Size(485, 140);
            this.groupBoxBaremesModif.TabIndex = 20;
            this.groupBoxBaremesModif.TabStop = false;
            // 
            // BTN_bareme_supprimer
            // 
            this.BTN_bareme_supprimer.Location = new System.Drawing.Point(378, 99);
            this.BTN_bareme_supprimer.Name = "BTN_bareme_supprimer";
            this.BTN_bareme_supprimer.Size = new System.Drawing.Size(75, 23);
            this.BTN_bareme_supprimer.TabIndex = 21;
            this.BTN_bareme_supprimer.Text = "Supprimer";
            this.BTN_bareme_supprimer.UseVisualStyleBackColor = true;
            this.BTN_bareme_supprimer.Click += new System.EventHandler(this.BTN_bareme_supprimer_Click);
            // 
            // BTN_baremeAjout_ajouterBareme
            // 
            this.BTN_baremeAjout_ajouterBareme.Location = new System.Drawing.Point(378, 73);
            this.BTN_baremeAjout_ajouterBareme.Name = "BTN_baremeAjout_ajouterBareme";
            this.BTN_baremeAjout_ajouterBareme.Size = new System.Drawing.Size(75, 23);
            this.BTN_baremeAjout_ajouterBareme.TabIndex = 20;
            this.BTN_baremeAjout_ajouterBareme.Text = "Ajouter";
            this.BTN_baremeAjout_ajouterBareme.UseVisualStyleBackColor = true;
            this.BTN_baremeAjout_ajouterBareme.Click += new System.EventHandler(this.BTN_baremeAjout_ajouterBareme_Click);
            // 
            // GroupBoxAjoutBareme
            // 
            this.GroupBoxAjoutBareme.Controls.Add(this.comboBox_ajoutBareme_Libelle);
            this.GroupBoxAjoutBareme.Controls.Add(this.BTN_baremesAjout_ajout);
            this.GroupBoxAjoutBareme.Controls.Add(this.comboBox_baremeAjout_TypeAct);
            this.GroupBoxAjoutBareme.Controls.Add(this.label1);
            this.GroupBoxAjoutBareme.Controls.Add(this.button2);
            this.GroupBoxAjoutBareme.Controls.Add(this.label2);
            this.GroupBoxAjoutBareme.Controls.Add(this.TXT_baremesAjout_tarifFixe);
            this.GroupBoxAjoutBareme.Controls.Add(this.label3);
            this.GroupBoxAjoutBareme.Controls.Add(this.TXT_baremesAjout_tarifMini);
            this.GroupBoxAjoutBareme.Controls.Add(this.label4);
            this.GroupBoxAjoutBareme.Controls.Add(this.TXT_baremesAjout_tarifMaxi);
            this.GroupBoxAjoutBareme.Controls.Add(this.label5);
            this.GroupBoxAjoutBareme.Controls.Add(this.TXT_baremesAjout_codeVaccin);
            this.GroupBoxAjoutBareme.Controls.Add(this.label6);
            this.GroupBoxAjoutBareme.Controls.Add(this.label7);
            this.GroupBoxAjoutBareme.Controls.Add(this.label8);
            this.GroupBoxAjoutBareme.Controls.Add(this.TXT_baremesAjout_dateVigueur);
            this.GroupBoxAjoutBareme.Controls.Add(this.TXT_baremesAjout_codeGroupement);
            this.GroupBoxAjoutBareme.Location = new System.Drawing.Point(15, 461);
            this.GroupBoxAjoutBareme.Name = "GroupBoxAjoutBareme";
            this.GroupBoxAjoutBareme.Size = new System.Drawing.Size(522, 133);
            this.GroupBoxAjoutBareme.TabIndex = 21;
            this.GroupBoxAjoutBareme.TabStop = false;
            this.GroupBoxAjoutBareme.Text = "Ajout d\'un bareme";
            // 
            // BTN_baremesAjout_ajout
            // 
            this.BTN_baremesAjout_ajout.Location = new System.Drawing.Point(441, 36);
            this.BTN_baremesAjout_ajout.Name = "BTN_baremesAjout_ajout";
            this.BTN_baremesAjout_ajout.Size = new System.Drawing.Size(75, 23);
            this.BTN_baremesAjout_ajout.TabIndex = 37;
            this.BTN_baremesAjout_ajout.Text = "Valider";
            this.BTN_baremesAjout_ajout.UseVisualStyleBackColor = true;
            this.BTN_baremesAjout_ajout.Click += new System.EventHandler(this.BTN_baremesAjout_ajout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Groupement";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(441, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Date vigueur";
            // 
            // TXT_baremesAjout_tarifFixe
            // 
            this.TXT_baremesAjout_tarifFixe.Location = new System.Drawing.Point(335, 17);
            this.TXT_baremesAjout_tarifFixe.Name = "TXT_baremesAjout_tarifFixe";
            this.TXT_baremesAjout_tarifFixe.Size = new System.Drawing.Size(100, 20);
            this.TXT_baremesAjout_tarifFixe.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Type Acte";
            // 
            // TXT_baremesAjout_tarifMini
            // 
            this.TXT_baremesAjout_tarifMini.Location = new System.Drawing.Point(335, 43);
            this.TXT_baremesAjout_tarifMini.Name = "TXT_baremesAjout_tarifMini";
            this.TXT_baremesAjout_tarifMini.Size = new System.Drawing.Size(100, 20);
            this.TXT_baremesAjout_tarifMini.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Libelle";
            // 
            // TXT_baremesAjout_tarifMaxi
            // 
            this.TXT_baremesAjout_tarifMaxi.Location = new System.Drawing.Point(335, 69);
            this.TXT_baremesAjout_tarifMaxi.Name = "TXT_baremesAjout_tarifMaxi";
            this.TXT_baremesAjout_tarifMaxi.Size = new System.Drawing.Size(100, 20);
            this.TXT_baremesAjout_tarifMaxi.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tarif fixe";
            // 
            // TXT_baremesAjout_codeVaccin
            // 
            this.TXT_baremesAjout_codeVaccin.Location = new System.Drawing.Point(335, 95);
            this.TXT_baremesAjout_codeVaccin.Name = "TXT_baremesAjout_codeVaccin";
            this.TXT_baremesAjout_codeVaccin.Size = new System.Drawing.Size(100, 20);
            this.TXT_baremesAjout_codeVaccin.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tarif mini";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Tarif maxi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Code vaccin";
            // 
            // TXT_baremesAjout_dateVigueur
            // 
            this.TXT_baremesAjout_dateVigueur.Location = new System.Drawing.Point(98, 43);
            this.TXT_baremesAjout_dateVigueur.Name = "TXT_baremesAjout_dateVigueur";
            this.TXT_baremesAjout_dateVigueur.Size = new System.Drawing.Size(100, 20);
            this.TXT_baremesAjout_dateVigueur.TabIndex = 29;
            // 
            // TXT_baremesAjout_codeGroupement
            // 
            this.TXT_baremesAjout_codeGroupement.Location = new System.Drawing.Point(98, 17);
            this.TXT_baremesAjout_codeGroupement.Name = "TXT_baremesAjout_codeGroupement";
            this.TXT_baremesAjout_codeGroupement.Size = new System.Drawing.Size(100, 20);
            this.TXT_baremesAjout_codeGroupement.TabIndex = 28;
            // 
            // comboBox_baremeAjout_TypeAct
            // 
            this.comboBox_baremeAjout_TypeAct.FormattingEnabled = true;
            this.comboBox_baremeAjout_TypeAct.Location = new System.Drawing.Point(93, 72);
            this.comboBox_baremeAjout_TypeAct.Name = "comboBox_baremeAjout_TypeAct";
            this.comboBox_baremeAjout_TypeAct.Size = new System.Drawing.Size(121, 21);
            this.comboBox_baremeAjout_TypeAct.TabIndex = 22;
            // 
            // comboBox_ajoutBareme_Libelle
            // 
            this.comboBox_ajoutBareme_Libelle.FormattingEnabled = true;
            this.comboBox_ajoutBareme_Libelle.Location = new System.Drawing.Point(93, 98);
            this.comboBox_ajoutBareme_Libelle.Name = "comboBox_ajoutBareme_Libelle";
            this.comboBox_ajoutBareme_Libelle.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ajoutBareme_Libelle.TabIndex = 23;
            // 
            // EcranBaremes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 597);
            this.Controls.Add(this.GroupBoxAjoutBareme);
            this.Controls.Add(this.groupBoxBaremesModif);
            this.Controls.Add(this.dataGridView_baremes);
            this.Name = "EcranBaremes";
            this.Text = "EcranBaremes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_baremes)).EndInit();
            this.groupBoxBaremesModif.ResumeLayout(false);
            this.groupBoxBaremesModif.PerformLayout();
            this.GroupBoxAjoutBareme.ResumeLayout(false);
            this.GroupBoxAjoutBareme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_baremes;
        private System.Windows.Forms.Label LBL_baremes_codeGroupement;
        private System.Windows.Forms.Label LBL_baremes_DateVigueur;
        private System.Windows.Forms.Label LBL_baremes_TypeActe;
        private System.Windows.Forms.Label LBL_baremes_libelle;
        private System.Windows.Forms.Label LBL_baremes_tarifFixe;
        private System.Windows.Forms.Label LBL_baremes_tarifMini;
        private System.Windows.Forms.Label LBL_baremes_tarifMaxi;
        private System.Windows.Forms.Label LBL_baremes_codeVaccin;
        private System.Windows.Forms.TextBox TXT_baremes_codeGroupement;
        private System.Windows.Forms.TextBox TXT_baremes_dateVigueur;
        private System.Windows.Forms.TextBox TXT_baremes_libelle;
        private System.Windows.Forms.TextBox TXT_baremes_typeActe;
        private System.Windows.Forms.TextBox TXT_baremes_codeVaccin;
        private System.Windows.Forms.TextBox TXT_baremes_tarifMaxi;
        private System.Windows.Forms.TextBox TXT_baremes_tarifMini;
        private System.Windows.Forms.TextBox TXT_baremes_tarifFixe;
        private System.Windows.Forms.Button BTN_baremes_annuler;
        private System.Windows.Forms.Button BTN_baremes_Modifier;
        private System.Windows.Forms.GroupBox groupBoxBaremesModif;
        private System.Windows.Forms.GroupBox GroupBoxAjoutBareme;
        private System.Windows.Forms.Button BTN_baremesAjout_ajout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_baremesAjout_tarifFixe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_baremesAjout_tarifMini;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_baremesAjout_tarifMaxi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_baremesAjout_codeVaccin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXT_baremesAjout_dateVigueur;
        private System.Windows.Forms.TextBox TXT_baremesAjout_codeGroupement;
        private System.Windows.Forms.Button BTN_baremeAjout_ajouterBareme;
        private System.Windows.Forms.Button BTN_bareme_supprimer;
        private System.Windows.Forms.ComboBox comboBox_ajoutBareme_Libelle;
        private System.Windows.Forms.ComboBox comboBox_baremeAjout_TypeAct;
    }
}