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
using clinique;

namespace Clinique
{
    public partial class EcranAgenda : Form
    {
        public EcranAgenda()
        {
            InitializeComponent();
            combo_agenda_veto.DataSource = MgtVeterinaires.getAllVeto();
            dateTimePicker_agenda_date.Value = DateTime.Now;

            dataGridView_agenda.Columns["CodeVeto"].Visible = false;
            dataGridView_agenda.Columns["CodeAnimal"].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime dateAgenda = DateTime.Parse(dateTimePicker_agenda_date.Value.ToString());
            Guid codeVeto = ((Veterinaires)combo_agenda_veto.SelectedItem).CodeVeto.Value;
            dataGridView_agenda.DataSource = MgtAgenda.AfficherToutAvecParametres(codeVeto, dateAgenda);

        }

        private void dateTimePicker_agenda_date_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateAgenda = DateTime.Parse(dateTimePicker_agenda_date.Value.ToString());
            Guid codeVeto = ((Veterinaires)combo_agenda_veto.SelectedItem).CodeVeto.Value;
            dataGridView_agenda.DataSource = MgtAgenda.AfficherToutAvecParametres(codeVeto, dateAgenda);
        }

        private void BTN_agenda_Dossier_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_agenda_DoubleClick(object sender, EventArgs e)
        {
        }
    }
}
