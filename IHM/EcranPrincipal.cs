using Clinique;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinique
{
    public partial class EcranPrincipal : Form
    {
        public EcranPrincipal()
        {
            InitializeComponent();
        }

        private void EcranPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void vétérinairesCTRLTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranVeterinaires _ecranVeterinaire;
            _ecranVeterinaire = new EcranVeterinaires();
            _ecranVeterinaire.MdiParent = this;
            _ecranVeterinaire.Show();
        }

        private void priseDeRendezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranPriseRendezVous monEcran;
            monEcran = new EcranPriseRendezVous();
            monEcran.MdiParent = this;
            monEcran.Show();
        }

        private void toolStripButtonRDV_Click(object sender, EventArgs e)
        {
            EcranPriseRendezVous monEcran;
            monEcran = new EcranPriseRendezVous();
            monEcran.MdiParent = this;
            monEcran.Show();
        }

        private void toolStripButtonClientAnimal_Click(object sender, EventArgs e)
        {
            EcranClients monEcran;
            monEcran = new EcranClients();
            monEcran.MdiParent = this;
            monEcran.Show();
        }

        private void agendaCTRLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranAgenda monEcran;
            monEcran = new EcranAgenda();
            monEcran.MdiParent = this;
            monEcran.Show();
        }
    }
}
