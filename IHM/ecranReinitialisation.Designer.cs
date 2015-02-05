namespace Clinique
{
    partial class ecranReinitialisation
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
            this.LBL_reinit_nomVeto = new System.Windows.Forms.Label();
            this.LBL_reinit_MDP1 = new System.Windows.Forms.Label();
            this.LBL_reinit_confirme = new System.Windows.Forms.Label();
            this.TXT_reinit_NouveauMDP = new System.Windows.Forms.TextBox();
            this.TXT_reinit_confirmMDP = new System.Windows.Forms.TextBox();
            this.BTN_reinit_valider = new System.Windows.Forms.Button();
            this.BTN_reinit_annuler = new System.Windows.Forms.Button();
            this.combo_reinit_nom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LBL_reinit_nomVeto
            // 
            this.LBL_reinit_nomVeto.AutoSize = true;
            this.LBL_reinit_nomVeto.Location = new System.Drawing.Point(6, 37);
            this.LBL_reinit_nomVeto.Name = "LBL_reinit_nomVeto";
            this.LBL_reinit_nomVeto.Size = new System.Drawing.Size(29, 13);
            this.LBL_reinit_nomVeto.TabIndex = 0;
            this.LBL_reinit_nomVeto.Text = "Nom";
            // 
            // LBL_reinit_MDP1
            // 
            this.LBL_reinit_MDP1.AutoSize = true;
            this.LBL_reinit_MDP1.Location = new System.Drawing.Point(6, 85);
            this.LBL_reinit_MDP1.Name = "LBL_reinit_MDP1";
            this.LBL_reinit_MDP1.Size = new System.Drawing.Size(117, 13);
            this.LBL_reinit_MDP1.TabIndex = 1;
            this.LBL_reinit_MDP1.Text = "Nouveau mot de passe";
            // 
            // LBL_reinit_confirme
            // 
            this.LBL_reinit_confirme.AutoSize = true;
            this.LBL_reinit_confirme.Location = new System.Drawing.Point(6, 139);
            this.LBL_reinit_confirme.Name = "LBL_reinit_confirme";
            this.LBL_reinit_confirme.Size = new System.Drawing.Size(128, 13);
            this.LBL_reinit_confirme.TabIndex = 2;
            this.LBL_reinit_confirme.Text = "Confirmer le mot de passe";
            // 
            // TXT_reinit_NouveauMDP
            // 
            this.TXT_reinit_NouveauMDP.Location = new System.Drawing.Point(140, 82);
            this.TXT_reinit_NouveauMDP.Name = "TXT_reinit_NouveauMDP";
            this.TXT_reinit_NouveauMDP.Size = new System.Drawing.Size(100, 20);
            this.TXT_reinit_NouveauMDP.TabIndex = 4;
            // 
            // TXT_reinit_confirmMDP
            // 
            this.TXT_reinit_confirmMDP.Location = new System.Drawing.Point(140, 136);
            this.TXT_reinit_confirmMDP.Name = "TXT_reinit_confirmMDP";
            this.TXT_reinit_confirmMDP.Size = new System.Drawing.Size(100, 20);
            this.TXT_reinit_confirmMDP.TabIndex = 5;
            // 
            // BTN_reinit_valider
            // 
            this.BTN_reinit_valider.Location = new System.Drawing.Point(33, 181);
            this.BTN_reinit_valider.Name = "BTN_reinit_valider";
            this.BTN_reinit_valider.Size = new System.Drawing.Size(75, 23);
            this.BTN_reinit_valider.TabIndex = 6;
            this.BTN_reinit_valider.Text = "Valider";
            this.BTN_reinit_valider.UseVisualStyleBackColor = true;
            this.BTN_reinit_valider.Click += new System.EventHandler(this.BTN_reinit_valider_Click);
            // 
            // BTN_reinit_annuler
            // 
            this.BTN_reinit_annuler.Location = new System.Drawing.Point(140, 181);
            this.BTN_reinit_annuler.Name = "BTN_reinit_annuler";
            this.BTN_reinit_annuler.Size = new System.Drawing.Size(75, 23);
            this.BTN_reinit_annuler.TabIndex = 7;
            this.BTN_reinit_annuler.Text = "Annuler";
            this.BTN_reinit_annuler.UseVisualStyleBackColor = true;
            this.BTN_reinit_annuler.Click += new System.EventHandler(this.BTN_reinit_annuler_Click);
            // 
            // combo_reinit_nom
            // 
            this.combo_reinit_nom.FormattingEnabled = true;
            this.combo_reinit_nom.Location = new System.Drawing.Point(119, 34);
            this.combo_reinit_nom.Name = "combo_reinit_nom";
            this.combo_reinit_nom.Size = new System.Drawing.Size(121, 21);
            this.combo_reinit_nom.TabIndex = 8;
            // 
            // ecranReinitialisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 211);
            this.Controls.Add(this.combo_reinit_nom);
            this.Controls.Add(this.BTN_reinit_annuler);
            this.Controls.Add(this.BTN_reinit_valider);
            this.Controls.Add(this.TXT_reinit_confirmMDP);
            this.Controls.Add(this.TXT_reinit_NouveauMDP);
            this.Controls.Add(this.LBL_reinit_confirme);
            this.Controls.Add(this.LBL_reinit_MDP1);
            this.Controls.Add(this.LBL_reinit_nomVeto);
            this.Name = "ecranReinitialisation";
            this.Text = "Reinitialisation Mot de passe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_reinit_nomVeto;
        private System.Windows.Forms.Label LBL_reinit_MDP1;
        private System.Windows.Forms.Label LBL_reinit_confirme;
        private System.Windows.Forms.TextBox TXT_reinit_NouveauMDP;
        private System.Windows.Forms.TextBox TXT_reinit_confirmMDP;
        private System.Windows.Forms.Button BTN_reinit_valider;
        private System.Windows.Forms.Button BTN_reinit_annuler;
        private System.Windows.Forms.ComboBox combo_reinit_nom;
    }
}