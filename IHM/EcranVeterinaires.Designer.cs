﻿namespace clinique
{
    partial class EcranVeterinaires
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
            this.groupBoxBtnVeto = new System.Windows.Forms.GroupBox();
            this.BTN_ajouterVeto = new System.Windows.Forms.Button();
            this.BTN_SupprimerVeto = new System.Windows.Forms.Button();
            this.BTN_ReinitialiserVeto = new System.Windows.Forms.Button();
            this.r = new System.Windows.Forms.DataGridView();
            this.LBL_ajouter = new System.Windows.Forms.Label();
            this.LBL_supprimerVeto = new System.Windows.Forms.Label();
            this.LBL_reinitialiserVeto = new System.Windows.Forms.Label();
            this.groupBoxBtnVeto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.r)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBtnVeto
            // 
            this.groupBoxBtnVeto.Controls.Add(this.LBL_reinitialiserVeto);
            this.groupBoxBtnVeto.Controls.Add(this.LBL_supprimerVeto);
            this.groupBoxBtnVeto.Controls.Add(this.LBL_ajouter);
            this.groupBoxBtnVeto.Controls.Add(this.BTN_ReinitialiserVeto);
            this.groupBoxBtnVeto.Controls.Add(this.BTN_SupprimerVeto);
            this.groupBoxBtnVeto.Controls.Add(this.BTN_ajouterVeto);
            this.groupBoxBtnVeto.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBtnVeto.Name = "groupBoxBtnVeto";
            this.groupBoxBtnVeto.Size = new System.Drawing.Size(380, 84);
            this.groupBoxBtnVeto.TabIndex = 0;
            this.groupBoxBtnVeto.TabStop = false;
            this.groupBoxBtnVeto.Text = "groupBox1";
            // 
            // BTN_ajouterVeto
            // 
            this.BTN_ajouterVeto.Location = new System.Drawing.Point(28, 20);
            this.BTN_ajouterVeto.Name = "BTN_ajouterVeto";
            this.BTN_ajouterVeto.Size = new System.Drawing.Size(75, 23);
            this.BTN_ajouterVeto.TabIndex = 0;
            this.BTN_ajouterVeto.UseVisualStyleBackColor = true;
            // 
            // BTN_SupprimerVeto
            // 
            this.BTN_SupprimerVeto.Location = new System.Drawing.Point(120, 20);
            this.BTN_SupprimerVeto.Name = "BTN_SupprimerVeto";
            this.BTN_SupprimerVeto.Size = new System.Drawing.Size(75, 23);
            this.BTN_SupprimerVeto.TabIndex = 1;
            this.BTN_SupprimerVeto.UseVisualStyleBackColor = true;
            // 
            // BTN_ReinitialiserVeto
            // 
            this.BTN_ReinitialiserVeto.Location = new System.Drawing.Point(210, 20);
            this.BTN_ReinitialiserVeto.Name = "BTN_ReinitialiserVeto";
            this.BTN_ReinitialiserVeto.Size = new System.Drawing.Size(75, 23);
            this.BTN_ReinitialiserVeto.TabIndex = 2;
            this.BTN_ReinitialiserVeto.UseVisualStyleBackColor = true;
            // 
            // r
            // 
            this.r.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.r.Location = new System.Drawing.Point(8, 90);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(449, 184);
            this.r.TabIndex = 1;
            // 
            // LBL_ajouter
            // 
            this.LBL_ajouter.AutoSize = true;
            this.LBL_ajouter.Location = new System.Drawing.Point(35, 46);
            this.LBL_ajouter.Name = "LBL_ajouter";
            this.LBL_ajouter.Size = new System.Drawing.Size(40, 13);
            this.LBL_ajouter.TabIndex = 3;
            this.LBL_ajouter.Text = "Ajouter";
            // 
            // LBL_supprimerVeto
            // 
            this.LBL_supprimerVeto.AutoSize = true;
            this.LBL_supprimerVeto.Location = new System.Drawing.Point(128, 45);
            this.LBL_supprimerVeto.Name = "LBL_supprimerVeto";
            this.LBL_supprimerVeto.Size = new System.Drawing.Size(54, 13);
            this.LBL_supprimerVeto.TabIndex = 4;
            this.LBL_supprimerVeto.Text = "Supprimer";
            // 
            // LBL_reinitialiserVeto
            // 
            this.LBL_reinitialiserVeto.AutoSize = true;
            this.LBL_reinitialiserVeto.Location = new System.Drawing.Point(220, 46);
            this.LBL_reinitialiserVeto.Name = "LBL_reinitialiserVeto";
            this.LBL_reinitialiserVeto.Size = new System.Drawing.Size(60, 13);
            this.LBL_reinitialiserVeto.TabIndex = 5;
            this.LBL_reinitialiserVeto.Text = "Réinitialiser";
            // 
            // EcranVeterinaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 286);
            this.Controls.Add(this.r);
            this.Controls.Add(this.groupBoxBtnVeto);
            this.Name = "EcranVeterinaires";
            this.Text = "EcranVeterinaires";
            this.groupBoxBtnVeto.ResumeLayout(false);
            this.groupBoxBtnVeto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.r)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBtnVeto;
        private System.Windows.Forms.Button BTN_ReinitialiserVeto;
        private System.Windows.Forms.Button BTN_SupprimerVeto;
        private System.Windows.Forms.Button BTN_ajouterVeto;
        private System.Windows.Forms.DataGridView r;
        private System.Windows.Forms.Label LBL_reinitialiserVeto;
        private System.Windows.Forms.Label LBL_supprimerVeto;
        private System.Windows.Forms.Label LBL_ajouter;
    }
}