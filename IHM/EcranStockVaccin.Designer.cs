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
            this.BTN_sotck_ajouter = new System.Windows.Forms.Button();
            this.BTN_stock_annuler = new System.Windows.Forms.Button();
            this.BTN_stockAjout_Ajouter = new System.Windows.Forms.Button();
            this.BTN_stockAjout_Annuler = new System.Windows.Forms.Button();
            this.LBL_stockAjout_nomVaccin = new System.Windows.Forms.Label();
            this.LBL_sotckAjout_quantiteVaccin = new System.Windows.Forms.Label();
            this.LBL_stockAjout_periodeValidite = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LBL_stockAjout_Fournisseur = new System.Windows.Forms.Label();
            this.groupBox_stockAjout = new System.Windows.Forms.GroupBox();
            this.BTN_sotckAjout_AjouterVaccin = new System.Windows.Forms.Button();
            this.BTN_sotckAjout_AnnulerAjout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockVaccins)).BeginInit();
            this.groupBox_stockAjout.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_stockVaccins
            // 
            this.dataGridView_stockVaccins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stockVaccins.Location = new System.Drawing.Point(35, 13);
            this.dataGridView_stockVaccins.Name = "dataGridView_stockVaccins";
            this.dataGridView_stockVaccins.Size = new System.Drawing.Size(681, 176);
            this.dataGridView_stockVaccins.TabIndex = 0;
            this.dataGridView_stockVaccins.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_stockVaccins_CellContentClick);
            // 
            // LBL_stock_nomVaccin
            // 
            this.LBL_stock_nomVaccin.AutoSize = true;
            this.LBL_stock_nomVaccin.Location = new System.Drawing.Point(42, 234);
            this.LBL_stock_nomVaccin.Name = "LBL_stock_nomVaccin";
            this.LBL_stock_nomVaccin.Size = new System.Drawing.Size(40, 13);
            this.LBL_stock_nomVaccin.TabIndex = 1;
            this.LBL_stock_nomVaccin.Text = "Vaccin";
            // 
            // LBL_stock_fournisseur
            // 
            this.LBL_stock_fournisseur.AutoSize = true;
            this.LBL_stock_fournisseur.Location = new System.Drawing.Point(21, 289);
            this.LBL_stock_fournisseur.Name = "LBL_stock_fournisseur";
            this.LBL_stock_fournisseur.Size = new System.Drawing.Size(61, 13);
            this.LBL_stock_fournisseur.TabIndex = 2;
            this.LBL_stock_fournisseur.Text = "Fournisseur";
            // 
            // LBL_stock_quantite
            // 
            this.LBL_stock_quantite.AutoSize = true;
            this.LBL_stock_quantite.Location = new System.Drawing.Point(35, 263);
            this.LBL_stock_quantite.Name = "LBL_stock_quantite";
            this.LBL_stock_quantite.Size = new System.Drawing.Size(47, 13);
            this.LBL_stock_quantite.TabIndex = 3;
            this.LBL_stock_quantite.Text = "Quantite";
            // 
            // Combo_stock_fournisseur
            // 
            this.Combo_stock_fournisseur.FormattingEnabled = true;
            this.Combo_stock_fournisseur.Location = new System.Drawing.Point(92, 286);
            this.Combo_stock_fournisseur.Name = "Combo_stock_fournisseur";
            this.Combo_stock_fournisseur.Size = new System.Drawing.Size(128, 21);
            this.Combo_stock_fournisseur.TabIndex = 4;
            // 
            // TXT_stock_nomVaccin
            // 
            this.TXT_stock_nomVaccin.Location = new System.Drawing.Point(88, 231);
            this.TXT_stock_nomVaccin.Name = "TXT_stock_nomVaccin";
            this.TXT_stock_nomVaccin.Size = new System.Drawing.Size(132, 20);
            this.TXT_stock_nomVaccin.TabIndex = 5;
            // 
            // TXT_stock_quantite
            // 
            this.TXT_stock_quantite.Location = new System.Drawing.Point(92, 260);
            this.TXT_stock_quantite.Name = "TXT_stock_quantite";
            this.TXT_stock_quantite.Size = new System.Drawing.Size(128, 20);
            this.TXT_stock_quantite.TabIndex = 6;
            // 
            // BTN_sotck_ajouter
            // 
            this.BTN_sotck_ajouter.Location = new System.Drawing.Point(320, 229);
            this.BTN_sotck_ajouter.Name = "BTN_sotck_ajouter";
            this.BTN_sotck_ajouter.Size = new System.Drawing.Size(107, 23);
            this.BTN_sotck_ajouter.TabIndex = 7;
            this.BTN_sotck_ajouter.Text = "Valider";
            this.BTN_sotck_ajouter.UseVisualStyleBackColor = true;
            this.BTN_sotck_ajouter.Click += new System.EventHandler(this.BTN_sotck_ajouter_Click);
            // 
            // BTN_stock_annuler
            // 
            this.BTN_stock_annuler.Location = new System.Drawing.Point(433, 229);
            this.BTN_stock_annuler.Name = "BTN_stock_annuler";
            this.BTN_stock_annuler.Size = new System.Drawing.Size(107, 23);
            this.BTN_stock_annuler.TabIndex = 8;
            this.BTN_stock_annuler.Text = "Annuler";
            this.BTN_stock_annuler.UseVisualStyleBackColor = true;
            // 
            // BTN_stockAjout_Ajouter
            // 
            this.BTN_stockAjout_Ajouter.Location = new System.Drawing.Point(243, 75);
            this.BTN_stockAjout_Ajouter.Name = "BTN_stockAjout_Ajouter";
            this.BTN_stockAjout_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.BTN_stockAjout_Ajouter.TabIndex = 9;
            this.BTN_stockAjout_Ajouter.Text = "Ajouter";
            this.BTN_stockAjout_Ajouter.UseVisualStyleBackColor = true;
            // 
            // BTN_stockAjout_Annuler
            // 
            this.BTN_stockAjout_Annuler.Location = new System.Drawing.Point(243, 107);
            this.BTN_stockAjout_Annuler.Name = "BTN_stockAjout_Annuler";
            this.BTN_stockAjout_Annuler.Size = new System.Drawing.Size(75, 23);
            this.BTN_stockAjout_Annuler.TabIndex = 10;
            this.BTN_stockAjout_Annuler.Text = "Annuler";
            this.BTN_stockAjout_Annuler.UseVisualStyleBackColor = true;
            // 
            // LBL_stockAjout_nomVaccin
            // 
            this.LBL_stockAjout_nomVaccin.AutoSize = true;
            this.LBL_stockAjout_nomVaccin.Location = new System.Drawing.Point(45, 33);
            this.LBL_stockAjout_nomVaccin.Name = "LBL_stockAjout_nomVaccin";
            this.LBL_stockAjout_nomVaccin.Size = new System.Drawing.Size(40, 13);
            this.LBL_stockAjout_nomVaccin.TabIndex = 11;
            this.LBL_stockAjout_nomVaccin.Text = "Vaccin";
            // 
            // LBL_sotckAjout_quantiteVaccin
            // 
            this.LBL_sotckAjout_quantiteVaccin.AutoSize = true;
            this.LBL_sotckAjout_quantiteVaccin.Location = new System.Drawing.Point(38, 58);
            this.LBL_sotckAjout_quantiteVaccin.Name = "LBL_sotckAjout_quantiteVaccin";
            this.LBL_sotckAjout_quantiteVaccin.Size = new System.Drawing.Size(47, 13);
            this.LBL_sotckAjout_quantiteVaccin.TabIndex = 12;
            this.LBL_sotckAjout_quantiteVaccin.Text = "Quantite";
            // 
            // LBL_stockAjout_periodeValidite
            // 
            this.LBL_stockAjout_periodeValidite.AutoSize = true;
            this.LBL_stockAjout_periodeValidite.Location = new System.Drawing.Point(5, 85);
            this.LBL_stockAjout_periodeValidite.Name = "LBL_stockAjout_periodeValidite";
            this.LBL_stockAjout_periodeValidite.Size = new System.Drawing.Size(80, 13);
            this.LBL_stockAjout_periodeValidite.TabIndex = 13;
            this.LBL_stockAjout_periodeValidite.Text = "Periode Validite";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(99, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 20);
            this.textBox3.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // LBL_stockAjout_Fournisseur
            // 
            this.LBL_stockAjout_Fournisseur.AutoSize = true;
            this.LBL_stockAjout_Fournisseur.Location = new System.Drawing.Point(24, 112);
            this.LBL_stockAjout_Fournisseur.Name = "LBL_stockAjout_Fournisseur";
            this.LBL_stockAjout_Fournisseur.Size = new System.Drawing.Size(61, 13);
            this.LBL_stockAjout_Fournisseur.TabIndex = 18;
            this.LBL_stockAjout_Fournisseur.Text = "Fournisseur";
            // 
            // groupBox_stockAjout
            // 
            this.groupBox_stockAjout.Controls.Add(this.BTN_stockAjout_Ajouter);
            this.groupBox_stockAjout.Controls.Add(this.LBL_stockAjout_Fournisseur);
            this.groupBox_stockAjout.Controls.Add(this.BTN_stockAjout_Annuler);
            this.groupBox_stockAjout.Controls.Add(this.comboBox1);
            this.groupBox_stockAjout.Controls.Add(this.LBL_stockAjout_nomVaccin);
            this.groupBox_stockAjout.Controls.Add(this.textBox3);
            this.groupBox_stockAjout.Controls.Add(this.LBL_sotckAjout_quantiteVaccin);
            this.groupBox_stockAjout.Controls.Add(this.textBox2);
            this.groupBox_stockAjout.Controls.Add(this.LBL_stockAjout_periodeValidite);
            this.groupBox_stockAjout.Controls.Add(this.textBox1);
            this.groupBox_stockAjout.Location = new System.Drawing.Point(35, 328);
            this.groupBox_stockAjout.Name = "groupBox_stockAjout";
            this.groupBox_stockAjout.Size = new System.Drawing.Size(339, 152);
            this.groupBox_stockAjout.TabIndex = 19;
            this.groupBox_stockAjout.TabStop = false;
            this.groupBox_stockAjout.Text = "Ajout";
            // 
            // BTN_sotckAjout_AjouterVaccin
            // 
            this.BTN_sotckAjout_AjouterVaccin.Location = new System.Drawing.Point(320, 288);
            this.BTN_sotckAjout_AjouterVaccin.Name = "BTN_sotckAjout_AjouterVaccin";
            this.BTN_sotckAjout_AjouterVaccin.Size = new System.Drawing.Size(107, 23);
            this.BTN_sotckAjout_AjouterVaccin.TabIndex = 20;
            this.BTN_sotckAjout_AjouterVaccin.Text = "Ajouter Vaccin";
            this.BTN_sotckAjout_AjouterVaccin.UseVisualStyleBackColor = true;
            this.BTN_sotckAjout_AjouterVaccin.Click += new System.EventHandler(this.BTN_sotckAjout_AjouterVaccin_Click);
            // 
            // BTN_sotckAjout_AnnulerAjout
            // 
            this.BTN_sotckAjout_AnnulerAjout.Location = new System.Drawing.Point(433, 288);
            this.BTN_sotckAjout_AnnulerAjout.Name = "BTN_sotckAjout_AnnulerAjout";
            this.BTN_sotckAjout_AnnulerAjout.Size = new System.Drawing.Size(107, 23);
            this.BTN_sotckAjout_AnnulerAjout.TabIndex = 21;
            this.BTN_sotckAjout_AnnulerAjout.Text = "Annuler Ajout";
            this.BTN_sotckAjout_AnnulerAjout.UseVisualStyleBackColor = true;
            this.BTN_sotckAjout_AnnulerAjout.Click += new System.EventHandler(this.BTN_sotckAjout_AnnulerAjout_Click);
            // 
            // EcranStockVaccin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 492);
            this.Controls.Add(this.BTN_sotckAjout_AnnulerAjout);
            this.Controls.Add(this.BTN_sotckAjout_AjouterVaccin);
            this.Controls.Add(this.groupBox_stockAjout);
            this.Controls.Add(this.BTN_stock_annuler);
            this.Controls.Add(this.BTN_sotck_ajouter);
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
        private System.Windows.Forms.Button BTN_sotck_ajouter;
        private System.Windows.Forms.Button BTN_stock_annuler;
        private System.Windows.Forms.Button BTN_stockAjout_Ajouter;
        private System.Windows.Forms.Button BTN_stockAjout_Annuler;
        private System.Windows.Forms.Label LBL_stockAjout_nomVaccin;
        private System.Windows.Forms.Label LBL_sotckAjout_quantiteVaccin;
        private System.Windows.Forms.Label LBL_stockAjout_periodeValidite;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LBL_stockAjout_Fournisseur;
        private System.Windows.Forms.GroupBox groupBox_stockAjout;
        private System.Windows.Forms.Button BTN_sotckAjout_AjouterVaccin;
        private System.Windows.Forms.Button BTN_sotckAjout_AnnulerAjout;
    }
}