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
    public partial class EcranPriseRendezVous : Form
    {
        public EcranPriseRendezVous()
        {
            InitializeComponent();

            MgtClient monMgtClient = new MgtClient();
            MgtAnimal monMgtAnimal = new MgtAnimal();
            Clients monClientSelectionne;            
            
            COMBO_Client.DataSource = monMgtClient.AfficherTout();
            monClientSelectionne = (Clients)COMBO_Client.Items[0];

            COMBO_Animal.DataSource = monMgtAnimal.AfficherTout().FindAll(t => t.CodeClient == monClientSelectionne.CodeClient);

            COMBO_Veto.DataSource = MgtVeterinaires.getVeto();

            DATE_RendezVous.MinDate = DateTime.Now;

            ChangementDate();
        }

        private void COMBO_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            MgtAnimal monMgtAnimal = new MgtAnimal();
            Clients monClientSelectionne;
            monClientSelectionne = (Clients)COMBO_Client.SelectedItem;
            COMBO_Animal.DataSource = monMgtAnimal.AfficherTout().FindAll(t => t.CodeClient == monClientSelectionne.CodeClient);
        }

        /// <summary>
        /// Remarque : Minuit n'est pas géré !
        /// </summary>
        /// <param name="pHeureChanger"></param>
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
            int mesMinutes = dateSelectionnee.AddMinutes(10).Minute;
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

        private void DATE_RendezVous_ValueChanged(object sender, EventArgs e)
        {
            ChangementDate();
        }

        private void COMBO_Heure_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangementDate(true);
        }

        private void BTN_Urgence_Click(object sender, EventArgs e)
        {
            Clients monClient = (Clients)COMBO_Client.SelectedItem;
            Animaux monAnimal = (Animaux)COMBO_Animal.SelectedItem;
            Veterinaires monVeto = (Veterinaires)COMBO_Veto.SelectedItem;
            Agendas monAgenda = new Agendas();

            monAgenda.CodeAnimal = monAnimal.CodeAnimal;
            monAgenda.CodeVeto = monVeto.CodeVeto;
            monAgenda.DateRDV = DateTime.Now;

            MgtAgenda.Ajouter(monAgenda);
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
        }
    }
}
