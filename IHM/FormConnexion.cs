using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace clinique
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
            LBL_connexion_erreur.Visible = false;
        }

        private void BTN_ConnexionValider_Click(object sender, EventArgs e)
        {
            EcranPrincipal _ecranPrincipale;
            bool authentification = MgtUsersLogins.Authentification(
                TXT_ConnxionNom.Text, TXT_ConnexionMdp.Text);
            if (authentification == true)
            {
                _ecranPrincipale = new EcranPrincipal();
                _ecranPrincipale.Show();
                this.Hide();
            }
            else
            {
                LBL_connexion_erreur.Visible = true;
                LBL_connexion_erreur.Text = "Mot de passe ou login incorrect... Cordialement.";
                LBL_connexion_erreur.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void TXT_ConnxionNom_MouseClick(object sender, MouseEventArgs e)
        {
            LBL_connexion_erreur.Visible = false;
            TXT_ConnxionNom.Text = null;
            TXT_ConnexionMdp.Text = null;
        }

        private void TXT_ConnexionMdp_MouseClick(object sender, MouseEventArgs e)
        {
            LBL_connexion_erreur.Visible = false;
            TXT_ConnxionNom.Text = null;
            TXT_ConnexionMdp.Text = null;
        }
    }
}
