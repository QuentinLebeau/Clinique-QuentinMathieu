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
    public partial class EcranDossierMedicaux : Form
    {
        MgtAnimal monMgtAnimal = new MgtAnimal();
        Form _monEcran;

        /// <summary>
        /// Constreur permettant la redirection personalisé lorsq'une ligne du DataGridView est sélectionnée
        /// </summary>
        /// <param name="pEcranRetour">La classe de l'IHM qui sera appelé lors de la sélection d'un consultation</param>
        public EcranDossierMedicaux(Form pEcranRetour = null) 
        {
            InitializeComponent();
            _monEcran = pEcranRetour;

            COMBO_Client.DataSource = MgtClient.GetInstance().AfficherTout();
            COMBO_Tatouage.DataSource = monMgtAnimal.AfficherTout().Select(x => x.Tatouage).Distinct().ToList<string>();
            COMBO_Animal.DataSource = monMgtAnimal.AfficherTout().FindAll(y => y.CodeClient == ((Clients)COMBO_Client.SelectedItem).CodeClient).ToList<Animaux>();

            if (COMBO_Animal.Items.Count > 0)
            {
                GRID_Consultation.DataSource = MgtConsultation.AfficherTout().FindAll(v => v.CodeAnimal.Value == ((Animaux)COMBO_Animal.SelectedItem).CodeAnimal.Value).ToList<Consultation>();

                if (GRID_Consultation.Rows.Count > 0)
                {
                    TXT_Commentaire.Text = GRID_Consultation.Rows[0].Cells["Commentaire"].Value.ToString();
                }
            }
        }

        private void COMBO_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            COMBO_Animal.DataSource = monMgtAnimal.AfficherTout().FindAll(y => y.CodeClient == ((Clients)COMBO_Client.SelectedItem).CodeClient).ToList<Animaux>();
            LBL_Proprio.ForeColor = Color.Red;
            LBL_Tatou.ForeColor = Color.Black;
        }

        private void COMBO_Animal_SelectedIndexChanged(object sender, EventArgs e)
        {
            GRID_Consultation.DataSource = MgtConsultation.AfficherTout().FindAll(v => v.CodeAnimal.Value == ((Animaux)COMBO_Animal.SelectedItem).CodeAnimal.Value).ToList<Consultation>();

            if (GRID_Consultation.Rows.Count > 0)
            {
                TXT_Commentaire.Text = GRID_Consultation.Rows[0].Cells["Commentaire"].Value.ToString();
            }
            else
            {
                TXT_Commentaire.Text = null;
            }
        }

        private void GRID_Consultation_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
            if (_monEcran != null)
            {
                //EcranConsultation monEcran;
                //monEcran = new EcranConsultation(Guid.Parse(GRID_Consultation.Rows[e.RowIndex].Cells["CodeConsultation"].Value.ToString()));
                //monEcran.Show();
            }            
        }

        private void COMBO_Tatouage_SelectedIndexChanged(object sender, EventArgs e)
        {
            COMBO_Animal.DataSource = monMgtAnimal.AfficherTout().FindAll(y => y.Tatouage == COMBO_Tatouage.SelectedItem.ToString()).ToList<Animaux>();
            LBL_Proprio.ForeColor = Color.Black;
            LBL_Tatou.ForeColor = Color.Red;
        }
    }
}
