namespace Clinique
{
    partial class EcranPriseRendezVous
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
            this.groupBoxPour = new System.Windows.Forms.GroupBox();
            this.BTN_AddAnimal = new System.Windows.Forms.Button();
            this.BTN_AddClient = new System.Windows.Forms.Button();
            this.COMBO_Client = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPar = new System.Windows.Forms.GroupBox();
            this.COMBO_Veto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxQuand = new System.Windows.Forms.GroupBox();
            this.BTN_Urgence = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.COMBO_Minutes = new System.Windows.Forms.ComboBox();
            this.COMBO_Heure = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.DATE_RendezVous = new System.Windows.Forms.DateTimePicker();
            this.COMBO_Animal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.BTN_Suppr = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.groupBoxPour.SuspendLayout();
            this.groupBoxPar.SuspendLayout();
            this.groupBoxQuand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPour
            // 
            this.groupBoxPour.Controls.Add(this.BTN_AddAnimal);
            this.groupBoxPour.Controls.Add(this.BTN_AddClient);
            this.groupBoxPour.Controls.Add(this.COMBO_Client);
            this.groupBoxPour.Controls.Add(this.label1);
            this.groupBoxPour.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPour.Name = "groupBoxPour";
            this.groupBoxPour.Size = new System.Drawing.Size(211, 141);
            this.groupBoxPour.TabIndex = 1;
            this.groupBoxPour.TabStop = false;
            this.groupBoxPour.Text = " Pour";
            // 
            // BTN_AddAnimal
            // 
            this.BTN_AddAnimal.Location = new System.Drawing.Point(187, 84);
            this.BTN_AddAnimal.Name = "BTN_AddAnimal";
            this.BTN_AddAnimal.Size = new System.Drawing.Size(18, 38);
            this.BTN_AddAnimal.TabIndex = 3;
            this.BTN_AddAnimal.Text = "+";
            this.BTN_AddAnimal.UseVisualStyleBackColor = true;
            this.BTN_AddAnimal.Click += new System.EventHandler(this.BTN_AddAnimal_Click);
            // 
            // BTN_AddClient
            // 
            this.BTN_AddClient.Location = new System.Drawing.Point(187, 33);
            this.BTN_AddClient.Name = "BTN_AddClient";
            this.BTN_AddClient.Size = new System.Drawing.Size(18, 38);
            this.BTN_AddClient.TabIndex = 2;
            this.BTN_AddClient.Text = "+";
            this.BTN_AddClient.UseVisualStyleBackColor = true;
            // 
            // COMBO_Client
            // 
            this.COMBO_Client.FormattingEnabled = true;
            this.COMBO_Client.Location = new System.Drawing.Point(7, 41);
            this.COMBO_Client.Name = "COMBO_Client";
            this.COMBO_Client.Size = new System.Drawing.Size(174, 21);
            this.COMBO_Client.TabIndex = 1;
            this.COMBO_Client.SelectedIndexChanged += new System.EventHandler(this.COMBO_Client_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Client";
            // 
            // groupBoxPar
            // 
            this.groupBoxPar.Controls.Add(this.COMBO_Veto);
            this.groupBoxPar.Controls.Add(this.label3);
            this.groupBoxPar.Location = new System.Drawing.Point(229, 12);
            this.groupBoxPar.Name = "groupBoxPar";
            this.groupBoxPar.Size = new System.Drawing.Size(163, 141);
            this.groupBoxPar.TabIndex = 2;
            this.groupBoxPar.TabStop = false;
            this.groupBoxPar.Text = " Par";
            // 
            // COMBO_Veto
            // 
            this.COMBO_Veto.FormattingEnabled = true;
            this.COMBO_Veto.Location = new System.Drawing.Point(7, 58);
            this.COMBO_Veto.Name = "COMBO_Veto";
            this.COMBO_Veto.Size = new System.Drawing.Size(150, 21);
            this.COMBO_Veto.TabIndex = 5;
            this.COMBO_Veto.SelectedIndexChanged += new System.EventHandler(this.COMBO_Veto_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = " Vétérinaire";
            // 
            // groupBoxQuand
            // 
            this.groupBoxQuand.Controls.Add(this.BTN_Urgence);
            this.groupBoxQuand.Controls.Add(this.label5);
            this.groupBoxQuand.Controls.Add(this.label4);
            this.groupBoxQuand.Controls.Add(this.COMBO_Minutes);
            this.groupBoxQuand.Controls.Add(this.COMBO_Heure);
            this.groupBoxQuand.Controls.Add(this.label54);
            this.groupBoxQuand.Controls.Add(this.DATE_RendezVous);
            this.groupBoxQuand.Location = new System.Drawing.Point(398, 12);
            this.groupBoxQuand.Name = "groupBoxQuand";
            this.groupBoxQuand.Size = new System.Drawing.Size(187, 141);
            this.groupBoxQuand.TabIndex = 3;
            this.groupBoxQuand.TabStop = false;
            this.groupBoxQuand.Text = " Quand";
            // 
            // BTN_Urgence
            // 
            this.BTN_Urgence.Location = new System.Drawing.Point(7, 110);
            this.BTN_Urgence.Name = "BTN_Urgence";
            this.BTN_Urgence.Size = new System.Drawing.Size(174, 23);
            this.BTN_Urgence.TabIndex = 9;
            this.BTN_Urgence.Text = "Urgence";
            this.BTN_Urgence.UseVisualStyleBackColor = true;
            this.BTN_Urgence.Click += new System.EventHandler(this.BTN_Urgence_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = " Minutes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Heure";
            // 
            // COMBO_Minutes
            // 
            this.COMBO_Minutes.FormattingEnabled = true;
            this.COMBO_Minutes.Location = new System.Drawing.Point(97, 75);
            this.COMBO_Minutes.Name = "COMBO_Minutes";
            this.COMBO_Minutes.Size = new System.Drawing.Size(84, 21);
            this.COMBO_Minutes.TabIndex = 6;
            // 
            // COMBO_Heure
            // 
            this.COMBO_Heure.FormattingEnabled = true;
            this.COMBO_Heure.Location = new System.Drawing.Point(7, 76);
            this.COMBO_Heure.Name = "COMBO_Heure";
            this.COMBO_Heure.Size = new System.Drawing.Size(89, 21);
            this.COMBO_Heure.TabIndex = 5;
            this.COMBO_Heure.SelectedIndexChanged += new System.EventHandler(this.COMBO_Heure_SelectedIndexChanged);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(66, 16);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(30, 13);
            this.label54.TabIndex = 4;
            this.label54.Text = "Date";
            // 
            // DATE_RendezVous
            // 
            this.DATE_RendezVous.Location = new System.Drawing.Point(7, 33);
            this.DATE_RendezVous.Name = "DATE_RendezVous";
            this.DATE_RendezVous.Size = new System.Drawing.Size(174, 20);
            this.DATE_RendezVous.TabIndex = 0;
            this.DATE_RendezVous.ValueChanged += new System.EventHandler(this.DATE_RendezVous_ValueChanged);
            // 
            // COMBO_Animal
            // 
            this.COMBO_Animal.FormattingEnabled = true;
            this.COMBO_Animal.Location = new System.Drawing.Point(19, 106);
            this.COMBO_Animal.Name = "COMBO_Animal";
            this.COMBO_Animal.Size = new System.Drawing.Size(174, 21);
            this.COMBO_Animal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Animal";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 160);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(575, 203);
            this.dataGrid.TabIndex = 4;
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.Location = new System.Drawing.Point(87, 370);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(129, 23);
            this.BTN_Valider.TabIndex = 5;
            this.BTN_Valider.Text = "Valider";
            this.BTN_Valider.UseVisualStyleBackColor = true;
            this.BTN_Valider.Click += new System.EventHandler(this.BTN_Valider_Click);
            // 
            // BTN_Suppr
            // 
            this.BTN_Suppr.Location = new System.Drawing.Point(222, 370);
            this.BTN_Suppr.Name = "BTN_Suppr";
            this.BTN_Suppr.Size = new System.Drawing.Size(129, 23);
            this.BTN_Suppr.TabIndex = 6;
            this.BTN_Suppr.Text = " Supprimer";
            this.BTN_Suppr.UseVisualStyleBackColor = true;
            this.BTN_Suppr.Click += new System.EventHandler(this.BTN_Suppr_Click);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.Location = new System.Drawing.Point(357, 370);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(129, 23);
            this.BTN_Annuler.TabIndex = 7;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click);
            // 
            // EcranPriseRendezVous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 397);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Suppr);
            this.Controls.Add(this.BTN_Valider);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.COMBO_Animal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxQuand);
            this.Controls.Add(this.groupBoxPar);
            this.Controls.Add(this.groupBoxPour);
            this.Name = "EcranPriseRendezVous";
            this.Text = "EcranPriseRendezVous";
            this.groupBoxPour.ResumeLayout(false);
            this.groupBoxPour.PerformLayout();
            this.groupBoxPar.ResumeLayout(false);
            this.groupBoxPar.PerformLayout();
            this.groupBoxQuand.ResumeLayout(false);
            this.groupBoxQuand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPour;
        private System.Windows.Forms.GroupBox groupBoxPar;
        private System.Windows.Forms.GroupBox groupBoxQuand;
        private System.Windows.Forms.Button BTN_AddAnimal;
        private System.Windows.Forms.Button BTN_AddClient;
        private System.Windows.Forms.ComboBox COMBO_Client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox COMBO_Veto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Urgence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox COMBO_Minutes;
        private System.Windows.Forms.ComboBox COMBO_Heure;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.DateTimePicker DATE_RendezVous;
        private System.Windows.Forms.ComboBox COMBO_Animal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button BTN_Valider;
        private System.Windows.Forms.Button BTN_Suppr;
        private System.Windows.Forms.Button BTN_Annuler;
    }
}