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
using clinique;

namespace Clinique
{
    public partial class EcranVetoAjouter : Form
    {
        public EcranVetoAjouter()
        {
            InitializeComponent();
        }

        private void BYN_ajotuVeto_Annuler_Click(object sender, EventArgs e)
        {
            EcranVeterinaires _ecranVeto = new EcranVeterinaires();
            EcranPrincipal _ecranParent = new EcranPrincipal();
            _ecranVeto.MdiParent = _ecranParent;
            _ecranVeto.Show();
            this.Close();
        }

        private void BTN_ajoutVeto_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                MgtVeterinaires.ajouterVeto(TXT_ajoutVeto_Nom.Text, TXT_ajoutVeto_prenom.Text
                    , TXT_ajoutVeto_motPasse.Text);
            }
            catch (Exception ex)
            {

                throw new Exception("Problème dans les informations saisies. \n" + ex.Message);
            }
            EcranVeterinaires _ecranVeto = new EcranVeterinaires();
            _ecranVeto.EcranVeterinaires_Load(sender, e);
            this.Close();
        }
    }
}
