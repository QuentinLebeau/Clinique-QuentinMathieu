using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinique
{
    public partial class EcranAnimaux : Form
    {

        #region "Evènements"

        Animaux monAncienAnimal = new Animaux();
        Animaux monNouvelAnimal = new Animaux();
        MgtAnimal monMgtAnimal = new MgtAnimal();
        Guid? _codeAnimal;

        // Init
        public EcranAnimaux(Guid? pCodeAnimal = null)
        {
            InitializeComponent();
            _codeAnimal = pCodeAnimal;
            Chargment(_codeAnimal);
        }
        
        // Click
        private void LBL_animaux_code_Click(object sender, EventArgs e)
        {

        }

        private void BTN_animaux_annuler_Click(object sender, EventArgs e)
        {
            Chargment(_codeAnimal);
        }

        private void BTN_animaux_valider_Click(object sender, EventArgs e)
        {
            if (_codeAnimal == null)
            {
                PrendsNouvellesValeurs();
                monMgtAnimal.Ajouter(monNouvelAnimal);
            }
            else
            {
                PrendsNouvellesValeurs();
                monMgtAnimal.Modifier(monNouvelAnimal);
            }
        }

        private void BTN_animaux_DossierMedical_Click(object sender, EventArgs e)
        {

        }

        // SelectedChanged
        private void combo_animaux_espece_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_animaux_race.DataSource = (from occurence in MgtRaces.AfficherTout()
                                             where occurence.Espece == combo_animaux_espece.SelectedValue.ToString()
                                             select occurence.Race).ToList<string>();
        }

        #endregion

        #region "Méthodes et fonctions"

        /// <summary>
        /// Recharge tout le formulaire, si jamais c'était une modif, remet les valeurs de départ
        /// </summary>
        /// <param name="pCodeAnimal"></param>
        private void Chargment(Guid? pCodeAnimal = null)
        {
            combo_animaux_Clients.DataSource = MgtClient.GetInstance().AfficherTout();
            combo_animaux_espece.DataSource = (from occurence in MgtRaces.AfficherTout()                                               
                                               select occurence.Espece).ToList<string>();
            combo_animaux_race.DataSource = (from occurence in MgtRaces.AfficherTout()
                                             where occurence.Espece == combo_animaux_espece.SelectedValue.ToString()
                                            select occurence.Race).ToList<string>();            
            combo_animaux_sexe.DataSource = new List<string> { "Mâle", "Femmelle", "Hérmaphrodite" };

            TXT_animaux_code.Enabled = false;

            if (pCodeAnimal == null)
            {
                BTN_animaux_valider.Text = "Ajouter";
                combo_animaux_Clients.Focus();

                TXT_animaux_code.Text = null;
                TXT_animaux_couleur.Text = null;
                TXT_animaux_nom.Text = null;
                TXT_animaux_tatouage.Text = null;
            }
            else
            {
                BTN_animaux_valider.Text = "Modifier";

                monAncienAnimal = monMgtAnimal.AfficherUneSeul(pCodeAnimal.Value);
                combo_animaux_espece.SelectedItem = monAncienAnimal.Race.Espece;
                combo_animaux_race.SelectedItem = monAncienAnimal.Race.Race;

                int i = -1;
                foreach (string occurence in combo_animaux_sexe.Items)
                {
                    i++;
                    if (occurence[0] == monAncienAnimal.Sexe.Value)
                    {
                        combo_animaux_sexe.SelectedIndex = i;
                        break;
                    }
                }

                i = -1;
                foreach (Clients occurence in combo_animaux_Clients.Items)
                {
                    i++;
                    if (occurence.CodeClient.Value == monAncienAnimal.CodeClient.Value)
                    {
                        combo_animaux_Clients.SelectedIndex = i;
                        break;
                    }
                }

                TXT_animaux_code.Text = monAncienAnimal.CodeAnimal.ToString();
                TXT_animaux_couleur.Text = monAncienAnimal.Couleur;
                TXT_animaux_nom.Text = monAncienAnimal.NomAnimal;
                TXT_animaux_tatouage.Text = monAncienAnimal.Tatouage;

                monNouvelAnimal = monAncienAnimal;
            }
        }

        /// <summary>
        /// Ajoute dans 'monNouvelAnimal' toutes les valeurs des COMBO et TEXT box
        /// </summary>
        private void PrendsNouvellesValeurs()
        {
            monNouvelAnimal.CodeClient = ((Clients)combo_animaux_Clients.SelectedItem).CodeClient.Value;
            monNouvelAnimal.Race = new Races(combo_animaux_race.SelectedValue.ToString(), combo_animaux_espece.SelectedValue.ToString());
            monNouvelAnimal.Sexe = combo_animaux_sexe.SelectedValue.ToString()[0];
            monNouvelAnimal.Couleur = TXT_animaux_couleur.Text;
            monNouvelAnimal.NomAnimal = TXT_animaux_nom.Text;
            monNouvelAnimal.Tatouage = TXT_animaux_tatouage.Text;
        }

        #endregion

    }
}
