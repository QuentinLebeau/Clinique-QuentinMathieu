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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.BTN_clients_ajouter2 = new System.Windows.Forms.Button();
            this.BTN_clients_supprimer2 = new System.Windows.Forms.Button();
            this.BTN_clients_editer = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.navBar1 = new ControlsLibrary.NavBar();
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(68, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(68, 165);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(68, 195);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(68, 221);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(68, 247);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 13;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(68, 276);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 14;
            // 
            // BTN_clients_ajouter2
            // 
            this.BTN_clients_ajouter2.Location = new System.Drawing.Point(269, 360);
            this.BTN_clients_ajouter2.Name = "BTN_clients_ajouter2";
            this.BTN_clients_ajouter2.Size = new System.Drawing.Size(75, 23);
            this.BTN_clients_ajouter2.TabIndex = 15;
            this.BTN_clients_ajouter2.Text = "Ajouter";
            this.BTN_clients_ajouter2.UseVisualStyleBackColor = true;
            // 
            // BTN_clients_supprimer2
            // 
            this.BTN_clients_supprimer2.Location = new System.Drawing.Point(361, 360);
            this.BTN_clients_supprimer2.Name = "BTN_clients_supprimer2";
            this.BTN_clients_supprimer2.Size = new System.Drawing.Size(75, 23);
            this.BTN_clients_supprimer2.TabIndex = 16;
            this.BTN_clients_supprimer2.Text = "Supprimer";
            this.BTN_clients_supprimer2.UseVisualStyleBackColor = true;
            // 
            // BTN_clients_editer
            // 
            this.BTN_clients_editer.Location = new System.Drawing.Point(442, 360);
            this.BTN_clients_editer.Name = "BTN_clients_editer";
            this.BTN_clients_editer.Size = new System.Drawing.Size(75, 23);
            this.BTN_clients_editer.TabIndex = 17;
            this.BTN_clients_editer.Text = "Editer";
            this.BTN_clients_editer.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // navBar1
            // 
            this.navBar1.ApresEnable = true;
            this.navBar1.AvantEnable = true;
            this.navBar1.ButtonBorder = 1;
            this.navBar1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.navBar1.ImageDernier = null;
            this.navBar1.ImagePrecedent = null;
            this.navBar1.ImagePremier = null;
            this.navBar1.ImageSuivant = null;
            this.navBar1.Location = new System.Drawing.Point(0, -1);
            this.navBar1.Name = "navBar1";
            this.navBar1.Size = new System.Drawing.Size(400, 100);
            this.navBar1.TabIndex = 18;
            this.navBar1.TextDernier = ">|";
            this.navBar1.TextPrecedent = "<";
            this.navBar1.TextPremier = "|<";
            this.navBar1.TextSuivant = ">";
            this.navBar1.Navigation += new System.EventHandler<ControlsLibrary.NavBarEventArgs>(this.navBar1_Navigation);
            // 
            // EcranClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 416);
            this.Controls.Add(this.navBar1);
            this.Controls.Add(this.BTN_clients_editer);
            this.Controls.Add(this.BTN_clients_supprimer2);
            this.Controls.Add(this.BTN_clients_ajouter2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button BTN_clients_ajouter2;
        private System.Windows.Forms.Button BTN_clients_supprimer2;
        private System.Windows.Forms.Button BTN_clients_editer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private ControlsLibrary.NavBar navBar1;
    }
}