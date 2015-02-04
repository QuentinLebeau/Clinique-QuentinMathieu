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
        public void PassValue(Veterinaires veto)
        {
            veto = (Veterinaires)DataGridVeto.CurrentRow.DataBoundItem;
        }

        public EcranVeterinaires()
        {
            //tets
            InitializeComponent();
        }

        private void EcranVeterinaires_Load(object sender, EventArgs e)
        {

            DataGridVeto.DataSource = MgtVeterinaires.getVeto();
        }

        private void BTN_ajouterVeto_Click(object sender, EventArgs e)
        {
            EcranVetoAjouter _ecranAjouterVeterinaire;
            _ecranAjouterVeterinaire = new EcranVetoAjouter();
            _ecranAjouterVeterinaire.Show();
            DataGridVeto.DataSource = MgtVeterinaires.getVeto();
        }

        private void BTN_SupprimerVeto_Click(object sender, EventArgs e)
        {
            Veterinaires veto = (Veterinaires)DataGridVeto.CurrentRow.DataBoundItem;
            MgtVeterinaires.supprimerVeto(veto);
            EcranVeterinaires_Load(sender, e);
        }

        private void BTN_ReinitialiserVeto_Click(object sender, EventArgs e)
        {
            Veterinaires veto = (Veterinaires)DataGridVeto.CurrentRow.DataBoundItem;
            ecranReinitialisation _ecranReinit;
            _ecranReinit = new ecranReinitialisation();
            _ecranReinit.recupCode(veto);
            _ecranReinit.Show();
        }
    }
}
