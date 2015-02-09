namespace Clinique
{
    partial class EcranClients
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_clients_recherche = new System.Windows.Forms.TextBox();
            this.BTN_clients_recherche = new System.Windows.Forms.Button();
            this.BTN_clients_supprimer = new System.Windows.Forms.Button();
            this.BTN_clients_ajouter = new System.Windows.Forms.Button();
            this.dataGrid_clients = new System.Windows.Forms.DataGridView();
            this.LBL_clients_code = new System.Windows.Forms.Label();
            this.LBL_clients_nom = new System.Windows.Forms.Label();
            this.LBL_clients_prenom = new System.Windows.Forms.Label();
            this.LBL_clients_CDP = new System.Windows.Forms.Label();
            this.LBL_clients_ville = new System.Windows.Forms.Label();
            this.TXT_clients_code = new System.Windows.Forms.TextBox();
            this.TXT_clients_nom = new System.Windows.Forms.TextBox();
            this.TXT_clients_prenom = new System.Windows.Forms.TextBox();
            this.TXT_clients_adresse1 = new System.Windows.Forms.TextBox();
            this.TXT_clients_adresse2 = new System.Windows.Forms.TextBox();
            this.TXT_clients_CP = new System.Windows.Forms.TextBox();
            this.TXT_clients_ville = new System.Windows.Forms.TextBox();
            this.BTN_clients_ajouter2 = new System.Windows.Forms.Button();
            this.BTN_clients_supprimer2 = new System.Windows.Forms.Button();
            this.BTN_clients_editer = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.NavBarre = new ControlsLibrary.NavBar();
            this.BTN_clients_ValiderAjout = new System.Windows.Forms.Button();
            this.BTN_client_AnnulerAjout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_clients)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_clients_recherche);
            this.groupBox1.Controls.Add(this.BTN_clients_recherche);
            this.groupBox1.Controls.Add(this.BTN_clients_supprimer);
            this.groupBox1.Controls.Add(this.BTN_clients_ajouter);
            this.groupBox1.Controls.Add(this.NavBarre);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // TXT_clients_recherche
            // 
            this.TXT_clients_recherche.Location = new System.Drawing.Point(6, 70);
            this.TXT_clients_recherche.Name = "TXT_clients_recherche";
            this.TXT_clients_recherche.Size = new System.Drawing.Size(293, 20);
            this.TXT_clients_recherche.TabIndex = 7;
            // 
            // BTN_clients_recherche
            // 
            this.BTN_clients_recherche.Location = new System.Drawing.Point(305, 70);
            this.BTN_clients_recherche.Name = "BTN_clients_recherche";
            this.BTN_clients_recherche.Size = new System.Drawing.Size(75, 20);
            this.BTN_clients_recherche.TabIndex = 6;
            this.BTN_clients_recherche.Text = "Rechercher";
            this.BTN_clients_recherche.UseVisualStyleBackColor = true;
            this.BTN_clients_recherche.Click += new System.EventHandler(this.BTN_clients_recherche_Click);
            // 
            // BTN_clients_supprimer
            // 
            this.BTN_clients_supprimer.Location = new System.Drawing.Point(508, 69);
            this.BTN_clients_supprimer.Name = "BTN_clients_supprimer";
            this.BTN_clients_supprimer.Size = new System.Drawing.Size(75, 21);
            this.BTN_clients_supprimer.TabIndex = 5;
            this.BTN_clients_supprimer.Text = "Supprimer";
            this.BTN_clients_supprimer.UseVisualStyleBackColor = true;
            this.BTN_clients_supprimer.Click += new System.EventHandler(this.BTN_clients_supprimer_Click);
            // 
            // BTN_clients_ajouter
            // 
            this.BTN_clients_ajouter.Location = new System.Drawing.Point(427, 69);
            this.BTN_clients_ajouter.Name = "BTN_clients_ajouter";
            this.BTN_clients_ajouter.Size = new System.Drawing.Size(75, 21);
            this.BTN_clients_ajouter.TabIndex = 4;
            this.BTN_clients_ajouter.Text = "Ajouter";
            this.BTN_clients_ajouter.UseVisualStyleBackColor = true;
            this.BTN_clients_ajouter.Click += new System.EventHandler(this.BTN_clients_ajouter_Click);
            // 
            // dataGrid_clients
            // 
            this.dataGrid_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_clients.Location = new System.Drawing.Point(16, 19);
            this.dataGrid_clients.Name = "dataGrid_clients";
            this.dataGrid_clients.Size = new System.Drawing.Size(512, 128);
            this.dataGrid_clients.TabIndex = 1;
            // 
            // LBL_clients_code
            // 
            this.LBL_clients_code.AutoSize = true;
            this.LBL_clients_code.Location = new System.Drawing.Point(40, 21);
            this.LBL_clients_code.Name = "LBL_clients_code";
            this.LBL_clients_code.Size = new System.Drawing.Size(32, 13);
            this.LBL_clients_code.TabIndex = 2;
            this.LBL_clients_code.Text = "Code";
            // 
            // LBL_clients_nom
            // 
            this.LBL_clients_nom.AutoSize = true;
            this.LBL_clients_nom.Location = new System.Drawing.Point(43, 47);
            this.LBL_clients_nom.Name = "LBL_clients_nom";
            this.LBL_clients_nom.Size = new System.Drawing.Size(29, 13);
            this.LBL_clients_nom.TabIndex = 3;
            this.LBL_clients_nom.Text = "Nom";
            // 
            // LBL_clients_prenom
            // 
            this.LBL_clients_prenom.AutoSize = true;
            this.LBL_clients_prenom.Location = new System.Drawing.Point(310, 47);
            this.LBL_clients_prenom.Name = "LBL_clients_prenom";
            this.LBL_clients_prenom.Size = new System.Drawing.Size(43, 13);
            this.LBL_clients_prenom.TabIndex = 4;
            this.LBL_clients_prenom.Text = "Prenom";
            // 
            // LBL_clients_CDP
            // 
            this.LBL_clients_CDP.AutoSize = true;
            this.LBL_clients_CDP.Location = new System.Drawing.Point(291, 73);
            this.LBL_clients_CDP.Name = "LBL_clients_CDP";
            this.LBL_clients_CDP.Size = new System.Drawing.Size(63, 13);
            this.LBL_clients_CDP.TabIndex = 6;
            this.LBL_clients_CDP.Text = "Code postal";
            // 
            // LBL_clients_ville
            // 
            this.LBL_clients_ville.AutoSize = true;
            this.LBL_clients_ville.Location = new System.Drawing.Point(327, 97);
            this.LBL_clients_ville.Name = "LBL_clients_ville";
            this.LBL_clients_ville.Size = new System.Drawing.Size(26, 13);
            this.LBL_clients_ville.TabIndex = 7;
            this.LBL_clients_ville.Text = "Ville";
            // 
            // TXT_clients_code
            // 
            this.TXT_clients_code.Location = new System.Drawing.Point(78, 18);
            this.TXT_clients_code.Name = "TXT_clients_code";
            this.TXT_clients_code.Size = new System.Drawing.Size(488, 20);
            this.TXT_clients_code.TabIndex = 8;
            // 
            // TXT_clients_nom
            // 
            this.TXT_clients_nom.Location = new System.Drawing.Point(78, 44);
            this.TXT_clients_nom.Name = "TXT_clients_nom";
            this.TXT_clients_nom.Size = new System.Drawing.Size(207, 20);
            this.TXT_clients_nom.TabIndex = 9;
            // 
            // TXT_clients_prenom
            // 
            this.TXT_clients_prenom.Location = new System.Drawing.Point(359, 44);
            this.TXT_clients_prenom.Name = "TXT_clients_prenom";
            this.TXT_clients_prenom.Size = new System.Drawing.Size(207, 20);
            this.TXT_clients_prenom.TabIndex = 10;
            // 
            // TXT_clients_adresse1
            // 
            this.TXT_clients_adresse1.Location = new System.Drawing.Point(78, 70);
            this.TXT_clients_adresse1.Name = "TXT_clients_adresse1";
            this.TXT_clients_adresse1.Size = new System.Drawing.Size(207, 20);
            this.TXT_clients_adresse1.TabIndex = 11;
            // 
            // TXT_clients_adresse2
            // 
            this.TXT_clients_adresse2.Location = new System.Drawing.Point(78, 96);
            this.TXT_clients_adresse2.Name = "TXT_clients_adresse2";
            this.TXT_clients_adresse2.Size = new System.Drawing.Size(207, 20);
            this.TXT_clients_adresse2.TabIndex = 12;
            // 
            // TXT_clients_CP
            // 
            this.TXT_clients_CP.Location = new System.Drawing.Point(359, 70);
            this.TXT_clients_CP.Name = "TXT_clients_CP";
            this.TXT_clients_CP.Size = new System.Drawing.Size(207, 20);
            this.TXT_clients_CP.TabIndex = 13;
            // 
            // TXT_clients_ville
            // 
            this.TXT_clients_ville.Location = new System.Drawing.Point(359, 96);
            this.TXT_clients_ville.Name = "TXT_clients_ville";
            this.TXT_clients_ville.Size = new System.Drawing.Size(207, 20);
            this.TXT_clients_ville.TabIndex = 14;
            // 
            // BTN_clients_ajouter2
            // 
            this.BTN_clients_ajouter2.Location = new System.Drawing.Point(146, 153);
            this.BTN_clients_ajouter2.Name = "BTN_clients_ajouter2";
            this.BTN_clients_ajouter2.Size = new System.Drawing.Size(75, 23);
            this.BTN_clients_ajouter2.TabIndex = 15;
            this.BTN_clients_ajouter2.Text = "Ajouter";
            this.BTN_clients_ajouter2.UseVisualStyleBackColor = true;
            this.BTN_clients_ajouter2.Click += new System.EventHandler(this.BTN_clients_ajouter2_Click);
            // 
            // BTN_clients_supprimer2
            // 
            this.BTN_clients_supprimer2.Location = new System.Drawing.Point(308, 153);
            this.BTN_clients_supprimer2.Name = "BTN_clients_supprimer2";
            this.BTN_clients_supprimer2.Size = new System.Drawing.Size(75, 23);
            this.BTN_clients_supprimer2.TabIndex = 16;
            this.BTN_clients_supprimer2.Text = "Supprimer";
            this.BTN_clients_supprimer2.UseVisualStyleBackColor = true;
            this.BTN_clients_supprimer2.Click += new System.EventHandler(this.BTN_clients_supprimer2_Click);
            // 
            // BTN_clients_editer
            // 
            this.BTN_clients_editer.Location = new System.Drawing.Point(227, 153);
            this.BTN_clients_editer.Name = "BTN_clients_editer";
            this.BTN_clients_editer.Size = new System.Drawing.Size(75, 23);
            this.BTN_clients_editer.TabIndex = 17;
            this.BTN_clients_editer.Text = "Editer";
            this.BTN_clients_editer.UseVisualStyleBackColor = true;
            this.BTN_clients_editer.Click += new System.EventHandler(this.BTN_clients_editer_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // NavBarre
            // 
            this.NavBarre.ApresEnable = true;
            this.NavBarre.AvantEnable = true;
            this.NavBarre.ButtonBorder = 1;
            this.NavBarre.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.NavBarre.ImageDernier = null;
            this.NavBarre.ImagePrecedent = null;
            this.NavBarre.ImagePremier = null;
            this.NavBarre.ImageSuivant = null;
            this.NavBarre.Location = new System.Drawing.Point(6, 19);
            this.NavBarre.Name = "NavBarre";
            this.NavBarre.Size = new System.Drawing.Size(580, 37);
            this.NavBarre.TabIndex = 18;
            this.NavBarre.TextDernier = "Dernier client";
            this.NavBarre.TextPrecedent = "Client précedent";
            this.NavBarre.TextPremier = "Premier client";
            this.NavBarre.TextSuivant = "Client suivant";
            this.NavBarre.Navigation += new System.EventHandler<ControlsLibrary.NavBarEventArgs>(this.NavBarre_Navigation);
            // 
            // BTN_clients_ValiderAjout
            // 
            this.BTN_clients_ValiderAjout.Location = new System.Drawing.Point(213, 131);
            this.BTN_clients_ValiderAjout.Name = "BTN_clients_ValiderAjout";
            this.BTN_clients_ValiderAjout.Size = new System.Drawing.Size(75, 23);
            this.BTN_clients_ValiderAjout.TabIndex = 19;
            this.BTN_clients_ValiderAjout.Text = "Valider";
            this.BTN_clients_ValiderAjout.UseVisualStyleBackColor = true;
            this.BTN_clients_ValiderAjout.Visible = false;
            this.BTN_clients_ValiderAjout.Click += new System.EventHandler(this.BTN_clients_ValiderAjout_Click);
            // 
            // BTN_client_AnnulerAjout
            // 
            this.BTN_client_AnnulerAjout.Location = new System.Drawing.Point(294, 131);
            this.BTN_client_AnnulerAjout.Name = "BTN_client_AnnulerAjout";
            this.BTN_client_AnnulerAjout.Size = new System.Drawing.Size(75, 23);
            this.BTN_client_AnnulerAjout.TabIndex = 20;
            this.BTN_client_AnnulerAjout.Text = "Annuler";
            this.BTN_client_AnnulerAjout.UseVisualStyleBackColor = true;
            this.BTN_client_AnnulerAjout.Visible = false;
            this.BTN_client_AnnulerAjout.Click += new System.EventHandler(this.BTN_client_AnnulerAjout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Adresse N°2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Adresse N°1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.TXT_clients_code);
            this.groupBox2.Controls.Add(this.BTN_client_AnnulerAjout);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BTN_clients_ValiderAjout);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.LBL_clients_code);
            this.groupBox2.Controls.Add(this.TXT_clients_nom);
            this.groupBox2.Controls.Add(this.LBL_clients_nom);
            this.groupBox2.Controls.Add(this.TXT_clients_ville);
            this.groupBox2.Controls.Add(this.TXT_clients_prenom);
            this.groupBox2.Controls.Add(this.TXT_clients_CP);
            this.groupBox2.Controls.Add(this.LBL_clients_ville);
            this.groupBox2.Controls.Add(this.LBL_clients_prenom);
            this.groupBox2.Controls.Add(this.LBL_clients_CDP);
            this.groupBox2.Controls.Add(this.TXT_clients_adresse1);
            this.groupBox2.Controls.Add(this.TXT_clients_adresse2);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 362);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations client";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGrid_clients);
            this.groupBox3.Controls.Add(this.BTN_clients_editer);
            this.groupBox3.Controls.Add(this.BTN_clients_ajouter2);
            this.groupBox3.Controls.Add(this.BTN_clients_supprimer2);
            this.groupBox3.Location = new System.Drawing.Point(22, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 186);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Animaux";
            // 
            // EcranClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 505);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EcranClients";
            this.Text = "Clients";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_clients)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_clients_recherche;
        private System.Windows.Forms.Button BTN_clients_recherche;
        private System.Windows.Forms.Button BTN_clients_supprimer;
        private System.Windows.Forms.Button BTN_clients_ajouter;
        private System.Windows.Forms.DataGridView dataGrid_clients;
        private System.Windows.Forms.Label LBL_clients_code;
        private System.Windows.Forms.Label LBL_clients_nom;
        private System.Windows.Forms.Label LBL_clients_prenom;
        private System.Windows.Forms.Label LBL_clients_CDP;
        private System.Windows.Forms.Label LBL_clients_ville;
        private System.Windows.Forms.TextBox TXT_clients_code;
        private System.Windows.Forms.TextBox TXT_clients_nom;
        private System.Windows.Forms.TextBox TXT_clients_prenom;
        private System.Windows.Forms.TextBox TXT_clients_adresse1;
        private System.Windows.Forms.TextBox TXT_clients_adresse2;
        private System.Windows.Forms.TextBox TXT_clients_CP;
        private System.Windows.Forms.TextBox TXT_clients_ville;
        private System.Windows.Forms.Button BTN_clients_ajouter2;
        private System.Windows.Forms.Button BTN_clients_supprimer2;
        private System.Windows.Forms.Button BTN_clients_editer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private ControlsLibrary.NavBar NavBarre;
        private System.Windows.Forms.Button BTN_clients_ValiderAjout;
        private System.Windows.Forms.Button BTN_client_AnnulerAjout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}