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
using BLL;
using BO;

namespace Clinique
{
    public partial class ecranReinitialisation : Form
    {

        public ecranReinitialisation()
        {
            InitializeComponent();
            combo_reinit_nom.DataSource = MgtVeterinaires.getVeto();
        }

        private void BTN_reinit_annuler_Click(object sender, EventArgs e)
        {
            EcranVeterinaires _ecranVeto = new EcranVeterinaires();
            EcranPrincipal _ecranParent = new EcranPrincipal();
            _ecranVeto.MdiParent = _ecranParent;
            _ecranVeto.Show();
            this.Close();
        }

        private void BTN_reinit_valider_Click(object sender, EventArgs e)
        {
            MgtVeterinaires.reinitialiserMotPasseVeto((Veterinaires)combo_reinit_nom.SelectedItem, TXT_reinit_NouveauMDP.Text,
                                          TXT_reinit_confirmMDP.Text);
            EcranVeterinaires _ecranVeto = new EcranVeterinaires();
            EcranPrincipal _ecranParent = new EcranPrincipal();
            _ecranVeto.MdiParent = _ecranParent;
            _ecranVeto.Show();
            this.Close();
        }
    }
}