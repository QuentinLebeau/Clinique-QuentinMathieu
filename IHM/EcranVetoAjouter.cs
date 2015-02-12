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
            groupBoxAjoutVetoErreur.Visible = false;
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
                MgtVeterinaires.addVeto(TXT_ajoutVeto_Nom.Text, TXT_ajoutVeto_prenom.Text
                    , TXT_ajoutVeto_motPasse.Text);
                EcranVeterinaires _ecranVeto = new EcranVeterinaires();
                _ecranVeto.EcranVeterinaires_Load(sender, e);
                this.Close();
            }
            catch (Exception ex)
            {
                LBL_ajoutVeto_erreur.Text = ("Problème dans les informations saisies. \n" + ex.Message);
                LBL_ajoutVeto_erreur.ForeColor = System.Drawing.Color.Red;
                groupBoxAjoutVetoErreur.Visible = true;
                TXT_ajoutVeto_Nom.Focus();
            }
        }

        private void TXT_ajoutVeto_Nom_TextChanged(object sender, EventArgs e)
        {
            groupBoxAjoutVetoErreur.Visible = false;
        }

        private void TXT_ajoutVeto_prenom_TextChanged(object sender, EventArgs e)
        {
            groupBoxAjoutVetoErreur.Visible = false;
        }

        private void TXT_ajoutVeto_motPasse_TextChanged(object sender, EventArgs e)
        {
            groupBoxAjoutVetoErreur.Visible = false;
        }
    }
}
