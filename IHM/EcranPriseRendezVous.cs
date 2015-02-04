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

        private void ChangementDate()
        {
            DateTime dateSelectionnee;
            List<int> listeHeure = new List<int>();
            List<int> listeMinute = new List<int>();

            // Heure
            dateSelectionnee = DateTime.Parse(DATE_RendezVous.Value.ToString());
            for (int i = dateSelectionnee.Hour; i <= 24; i++)
            {
                listeHeure.Add(i);
            }
            COMBO_Heure.DataSource = listeHeure;

            // Minute
            dateSelectionnee = DateTime.Parse(DATE_RendezVous.Value.ToString());
            for (int i = dateSelectionnee.AddMinutes(15).Minute; i < 60; i = i + 15)
            {
                listeMinute.Add(i);
            }
            COMBO_Minutes .DataSource = listeMinute;
        }

        private void DATE_RendezVous_ValueChanged(object sender, EventArgs e)
        {
            ChangementDate();
        }
    }
}
