﻿using Clinique;
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

        private void toolStripButtonDossierMedical_Click(object sender, EventArgs e)
        {
            EcranDossierMedicaux monEcran;
            monEcran = new EcranDossierMedicaux();
            monEcran.MdiParent = this;
            monEcran.Show();
        }

        private void dossierMédicauxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranDossierMedicaux monEcran;
            monEcran = new EcranDossierMedicaux();
            monEcran.MdiParent = this;
            monEcran.Show();
        }

        private void toolStripButtonAgenda_Click(object sender, EventArgs e)
        {
            EcranAgenda monEcran;
            monEcran = new EcranAgenda();
            monEcran.MdiParent = this;
            monEcran.Show();
        }

        private void miseÀJourDuStrockVaccinCTRLMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranStockVaccin monEcran;
            monEcran = new EcranStockVaccin();
            monEcran.MdiParent = this;
            monEcran.Show();
        }

        private void miseÀJourDuBarèmeDeTarificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranBaremes monEcran;
            monEcran = new EcranBaremes();
            monEcran.MdiParent = this;
            monEcran.Show();
        }

        private void dossierClientAnimauxCTRLAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranClients monEcran;
            monEcran = new EcranClients();
            monEcran.MdiParent = this;
            monEcran.Show();
        }

        private void relancesCTRLRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranRelance monEcran;
            monEcran = new EcranRelance();
            monEcran.MdiParent = this;
            monEcran.Show();
        }

        private void toolStripButtonRelance_Click(object sender, EventArgs e)
        {
            EcranRelance monEcran;
            monEcran = new EcranRelance();
            monEcran.MdiParent = this;
            monEcran.Show();
        }


    }
}
