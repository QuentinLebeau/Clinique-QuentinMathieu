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
        }

        public void recupCode(Veterinaires veto)
        {
            Veterinaires _veto = veto;
        }

        private void BTN_reinit_valider_Click(object sender, EventArgs e, Veterinaires veto)
        {

            MgtVeterinaires.reinitialiserMotPasseVeto(veto, TXT_reinit_NouveauMDP.Text,
                                                      TXT_reinit_confirmMDP.Text);
        }

        private void BTN_reinit_annuler_Click(object sender, EventArgs e)
        {
            EcranVeterinaires _ecranVeto = new EcranVeterinaires();
            EcranPrincipal _ecranParent = new EcranPrincipal();
            _ecranVeto.MdiParent = _ecranParent;
            _ecranVeto.Show();
            this.Close();
        }
    }
}