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
    public partial class EcranConsultation : Form
    {
        MgtAnimal monMgtAnimal = new MgtAnimal();
        Agendas _monAgenda = new Agendas();
        Animaux _monAnimal = new Animaux();
        Veterinaires _monVeto = new Veterinaires();
        Consultation _maConsu = new Consultation();               

        #region "Evènement"

        // Init
        public EcranConsultation(Agendas pAgenda)
        {
            InitializeComponent();

            _monAgenda = pAgenda;
            _monAnimal = monMgtAnimal.AfficherUneSeul(pAgenda.CodeAnimal.Value);
            _monVeto = MgtVeterinaires.getOneVeto(pAgenda.CodeVeto.Value);

            TXT_CodeAnimal.Text = _monAnimal.CodeAnimal.Value.ToString();
            TXT_Couleur.Text = _monAnimal.Couleur;
            TXT_Espece.Text = _monAnimal.Race.Espece;
            TXT_NomAnimal.Text = _monAnimal.NomAnimal;
            TXT_Race.Text = _monAnimal.Race.Race;
            TXT_Sexe.Text = _monAnimal.Sexe.ToString();
            TXT_Tatouage.Text = _monAnimal.Tatouage;

            DATE_Acte.Text = pAgenda.DateRDV.Value.ToString();

            COMBO_Veto.DataSource = MgtVeterinaires.getAllVeto();
            for (int i = 0; i < COMBO_Veto.Items.Count; i++)
            {
                if (((Veterinaires)COMBO_Veto.Items[i]).CodeVeto.Value == pAgenda.CodeVeto.Value)
                {
                    COMBO_Veto.SelectedIndex = i;
                    break;
                }
            }
            COMBO_TypeActe.DataSource = MgtBaremes.AffichierTout().Select(x => x.TypeActe).Distinct().ToList<string>();
            ChangementCOMBO(true, false);
        }

        // Clic
        private void BTN_AjouterActe_Click(object sender, EventArgs e)
        {
            COMBO_Veto.Enabled = true;
            COMBO_TypeActe.Enabled = true;
            COMBO_LibelleActe.Enabled = true;

            TXT_Prix.Enabled = true;

            ChangementCOMBO(false, true);

            _maConsu = MgtConsultation.AfficherTout().Find(x => x.CodeAnimal == Guid.Parse(TXT_CodeAnimal.Text) && x.CodeVeto == ((Veterinaires)COMBO_Veto.SelectedItem).CodeVeto.Value && x.DateConsultation == DateTime.Parse(DATE_Acte.Text));

            if (_maConsu == null)
            {
                _maConsu = new Consultation(); 
                _maConsu.CodeAnimal = _monAnimal.CodeAnimal.Value;
                _maConsu.CodeVeto = _monVeto.CodeVeto.Value;
                _maConsu.Commentaire = TXT_Commentaire.Text;
                _maConsu.DateConsultation = DateTime.Parse(DATE_Acte.Text);

                MgtConsultation.AjouterNouvelleConsu(_maConsu);
                _maConsu = MgtConsultation.AfficherTout().Find(x => x.CodeAnimal == Guid.Parse(TXT_CodeAnimal.Text) && x.CodeVeto == ((Veterinaires)COMBO_Veto.SelectedItem).CodeVeto.Value && x.DateConsultation == DateTime.Parse(DATE_Acte.Text));

                ChargementGrid();
                BTN_Supprimer_Click(null, null); // Car insère une ligne à cause de la procedure stocké
            }

            ChargementGrid();

            BTN_AjouterActe.Enabled = false;
            BTN_AnnulerConsu.Enabled = true;
        }

        private void BTN_Enregistrer_Click(object sender, EventArgs e)
        {
            LignesConsultations maLigneConsu = new LignesConsultations();
            Baremes monBareme = MgtBaremes.AfficherUnSeul((Baremes)COMBO_LibelleActe.SelectedItem);

            maLigneConsu.Archive = false;
            maLigneConsu.CodeConsultation = _maConsu.CodeConsultation;
            maLigneConsu.CodeGroupement = monBareme.CodeGroupement;
            maLigneConsu.Prix = float.Parse(TXT_Prix.Text);
            maLigneConsu.RappelEnvoye = false;

            if (!String.IsNullOrWhiteSpace(monBareme.DateVigueur))
            {
                maLigneConsu.DateVigueur = monBareme.DateVigueur;
            }

            MgtLigneConsultation.Ajouter(maLigneConsu);

            ChargementGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MgtConsultation.Supprimer(_maConsu);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _maConsu.Commentaire = TXT_Commentaire.Text;

            MgtConsultation.Modifier(_maConsu);
        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            MgtLigneConsultation.Supprimer((LignesConsultations)GRID_LigneConsu.CurrentRow.DataBoundItem);

            ChargementGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EcranDossierMedicaux monEcran = new EcranDossierMedicaux();
            monEcran.Show();
        }

        // SelectionChange
        private void COMBO_TypeActe_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangementCOMBO(true, false);
        }

        private void COMBO_LibelleActe_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangementCOMBO(false, true);
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TXT_Prix.Text))
            {
                if (!String.IsNullOrWhiteSpace(TXT_Mini.Text) && float.Parse(TXT_Prix.Text) >= float.Parse(TXT_Mini.Text) && !String.IsNullOrWhiteSpace(TXT_Maxi.Text) && float.Parse(TXT_Prix.Text) <= float.Parse(TXT_Maxi.Text))
                {
                    BTN_Enregistrer.Enabled = true;
                }
                else if (String.IsNullOrWhiteSpace(TXT_Mini.Text) && String.IsNullOrWhiteSpace(TXT_Maxi.Text))
                {
                    BTN_Enregistrer.Enabled = true;
                }
                else
                {
                    BTN_Enregistrer.Enabled = false;
                }
            }
            else
            {
                BTN_Enregistrer.Enabled = false;
            }
        }                     

        #endregion

        #region "Méthodes et fonctions"

        /// <summary>
        /// Met à jour les COMBOX et TXT suivant la sélection
        /// </summary>
        /// <param name="pTypeChange">Si c'est la COMBO des type qui à été modifié</param>
        /// <param name="pLibelleChange">Si c'est la COMBO des libelles qui à été modifié</param>
        private void ChangementCOMBO(bool pTypeChange, bool pLibelleChange)
        {
            if (pTypeChange)
            {
                COMBO_LibelleActe.DataSource = MgtBaremes.AffichierTout().FindAll(y => y.TypeActe == COMBO_TypeActe.SelectedValue.ToString()).ToList<Baremes>();
            }

            if (pTypeChange || pLibelleChange)
            {
                TXT_Maxi.Text = MgtBaremes.AfficherUnSeul((Baremes)COMBO_LibelleActe.SelectedItem).TarifMaxi.ToString();
                TXT_Mini.Text = MgtBaremes.AfficherUnSeul((Baremes)COMBO_LibelleActe.SelectedItem).TarifMini.ToString();

                if (!String.IsNullOrWhiteSpace(TXT_Maxi.Text) && !String.IsNullOrWhiteSpace(TXT_Mini.Text))
                {
                    TXT_Prix.Text = (((float.Parse(TXT_Maxi.Text) - float.Parse(TXT_Mini.Text)) / 2) + float.Parse(TXT_Mini.Text)).ToString();
                }
                else
                {
                    TXT_Prix.Text = null;
                    TXT_Maxi.Text = null;
                    TXT_Mini.Text = null;
                }
            }
        }

        /// <summary>
        /// Recharge la DataGridView avec les lignes de la consultation en cours + compteur d'actes + total actes
        /// </summary>
        private void ChargementGrid()
        {
            GRID_LigneConsu.DataSource = MgtLigneConsultation.AfficherTout().FindAll(x => x.CodeConsultation.Value == _maConsu.CodeConsultation.Value).ToList<LignesConsultations>();
            LBL_NbActe.Text = GRID_LigneConsu.Rows.Count.ToString();

            if (GRID_LigneConsu.Rows.Count > 0)
            {
                GRID_LigneConsu.Rows[0].Selected = true;
                BTN_Supprimer.Enabled = true;

                for (int i = 0; i < GRID_LigneConsu.Rows.Count; i++)
                {
                    TXT_Total.Text = (float.Parse(TXT_Total.Text) + ((LignesConsultations)GRID_LigneConsu.Rows[i].DataBoundItem).Prix.Value).ToString();
                }
            }
            else
            {
                BTN_Supprimer.Enabled = false;
            }
        }

        #region "Conneries à Mathieu"

        private void combo_consultation_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_consultation_libelle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox_consultation_animal_Enter(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBL_consultation_tatouage_Click(object sender, EventArgs e)
        {

        }

        private void LBL_consultation_sexe_Click(object sender, EventArgs e)
        {

        }

        private void LBL_consultation_couleur_Click(object sender, EventArgs e)
        {

        }

        private void LBL_consultation_race_Click(object sender, EventArgs e)
        {

        }

        private void LBL_consultation_nom_Click(object sender, EventArgs e)
        {

        }

        private void LBL_consultation_espece_Click(object sender, EventArgs e)
        {

        }

        private void LBL_consultation_code_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TXT_consultation_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBL_consultation_libelle_Click(object sender, EventArgs e)
        {

        }

        private void LBL_consultation_type_Click(object sender, EventArgs e)
        {

        }

        private void LBL_consultation_veterinaire_Click(object sender, EventArgs e)
        {

        }

        private void LBL_consultation_dateActe_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_consultation_actes_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LBL_consultation_min_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_consultation_veto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_consultation_NbActes_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBL_consultation_commentaire_Click(object sender, EventArgs e)
        {

        }

        private void LargeTXT_consultation_commentaire_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion
                
    }
}
