namespace Clinique
{
    partial class EcranDossierMedicaux
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
            this.label3 = new System.Windows.Forms.Label();
            this.COMBO_Animal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.COMBO_Tatouage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.COMBO_Client = new System.Windows.Forms.ComboBox();
            this.GRID_Consultation = new System.Windows.Forms.DataGridView();
            this.TXT_Commentaire = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Consultation)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.COMBO_Animal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.COMBO_Tatouage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.COMBO_Client);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher un animal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nom animal";
            // 
            // COMBO_Animal
            // 
            this.COMBO_Animal.FormattingEnabled = true;
            this.COMBO_Animal.Location = new System.Drawing.Point(72, 46);
            this.COMBO_Animal.Name = "COMBO_Animal";
            this.COMBO_Animal.Size = new System.Drawing.Size(398, 21);
            this.COMBO_Animal.TabIndex = 4;
            this.COMBO_Animal.SelectedIndexChanged += new System.EventHandler(this.COMBO_Animal_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "N° Tatouage";
            // 
            // COMBO_Tatouage
            // 
            this.COMBO_Tatouage.FormattingEnabled = true;
            this.COMBO_Tatouage.Location = new System.Drawing.Point(317, 19);
            this.COMBO_Tatouage.Name = "COMBO_Tatouage";
            this.COMBO_Tatouage.Size = new System.Drawing.Size(153, 21);
            this.COMBO_Tatouage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Propriétaire";
            // 
            // COMBO_Client
            // 
            this.COMBO_Client.FormattingEnabled = true;
            this.COMBO_Client.Location = new System.Drawing.Point(72, 19);
            this.COMBO_Client.Name = "COMBO_Client";
            this.COMBO_Client.Size = new System.Drawing.Size(153, 21);
            this.COMBO_Client.TabIndex = 0;
            this.COMBO_Client.SelectedIndexChanged += new System.EventHandler(this.COMBO_Client_SelectedIndexChanged);
            // 
            // GRID_Consultation
            // 
            this.GRID_Consultation.AllowUserToAddRows = false;
            this.GRID_Consultation.AllowUserToDeleteRows = false;
            this.GRID_Consultation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_Consultation.Location = new System.Drawing.Point(12, 110);
            this.GRID_Consultation.Name = "GRID_Consultation";
            this.GRID_Consultation.ReadOnly = true;
            this.GRID_Consultation.Size = new System.Drawing.Size(476, 167);
            this.GRID_Consultation.TabIndex = 2;
            this.GRID_Consultation.RowDividerDoubleClick += new System.Windows.Forms.DataGridViewRowDividerDoubleClickEventHandler(this.GRID_Consultation_RowDividerDoubleClick);
            // 
            // TXT_Commentaire
            // 
            this.TXT_Commentaire.Location = new System.Drawing.Point(12, 294);
            this.TXT_Commentaire.Name = "TXT_Commentaire";
            this.TXT_Commentaire.ReadOnly = true;
            this.TXT_Commentaire.Size = new System.Drawing.Size(476, 86);
            this.TXT_Commentaire.TabIndex = 3;
            this.TXT_Commentaire.Text = "";
            // 
            // EcranDossierMedicaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 392);
            this.Controls.Add(this.TXT_Commentaire);
            this.Controls.Add(this.GRID_Consultation);
            this.Controls.Add(this.groupBox1);
            this.Name = "EcranDossierMedicaux";
            this.Text = "Dossier médicaux";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Consultation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox COMBO_Client;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox COMBO_Animal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox COMBO_Tatouage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GRID_Consultation;
        private System.Windows.Forms.RichTextBox TXT_Commentaire;
    }
}