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
            this.LBL_clients_adresse = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_clients)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_clients_recherche);
            this.groupBox1.Controls.Add(this.BTN_clients_recherche);
            this.groupBox1.Controls.Add(this.BTN_clients_supprimer);
            this.groupBox1.Controls.Add(this.BTN_clients_ajouter);
            this.groupBox1.Location = new System.Drawing.Point(406, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // TXT_clients_recherche
            // 
            this.TXT_clients_recherche.Location = new System.Drawing.Point(98, 17);
            this.TXT_clients_recherche.Name = "TXT_clients_recherche";
            this.TXT_clients_recherche.Size = new System.Drawing.Size(100, 20);
            this.TXT_clients_recherche.TabIndex = 7;
            // 
            // BTN_clients_recherche
            // 
            this.BTN_clients_recherche.Location = new System.Drawing.Point(98, 43);
            this.BTN_clients_recherche.Name = "BTN_clients_recherche";
            this.BTN_clients_recherche.Size = new System.Drawing.Size(75, 23);
            this.BTN_clients_recherche.TabIndex = 6;
            this.BTN_clients_recherche.Text = "Rechercher";
            this.BTN_clients_recherche.UseVisualStyleBackColor = true;
            // 
            // BTN_clients_supprimer
            // 
            this.BTN_clients_supprimer.Location = new System.Drawing.Point(17, 43);
            this.BTN_clients_supprimer.Name = "BTN_clients_supprimer";
            this.BTN_clients_supprimer.Size = new System.Drawing.Size(75, 23);
            this.BTN_clients_supprimer.TabIndex = 5;
            this.BTN_clients_supprimer.Text = "Supprimer";
            this.BTN_clients_supprimer.UseVisualStyleBackColor = true;
            // 
            // BTN_clients_ajouter
            // 
            this.BTN_clients_ajouter.Location = new System.Drawing.Point(17, 14);
            this.BTN_clients_ajouter.Name = "BTN_clients_ajouter";
            this.BTN_clients_ajouter.Size = new System.Drawing.Size(75, 23);
            this.BTN_clients_ajouter.TabIndex = 4;
            this.BTN_clients_ajouter.Text = "Ajouter";
            this.BTN_clients_ajouter.UseVisualStyleBackColor = true;
            this.BTN_clients_ajouter.Click += new System.EventHandler(this.BTN_clients_ajouter_Click);
            // 
            // dataGrid_clients
            // 
            this.dataGrid_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_clients.Location = new System.Drawing.Point(183, 101);
            this.dataGrid_clients.Name = "dataGrid_clients";
            this.dataGrid_clients.Size = new System.Drawing.Size(402, 234);
            this.dataGrid_clients.TabIndex = 1;
            // 
            // LBL_clients_code
            // 
            this.LBL_clients_code.AutoSize = true;
            this.LBL_clients_code.Location = new System.Drawing.Point(0, 102);
            this.LBL_clients_code.Name = "LBL_clients_code";
            this.LBL_clients_code.Size = new System.Drawing.Size(32, 13);
            this.LBL_clients_code.TabIndex = 2;
            this.LBL_clients_code.Text = "Code";
            // 
            // LBL_clients_nom
            // 
            this.LBL_clients_nom.AutoSize = true;
            this.LBL_clients_nom.Location = new System.Drawing.Point(0, 132);
            this.LBL_clients_nom.Name = "LBL_clients_nom";
            this.LBL_clients_nom.Size = new System.Drawing.Size(29, 13);
            this.LBL_clients_nom.TabIndex = 3;
            this.LBL_clients_nom.Text = "Nom";
            // 
            // LBL_clients_prenom
            // 
            this.LBL_clients_prenom.AutoSize = true;
            this.LBL_clients_prenom.Location = new System.Drawing.Point(0, 168);
            this.LBL_clients_prenom.Name = "LBL_clients_prenom";
            this.LBL_clients_prenom.Size = new System.Drawing.Size(43, 13);
            this.LBL_clients_prenom.TabIndex = 4;
            this.LBL_clients_prenom.Text = "Prenom";
            // 
            // LBL_clients_adresse
            // 
            this.LBL_clients_adresse.AutoSize = true;
            this.LBL_clients_adresse.Location = new System.Drawing.Point(0, 198);
            this.LBL_clients_adresse.Name = "LBL_clients_adresse";
            this.LBL_clients_adresse.Size = new System.Drawing.Size(45, 13);
            this.LBL_clients_adresse.TabIndex = 5;
            this.LBL_clients_adresse.Text = "Adresse";
            // 
            // LBL_clients_CDP
            // 
            this.LBL_clients_CDP.AutoSize = true;
            this.LBL_clients_CDP.Location = new System.Drawing.Point(0, 250);
            this.LBL_clients_CDP.Name = "LBL_clients_CDP";
            this.LBL_clients_CDP.Size = new System.Drawing.Size(63, 13);
            this.LBL_clients_CDP.TabIndex = 6;
            this.LBL_clients_CDP.Text = "Code postal";
            // 
            // LBL_clients_ville
            // 
            this.LBL_clients_ville.AutoSize = true;
            this.LBL_clients_ville.Location = new System.Drawing.Point(0, 279);
            this.LBL_clients_ville.Name = "LBL_clients_ville";
            this.LBL_clients_ville.Size = new System.Drawing.Size(26, 13);
            this.LBL_clients_ville.TabIndex = 7;
            this.LBL_clients_ville.Text = "Ville";
            // 
            // TXT_clients_code
            // 
            this.TXT_clients_code.Location = new System.Drawing.Point(68, 99);
            this.TXT_clients_code.Name = "TXT_clients_code";
            this.TXT_clients_code.Size = new System.Drawing.Size(100, 20);
            this.TXT_clients_code.TabIndex = 8;
            // 
            // TXT_clients_nom
            // 
            this.TXT_clients_nom.Location = new System.Drawing.Point(68, 129);
            this.TXT_clients_nom.Name = "TXT_clients_nom";
            this.TXT_clients_nom.Size = new System.Drawing.Size(100, 20);
            this.TXT_clients_nom.TabIndex = 9;
            // 
            // TXT_clients_prenom
            // 
            this.TXT_clients_prenom.Location = new System.Drawing.Point(68, 165);
            this.TXT_clients_prenom.Name = "TXT_clients_prenom";
            this.TXT_clients_prenom.Size = new System.Drawing.Size(100, 20);
            this.TXT_clients_prenom.TabIndex = 10;
            // 
            // TXT_clients_adresse1
            // 
            this.TXT_clients_adresse1.Location = new System.Drawing.Point(68, 195);
            this.TXT_clients_adresse1.Name = "TXT_clients_adresse1";
            this.TXT_clients_adresse1.Size = new System.Drawing.Size(100, 20);
            this.TXT_clients_adresse1.TabIndex = 11;
            // 
            // TXT_clients_adresse2
            // 
            this.TXT_clients_adresse2.Location = new System.Drawing.Point(68, 221);
            this.TXT_clients_adresse2.Name = "TXT_clients_adresse2";
            this.TXT_clients_adresse2.Size = new System.Drawing.Size(100, 20);
            this.TXT_clients_adresse2.TabIndex = 12;
            // 
            // TXT_clients_CP
            // 
            this.TXT_clients_CP.Location = new System.Drawing.Point(68, 247);
            this.TXT_clients_CP.Name = "TXT_clients_CP";
            this.TXT_clients_CP.Size = new System.Drawing.Size(100, 20);
            this.TXT_clients_CP.TabIndex = 13;
            // 
            // TXT_clients_ville
            // 
            this.TXT_clients_ville.Location = new System.Drawing.Point(68, 276);
            this.TXT_clients_ville.Name = "TXT_clients_ville";
            this.TXT_clients_ville.Size = new System.Drawing.Size(100, 20);
            this.TXT_clients_ville.TabIndex = 14;
            // 
            // BTN_clients_ajouter2
            // 
            this.BTN_clients_ajouter2.Location = new System.Drawing.Point(269, 360);
            this.BTN_clients_ajouter2.Name = "BTN_clients_ajouter2";
            this.BTN_clients_ajouter2.Size = new System.Drawing.Size(75, 23);
            this.BTN_clients_ajouter2.TabIndex = 15;
            this.BTN_clients_ajouter2.Text = "Ajouter";
            this.BTN_clients_ajouter2.UseVisualStyleBackColor = true;
            this.BTN_clients_ajouter2.Click += new System.EventHandler(this.BTN_clients_ajouter2_Click);
            // 
            // BTN_clients_supprimer2
            // 
            this.BTN_clients_supprimer2.Location = new System.Drawing.Point(361, 360);
            this.BTN_clients_supprimer2.Name = "BTN_clients_supprimer2";
            this.BTN_clients_supprimer2.Size = new System.Drawing.Size(75, 23);
            this.BTN_clients_supprimer2.TabIndex = 16;
            this.BTN_clients_supprimer2.Text = "Supprimer";
            this.BTN_clients_supprimer2.UseVisualStyleBackColor = true;
            this.BTN_clients_supprimer2.Click += new System.EventHandler(this.BTN_clients_supprimer2_Click);
            // 
            // BTN_clients_editer
            // 
            this.BTN_clients_editer.Location = new System.Drawing.Point(457, 360);
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
            this.NavBarre.Location = new System.Drawing.Point(0, -1);
            this.NavBarre.Name = "NavBarre";
            this.NavBarre.Size = new System.Drawing.Size(400, 100);
            this.NavBarre.TabIndex = 18;
            this.NavBarre.TextDernier = ">|";
            this.NavBarre.TextPrecedent = "<";
            this.NavBarre.TextPremier = "|<";
            this.NavBarre.TextSuivant = ">";
            this.NavBarre.Navigation += new System.EventHandler<ControlsLibrary.NavBarEventArgs>(this.NavBarre_Navigation);
            // 
            // BTN_clients_ValiderAjout
            // 
            this.BTN_clients_ValiderAjout.Location = new System.Drawing.Point(308, 389);
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
            this.BTN_client_AnnulerAjout.Location = new System.Drawing.Point(406, 389);
            this.BTN_client_AnnulerAjout.Name = "BTN_client_AnnulerAjout";
            this.BTN_client_AnnulerAjout.Size = new System.Drawing.Size(75, 23);
            this.BTN_client_AnnulerAjout.TabIndex = 20;
            this.BTN_client_AnnulerAjout.Text = "Annuler";
            this.BTN_client_AnnulerAjout.UseVisualStyleBackColor = true;
            this.BTN_client_AnnulerAjout.Visible = false;
            this.BTN_client_AnnulerAjout.Click += new System.EventHandler(this.BTN_client_AnnulerAjout_Click);
            // 
            // EcranClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 416);
            this.Controls.Add(this.BTN_client_AnnulerAjout);
            this.Controls.Add(this.BTN_clients_ValiderAjout);
            this.Controls.Add(this.NavBarre);
            this.Controls.Add(this.BTN_clients_editer);
            this.Controls.Add(this.BTN_clients_supprimer2);
            this.Controls.Add(this.BTN_clients_ajouter2);
            this.Controls.Add(this.TXT_clients_ville);
            this.Controls.Add(this.TXT_clients_CP);
            this.Controls.Add(this.TXT_clients_adresse2);
            this.Controls.Add(this.TXT_clients_adresse1);
            this.Controls.Add(this.TXT_clients_prenom);
            this.Controls.Add(this.TXT_clients_nom);
            this.Controls.Add(this.TXT_clients_code);
            this.Controls.Add(this.LBL_clients_ville);
            this.Controls.Add(this.LBL_clients_CDP);
            this.Controls.Add(this.LBL_clients_adresse);
            this.Controls.Add(this.LBL_clients_prenom);
            this.Controls.Add(this.LBL_clients_nom);
            this.Controls.Add(this.LBL_clients_code);
            this.Controls.Add(this.dataGrid_clients);
            this.Controls.Add(this.groupBox1);
            this.Name = "EcranClients";
            this.Text = "Clients";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_clients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label LBL_clients_adresse;
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
    }
}