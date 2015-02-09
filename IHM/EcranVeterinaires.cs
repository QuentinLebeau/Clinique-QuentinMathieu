using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using BLL;
using Clinique;

namespace clinique
{
    public partial class EcranVeterinaires : Form
    {
      
        public EcranVeterinaires()
        {
            //tets
            InitializeComponent();
        }

        public void EcranVeterinaires_Load(object sender, EventArgs e)
        {

            DataGridVeto.DataSource = MgtVeterinaires.getAllVeto();
        }

        private void BTN_ajouterVeto_Click(object sender, EventArgs e)
        {
            EcranVetoAjouter _ecranAjouterVeterinaire;
            _ecranAjouterVeterinaire = new EcranVetoAjouter();
            _ecranAjouterVeterinaire.Show();
            DataGridVeto.DataSource = MgtVeterinaires.getAllVeto();
        }

        private void BTN_SupprimerVeto_Click(object sender, EventArgs e)
        {
            Veterinaires veto = (Veterinaires)DataGridVeto.CurrentRow.DataBoundItem;
            MgtVeterinaires.deleteVeto(veto);
            EcranVeterinaires_Load(sender, e);
        }

        private void BTN_ReinitialiserVeto_Click(object sender, EventArgs e)
        {
            Veterinaires veto = (Veterinaires)DataGridVeto.CurrentRow.DataBoundItem;
            ecranReinitialisation _ecranReinit;
            _ecranReinit = new ecranReinitialisation();
            _ecranReinit.Show();
            DataGridVeto.DataSource = MgtVeterinaires.getAllVeto();
        }

        public void DataGridVeto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
