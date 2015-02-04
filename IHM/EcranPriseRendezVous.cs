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
        }

        private void EcranPriseRendezVous_Load(object sender, EventArgs e)
        {
            
        }

        private void COMBO_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            MgtAnimal monMgtAnimal = new MgtAnimal();
            Clients monClientSelectionne;
            monClientSelectionne = (Clients)COMBO_Client.SelectedItem;
            COMBO_Animal.DataSource = monMgtAnimal.AfficherTout().FindAll(t => t.CodeClient == monClientSelectionne.CodeClient);
        }
    }
}
