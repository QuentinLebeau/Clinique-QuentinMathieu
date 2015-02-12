namespace Clinique
{
    partial class EcranStockVaccin
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
            this.dataGridView_stockVaccins = new System.Windows.Forms.DataGridView();
            this.LBL_stock_nomVaccin = new System.Windows.Forms.Label();
            this.LBL_stock_fournisseur = new System.Windows.Forms.Label();
            this.LBL_stock_quantite = new System.Windows.Forms.Label();
            this.Combo_stock_fournisseur = new System.Windows.Forms.ComboBox();
            this.TXT_stock_nomVaccin = new System.Windows.Forms.TextBox();
            this.TXT_stock_quantite = new System.Windows.Forms.TextBox();
            this.BTN_sotck_modifier = new System.Windows.Forms.Button();
            this.BTN_stock_annuler = new System.Windows.Forms.Button();
            this.BTN_stockAjout_Ajouter = new System.Windows.Forms.Button();
            this.BTN_stockAjout_Annuler = new System.Windows.Forms.Button();
            this.LBL_stockAjout_nomVaccin = new System.Windows.Forms.Label();
            this.LBL_sotckAjout_quantiteVaccin = new System.Windows.Forms.Label();
            this.LBL_stockAjout_periodeValidite = new System.Windows.Forms.Label();
            this.textBox_NomVaccin = new System.Windows.Forms.TextBox();
            this.textBox_PeriodeValiditeVaccin = new System.Windows.Forms.TextBox();
            this.textBox_QuantiteVaccin = new System.Windows.Forms.TextBox();
            this.groupBox_stockAjout = new System.Windows.Forms.GroupBox();
            this.BTN_sotckAjout_AjouterVaccin = new System.Windows.Forms.Button();
            this.BTN_sotckAjout_AnnulerAjout = new System.Windows.Forms.Button();
            this.TXT_stockVaccin_dateValidite = new System.Windows.Forms.TextBox();
            this.LBL_stockVaccin_PeriodeValidite = new System.Windows.Forms.Label();
            this.BTN_Stock_Supprimer = new System.Windows.Forms.Button();
            this.TXT_stock_codeVaccin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockVaccins)).BeginInit();
            this.groupBox_stockAjout.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_stockVaccins
            // 
            this.dataGridView_stockVaccins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stockVaccins.Location = new System.Drawing.Point(5, 8);
            this.dataGridView_stockVaccins.Name = "dataGridView_stockVaccins";
            this.dataGridView_stockVaccins.Size = new System.Drawing.Size(406, 176);
            this.dataGridView_stockVaccins.TabIndex = 0;
            this.dataGridView_stockVaccins.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_stockVaccins_CellContentClick);
            // 
            // LBL_stock_nomVaccin
            // 
            this.LBL_stock_nomVaccin.AutoSize = true;
            this.LBL_stock_nomVaccin.Location = new System.Drawing.Point(7, 195);
            this.LBL_stock_nomVaccin.Name = "LBL_stock_nomVaccin";
            this.LBL_stock_nomVaccin.Size = new System.Drawing.Size(40, 13);
            this.LBL_stock_nomVaccin.TabIndex = 1;
            this.LBL_stock_nomVaccin.Text = "Vaccin";
            // 
            // LBL_stock_fournisseur
            // 
            this.LBL_stock_fournisseur.AutoSize = true;
            this.LBL_stock_fournisseur.Location = new System.Drawing.Point(212, 195);
            this.LBL_stock_fournisseur.Name = "LBL_stock_fournisseur";
            this.LBL_stock_fournisseur.Size = new System.Drawing.Size(61, 13);
            this.LBL_stock_fournisseur.TabIndex = 2;
            this.LBL_stock_fournisseur.Text = "Fournisseur";
            // 
            // LBL_stock_quantite
            // 
            this.LBL_stock_quantite.AutoSize = true;
            this.LBL_stock_quantite.Location = new System.Drawing.Point(-1, 220);
            this.LBL_stock_quantite.Name = "LBL_stock_quantite";
            this.LBL_stock_quantite.Size = new System.Drawing.Size(47, 13);
            this.LBL_stock_quantite.TabIndex = 3;
            this.LBL_stock_quantite.Text = "Quantite";
            // 
            // Combo_stock_fournisseur
            // 
            this.Combo_stock_fournisseur.FormattingEnabled = true;
            this.Combo_stock_fournisseur.Location = new System.Drawing.Point(283, 192);
            this.Combo_stock_fournisseur.Name = "Combo_stock_fournisseur";
            this.Combo_stock_fournisseur.Size = new System.Drawing.Size(128, 21);
            this.Combo_stock_fournisseur.TabIndex = 4;
            // 
            // TXT_stock_nomVaccin
            // 
            this.TXT_stock_nomVaccin.Location = new System.Drawing.Point(57, 192);
            this.TXT_stock_nomVaccin.Name = "TXT_stock_nomVaccin";
            this.TXT_stock_nomVaccin.Size = new System.Drawing.Size(128, 20);
            this.TXT_stock_nomVaccin.TabIndex = 5;
            // 
            // TXT_stock_quantite
            // 
            this.TXT_stock_quantite.Location = new System.Drawing.Point(56, 217);
            this.TXT_stock_quantite.Name = "TXT_stock_quantite";
            this.TXT_stock_quantite.Size = new System.Drawing.Size(128, 20);
            this.TXT_stock_quantite.TabIndex = 6;
            // 
            // BTN_sotck_modifier
            // 
            this.BTN_sotck_modifier.Location = new System.Drawing.Point(40, 267);
            this.BTN_sotck_modifier.Name = "BTN_sotck_modifier";
            this.BTN_sotck_modifier.Size = new System.Drawing.Size(107, 23);
            this.BTN_sotck_modifier.TabIndex = 7;
            this.BTN_sotck_modifier.Text = "Modifier";
            this.BTN_sotck_modifier.UseVisualStyleBackColor = true;
            this.BTN_sotck_modifier.Click += new System.EventHandler(this.BTN_sotck_modifier_Click);
            // 
            // BTN_stock_annuler
            // 
            this.BTN_stock_annuler.Location = new System.Drawing.Point(153, 267);
            this.BTN_stock_annuler.Name = "BTN_stock_annuler";
            this.BTN_stock_annuler.Size = new System.Drawing.Size(107, 23);
            this.BTN_stock_annuler.TabIndex = 8;
            this.BTN_stock_annuler.Text = "Annuler";
            this.BTN_stock_annuler.UseVisualStyleBackColor = true;
            this.BTN_stock_annuler.Click += new System.EventHandler(this.BTN_stock_annuler_Click);
            // 
            // BTN_stockAjout_Ajouter
            // 
            this.BTN_stockAjout_Ajouter.Location = new System.Drawing.Point(245, 33);
            this.BTN_stockAjout_Ajouter.Name = "BTN_stockAjout_Ajouter";
            this.BTN_stockAjout_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.BTN_stockAjout_Ajouter.TabIndex = 9;
            this.BTN_stockAjout_Ajouter.Text = "Ajouter";
            this.BTN_stockAjout_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_stockAjout_Ajouter.Click += new System.EventHandler(this.BTN_stockAjout_Ajouter_Click);
            // 
            // BTN_stockAjout_Annuler
            // 
            this.BTN_stockAjout_Annuler.Location = new System.Drawing.Point(245, 62);
            this.BTN_stockAjout_Annuler.Name = "BTN_stockAjout_Annuler";
            this.BTN_stockAjout_Annuler.Size = new System.Drawing.Size(75, 23);
            this.BTN_stockAjout_Annuler.TabIndex = 10;
            this.BTN_stockAjout_Annuler.Text = "Annuler";
            this.BTN_stockAjout_Annuler.UseVisualStyleBackColor = true;
            // 
            // LBL_stockAjout_nomVaccin
            // 
            this.LBL_stockAjout_nomVaccin.AutoSize = true;
            this.LBL_stockAjout_nomVaccin.Location = new System.Drawing.Point(48, 27);
            this.LBL_stockAjout_nomVaccin.Name = "LBL_stockAjout_nomVaccin";
            this.LBL_stockAjout_nomVaccin.Size = new System.Drawing.Size(40, 13);
            this.LBL_stockAjout_nomVaccin.TabIndex = 11;
            this.LBL_stockAjout_nomVaccin.Text = "Vaccin";
            // 
            // LBL_sotckAjout_quantiteVaccin
            // 
            this.LBL_sotckAjout_quantiteVaccin.AutoSize = true;
            this.LBL_sotckAjout_quantiteVaccin.Location = new System.Drawing.Point(41, 79);
            this.LBL_sotckAjout_quantiteVaccin.Name = "LBL_sotckAjout_quantiteVaccin";
            this.LBL_sotckAjout_quantiteVaccin.Size = new System.Drawing.Size(47, 13);
            this.LBL_sotckAjout_quantiteVaccin.TabIndex = 12;
            this.LBL_sotckAjout_quantiteVaccin.Text = "Quantite";
            // 
            // LBL_stockAjout_periodeValidite
            // 
            this.LBL_stockAjout_periodeValidite.AutoSize = true;
            this.LBL_stockAjout_periodeValidite.Location = new System.Drawing.Point(8, 52);
            this.LBL_stockAjout_periodeValidite.Name = "LBL_stockAjout_periodeValidite";
            this.LBL_stockAjout_periodeValidite.Size = new System.Drawing.Size(80, 13);
            this.LBL_stockAjout_periodeValidite.TabIndex = 13;
            this.LBL_stockAjout_periodeValidite.Text = "Periode Validite";
            // 
            // textBox_NomVaccin
            // 
            this.textBox_NomVaccin.Location = new System.Drawing.Point(102, 24);
            this.textBox_NomVaccin.Name = "textBox_NomVaccin";
            this.textBox_NomVaccin.Size = new System.Drawing.Size(128, 20);
            this.textBox_NomVaccin.TabIndex = 14;
            // 
            // textBox_PeriodeValiditeVaccin
            // 
            this.textBox_PeriodeValiditeVaccin.Location = new System.Drawing.Point(102, 49);
            this.textBox_PeriodeValiditeVaccin.Name = "textBox_PeriodeValiditeVaccin";
            this.textBox_PeriodeValiditeVaccin.Size = new System.Drawing.Size(128, 20);
            this.textBox_PeriodeValiditeVaccin.TabIndex = 15;
            // 
            // textBox_QuantiteVaccin
            // 
            this.textBox_QuantiteVaccin.Location = new System.Drawing.Point(102, 75);
            this.textBox_QuantiteVaccin.Name = "textBox_QuantiteVaccin";
            this.textBox_QuantiteVaccin.Size = new System.Drawing.Size(128, 20);
            this.textBox_QuantiteVaccin.TabIndex = 16;
            // 
            // groupBox_stockAjout
            // 
            this.groupBox_stockAjout.Controls.Add(this.BTN_stockAjout_Ajouter);
            this.groupBox_stockAjout.Controls.Add(this.BTN_stockAjout_Annuler);
            this.groupBox_stockAjout.Controls.Add(this.LBL_stockAjout_nomVaccin);
            this.groupBox_stockAjout.Controls.Add(this.textBox_QuantiteVaccin);
            this.groupBox_stockAjout.Controls.Add(this.LBL_sotckAjout_quantiteVaccin);
            this.groupBox_stockAjout.Controls.Add(this.textBox_PeriodeValiditeVaccin);
            this.groupBox_stockAjout.Controls.Add(this.LBL_stockAjout_periodeValidite);
            this.groupBox_stockAjout.Controls.Add(this.textBox_NomVaccin);
            this.groupBox_stockAjout.Location = new System.Drawing.Point(33, 355);
            this.groupBox_stockAjout.Name = "groupBox_stockAjout";
            this.groupBox_stockAjout.Size = new System.Drawing.Size(339, 113);
            this.groupBox_stockAjout.TabIndex = 19;
            this.groupBox_stockAjout.TabStop = false;
            this.groupBox_stockAjout.Text = "Ajout";
            // 
            // BTN_sotckAjout_AjouterVaccin
            // 
            this.BTN_sotckAjout_AjouterVaccin.Location = new System.Drawing.Point(93, 326);
            this.BTN_sotckAjout_AjouterVaccin.Name = "BTN_sotckAjout_AjouterVaccin";
            this.BTN_sotckAjout_AjouterVaccin.Size = new System.Drawing.Size(107, 23);
            this.BTN_sotckAjout_AjouterVaccin.TabIndex = 20;
            this.BTN_sotckAjout_AjouterVaccin.Text = "Ajouter Vaccin";
            this.BTN_sotckAjout_AjouterVaccin.UseVisualStyleBackColor = true;
            this.BTN_sotckAjout_AjouterVaccin.Click += new System.EventHandler(this.BTN_sotckAjout_AjouterVaccin_Click);
            // 
            // BTN_sotckAjout_AnnulerAjout
            // 
            this.BTN_sotckAjout_AnnulerAjout.Location = new System.Drawing.Point(206, 326);
            this.BTN_sotckAjout_AnnulerAjout.Name = "BTN_sotckAjout_AnnulerAjout";
            this.BTN_sotckAjout_AnnulerAjout.Size = new System.Drawing.Size(107, 23);
            this.BTN_sotckAjout_AnnulerAjout.TabIndex = 21;
            this.BTN_sotckAjout_AnnulerAjout.Text = "Annuler Ajout";
            this.BTN_sotckAjout_AnnulerAjout.UseVisualStyleBackColor = true;
            this.BTN_sotckAjout_AnnulerAjout.Click += new System.EventHandler(this.BTN_sotckAjout_AnnulerAjout_Click);
            // 
            // TXT_stockVaccin_dateValidite
            // 
            this.TXT_stockVaccin_dateValidite.Location = new System.Drawing.Point(283, 218);
            this.TXT_stockVaccin_dateValidite.Name = "TXT_stockVaccin_dateValidite";
            this.TXT_stockVaccin_dateValidite.Size = new System.Drawing.Size(128, 20);
            this.TXT_stockVaccin_dateValidite.TabIndex = 22;
            // 
            // LBL_stockVaccin_PeriodeValidite
            // 
            this.LBL_stockVaccin_PeriodeValidite.AutoSize = true;
            this.LBL_stockVaccin_PeriodeValidite.Location = new System.Drawing.Point(193, 221);
            this.LBL_stockVaccin_PeriodeValidite.Name = "LBL_stockVaccin_PeriodeValidite";
            this.LBL_stockVaccin_PeriodeValidite.Size = new System.Drawing.Size(80, 13);
            this.LBL_stockVaccin_PeriodeValidite.TabIndex = 23;
            this.LBL_stockVaccin_PeriodeValidite.Text = "Periode Validite";
            // 
            // BTN_Stock_Supprimer
            // 
            this.BTN_Stock_Supprimer.Location = new System.Drawing.Point(266, 267);
            this.BTN_Stock_Supprimer.Name = "BTN_Stock_Supprimer";
            this.BTN_Stock_Supprimer.Size = new System.Drawing.Size(106, 23);
            this.BTN_Stock_Supprimer.TabIndex = 24;
            this.BTN_Stock_Supprimer.Text = "Supprimer";
            this.BTN_Stock_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Stock_Supprimer.Click += new System.EventHandler(this.BTN_Stock_Supprimer_Click);
            // 
            // TXT_stock_codeVaccin
            // 
            this.TXT_stock_codeVaccin.Location = new System.Drawing.Point(181, 300);
            this.TXT_stock_codeVaccin.Name = "TXT_stock_codeVaccin";
            this.TXT_stock_codeVaccin.Size = new System.Drawing.Size(41, 20);
            this.TXT_stock_codeVaccin.TabIndex = 25;
            // 
            // EcranStockVaccin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 472);
            this.Controls.Add(this.TXT_stock_codeVaccin);
            this.Controls.Add(this.BTN_Stock_Supprimer);
            this.Controls.Add(this.LBL_stockVaccin_PeriodeValidite);
            this.Controls.Add(this.TXT_stockVaccin_dateValidite);
            this.Controls.Add(this.BTN_sotckAjout_AnnulerAjout);
            this.Controls.Add(this.BTN_sotckAjout_AjouterVaccin);
            this.Controls.Add(this.groupBox_stockAjout);
            this.Controls.Add(this.BTN_stock_annuler);
            this.Controls.Add(this.BTN_sotck_modifier);
            this.Controls.Add(this.TXT_stock_quantite);
            this.Controls.Add(this.TXT_stock_nomVaccin);
            this.Controls.Add(this.Combo_stock_fournisseur);
            this.Controls.Add(this.LBL_stock_quantite);
            this.Controls.Add(this.LBL_stock_fournisseur);
            this.Controls.Add(this.LBL_stock_nomVaccin);
            this.Controls.Add(this.dataGridView_stockVaccins);
            this.Name = "EcranStockVaccin";
            this.Text = "EcranStockVaccin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockVaccins)).EndInit();
            this.groupBox_stockAjout.ResumeLayout(false);
            this.groupBox_stockAjout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_stockVaccins;
        private System.Windows.Forms.Label LBL_stock_nomVaccin;
        private System.Windows.Forms.Label LBL_stock_fournisseur;
        private System.Windows.Forms.Label LBL_stock_quantite;
        private System.Windows.Forms.ComboBox Combo_stock_fournisseur;
        private System.Windows.Forms.TextBox TXT_stock_nomVaccin;
        private System.Windows.Forms.TextBox TXT_stock_quantite;
        private System.Windows.Forms.Button BTN_sotck_modifier;
        private System.Windows.Forms.Button BTN_stock_annuler;
        private System.Windows.Forms.Button BTN_stockAjout_Ajouter;
        private System.Windows.Forms.Button BTN_stockAjout_Annuler;
        private System.Windows.Forms.Label LBL_stockAjout_nomVaccin;
        private System.Windows.Forms.Label LBL_sotckAjout_quantiteVaccin;
        private System.Windows.Forms.Label LBL_stockAjout_periodeValidite;
        private System.Windows.Forms.TextBox textBox_NomVaccin;
        private System.Windows.Forms.TextBox textBox_PeriodeValiditeVaccin;
        private System.Windows.Forms.TextBox textBox_QuantiteVaccin;
        private System.Windows.Forms.GroupBox groupBox_stockAjout;
        private System.Windows.Forms.Button BTN_sotckAjout_AjouterVaccin;
        private System.Windows.Forms.Button BTN_sotckAjout_AnnulerAjout;
        private System.Windows.Forms.TextBox TXT_stockVaccin_dateValidite;
        private System.Windows.Forms.Label LBL_stockVaccin_PeriodeValidite;
        private System.Windows.Forms.Button BTN_Stock_Supprimer;
        private System.Windows.Forms.TextBox TXT_stock_codeVaccin;
    }
}