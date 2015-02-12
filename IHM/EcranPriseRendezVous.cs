using BLL;
using BO;
using clinique;
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
    public partial class EcranPriseRendezVous : Form
    {
        #region "Evènements"

        // Init
        public EcranPriseRendezVous()
        {
            InitializeComponent();

            MgtClient monMgtClient = MgtClient.GetInstance();
            MgtAnimal monMgtAnimal = new MgtAnimal();
            Clients monClientSelectionne;
            Veterinaires monVeto;

            COMBO_Veto.DataSource = MgtVeterinaires.getAllVeto();
            monVeto = (Veterinaires)COMBO_Veto.Items[0];

            COMBO_Client.DataSource = monMgtClient.AfficherTout();
            monClientSelectionne = (Clients)COMBO_Client.Items[0];

            COMBO_Animal.DataSource = monMgtAnimal.AfficherTout().FindAll(t => t.CodeClient == monClientSelectionne.CodeClient);
            if (COMBO_Animal.Items.Count > 0)
            {
                COMBO_Animal.SelectedIndex = 0;
            }
            else
            {
                BTN_Suppr.Enabled = false;
            }            

            DATE_RendezVous.MinDate = DateTime.Now;

            dataGrid.Columns["CodeVeto"].Visible = false;
            dataGrid.Columns["CodeAnimal"].Visible = false;

            ChangementDate();
            ChargementDataGrid();
        }

        // SelectedChanged
        private void COMBO_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            MgtAnimal monMgtAnimal = new MgtAnimal();
            MgtClient monMgtClient = MgtClient.GetInstance();
            Clients monClientSelectionne = (Clients)COMBO_Client.SelectedItem;

            COMBO_Animal.DataSource = monMgtAnimal.AfficherTout().FindAll(t => t.CodeClient == monClientSelectionne.CodeClient);
            ChargementDataGrid();
        }

        private void DATE_RendezVous_ValueChanged(object sender, EventArgs e)
        {
            MgtClient monMgtClient = MgtClient.GetInstance();
            MgtAnimal monMgtAnimal = new MgtAnimal();
            Clients monClientSelectionne;
            Animaux monAnimal;
            Veterinaires monVeto;

            monVeto = (Veterinaires)COMBO_Veto.SelectedItem;
            monAnimal = (Animaux)COMBO_Animal.SelectedItem;
            monClientSelectionne = (Clients)COMBO_Client.SelectedItem;

            ChangementDate();
            ChargementDataGrid();
        }

        private void COMBO_Heure_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangementDate(true);
        }

        private void COMBO_Veto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargementDataGrid();
        }

        // Click
        private void BTN_Urgence_Click(object sender, EventArgs e)
        {
            Agendas monAgenda = new Agendas();
            Clients monClient = (Clients)COMBO_Client.SelectedItem;
            Animaux monAnimal = (Animaux)COMBO_Animal.SelectedItem;
            Veterinaires monVeto = (Veterinaires)COMBO_Veto.SelectedItem;            

            monAgenda.CodeAnimal = monAnimal.CodeAnimal;
            monAgenda.CodeVeto = monVeto.CodeVeto;
            monAgenda.DateRDV = DateTime.Now;

            MgtAgenda.Ajouter(monAgenda);

            ChargementDataGrid();
        }

        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            Clients monClient = (Clients)COMBO_Client.SelectedItem;
            Animaux monAnimal = (Animaux)COMBO_Animal.SelectedItem;
            Veterinaires monVeto = (Veterinaires)COMBO_Veto.SelectedItem;
            Agendas monAgenda = new Agendas();

            monAgenda.CodeAnimal = monAnimal.CodeAnimal;
            monAgenda.CodeVeto = monVeto.CodeVeto;
            try
            {
                monAgenda.DateRDV = new DateTime(DATE_RendezVous.Value.Year, DATE_RendezVous.Value.Month, DATE_RendezVous.Value.Day, (int)COMBO_Heure.SelectedValue, (int)COMBO_Minutes.SelectedValue, 0);
            }
            catch (Exception ex)
            {
                throw new Exception("Problème lors du passage de la date concernant l'ajout d'un RDV en urgence :\n" + ex.Message);
            }

            MgtAgenda.Ajouter(monAgenda);

            ChargementDataGrid();
        }

        private void BTN_Suppr_Click(object sender, EventArgs e)
        {
            Agendas monAgenda = new Agendas();
            monAgenda.CodeAnimal = (Guid)dataGrid.CurrentRow.Cells["CodeAnimal"].Value;
            monAgenda.CodeVeto = (Guid)dataGrid.CurrentRow.Cells["CodeVeto"].Value;
            monAgenda.DateRDV = (DateTime)dataGrid.CurrentRow.Cells["DateRDV"].Value;

            MgtAgenda.Supprimer(monAgenda);

            ChargementDataGrid();
        }

        private void BTN_AddAnimal_Click(object sender, EventArgs e)
        {
            EcranAnimaux monEcran;
            monEcran = new EcranAnimaux();
            monEcran.Show();
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_AddClient_Click(object sender, EventArgs e)
        {
            EcranClients monEcran;
            monEcran = new EcranClients();
            monEcran.Show();
        }

        #endregion

        #region "Méthodes et procedures"
        
        /// <summary>
        /// Recharge la DataGrid
        /// </summary>
        private void ChargementDataGrid(bool estInitialisation = false)
        {
            if (!estInitialisation)
            {
                MgtClient monMgtClient = MgtClient.GetInstance();
                MgtAnimal monMgtAnimal = new MgtAnimal();
                Clients monClientSelectionne;
                Animaux monAnimal;
                Veterinaires monVeto;

                monVeto = (Veterinaires)COMBO_Veto.SelectedItem;
                monAnimal = (Animaux)COMBO_Animal.SelectedItem;
                monClientSelectionne = (Clients)COMBO_Client.SelectedItem;

                dataGrid.DataSource = MgtAgenda.AfficherToutAvecDetail().FindAll(x => x.CodeVeto == monVeto.CodeVeto && x.DateRDV.Value.Date == DateTime.Parse(DATE_RendezVous.Value.ToString()).Date);
            }
        }

        /// <summary>
        /// Recharge les COMBO 'heure et de minutes suivant la sélectionde la date
        /// Remarque : Minuit n'est pas géré !
        /// </summary>
        /// <param name="pHeureChanger">Détermine si l'utilisateur à sélectionner une autre heure dans la COMBO dédiée</param>
        private void ChangementDate(bool pHeureChanger = false)
        {
            DateTime dateSelectionnee;
            List<int> listeHeure = new List<int>();
            List<int> listeMinute = new List<int>();
            bool premierTour = true;

            // Heure
            if (!pHeureChanger)
            {
                dateSelectionnee = DateTime.Parse(DATE_RendezVous.Value.ToString());
                for (int j = dateSelectionnee.Hour; j <= 24; j++)
                {
                    if (dateSelectionnee.Date == DateTime.Now.Date && dateSelectionnee.AddMinutes(10) < new DateTime(dateSelectionnee.Year, dateSelectionnee.Month, dateSelectionnee.Day, dateSelectionnee.Hour, 40, 59))
                    {
                        listeHeure.Add(j);
                    }
                    else if (dateSelectionnee.Date != DateTime.Now.Date)
                    {
                        if (premierTour)
                        {
                            j = 1;
                            listeHeure.Add(j);
                            premierTour = false;
                        }
                        else
                        {
                            listeHeure.Add(j);
                        }
                    }
                    else if (dateSelectionnee.Date == DateTime.Now.Date && DateTime.Now.Hour < j)
                    {
                        listeHeure.Add(j);
                    }
                }

                COMBO_Heure.DataSource = listeHeure;
            }

            // Minute            
            dateSelectionnee = DateTime.Parse(DATE_RendezVous.Value.ToString());
            int mesMinutes;

            if (dateSelectionnee.Day > DateTime.Now.Date.Day || DateTime.Now.Date.Minute >= 40 || (int)COMBO_Heure.SelectedItem > DateTime.Now.Hour)
            {
                mesMinutes = 0;
                listeMinute.Add(mesMinutes);
            }
            else
            {
                mesMinutes = dateSelectionnee.AddMinutes(10).Minute;
            }

            while (mesMinutes < 60)
            {
                if (mesMinutes <= 10)
                {
                    mesMinutes = 15;
                }
                else if (mesMinutes > 10 && mesMinutes < 25)
                {
                    mesMinutes = 30;
                }
                else if (mesMinutes >= 25 && mesMinutes < 40)
                {
                    mesMinutes = 45;
                    listeMinute.Add(mesMinutes);
                    break;
                }
                else
                {
                    mesMinutes = 0;
                }

                listeMinute.Add(mesMinutes);
            }
            COMBO_Minutes.DataSource = listeMinute;
        }

        #endregion                              
    }
}
