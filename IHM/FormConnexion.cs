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
        }

        private void BTN_ConnexionValider_Click(object sender, EventArgs e)
        {
            EcranPrincipal _ecranPrincipale;
            bool authentification = mgtUsersLogins.Authentification(
                TXT_ConnxionNom.Text, TXT_ConnexionMdp.Text);
            if (authentification == true)
            {
                _ecranPrincipale = new EcranPrincipal();
                _ecranPrincipale.Show();
            }
            else
            {
                Console.WriteLine("truite");
            }
        }
    }
}
