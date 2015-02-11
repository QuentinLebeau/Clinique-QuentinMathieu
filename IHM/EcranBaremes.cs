﻿using System;
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
using Clinique;

namespace Clinique
{
    public partial class EcranBaremes : Form
    {
        public EcranBaremes()
        {
            InitializeComponent();
            dataGridView_baremes.DataSource = MgtBaremes.AffichierTout();
            TXT_baremes_codeGroupement.Enabled = false;
            TXT_baremes_dateVigueur.Enabled = false;
            TXT_baremes_codeVaccin.Enabled = false;
            GroupBoxAjoutBareme.Visible = false;
        }

        private void dataGridView_baremes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Baremes pBareme = (Baremes)dataGridView_baremes.CurrentRow.DataBoundItem;
            TXT_baremes_codeGroupement.Text = pBareme.CodeGroupement;
            TXT_baremes_dateVigueur.Text = pBareme.DateVigueur;
            TXT_baremes_typeActe.Text = pBareme.TypeActe;
            TXT_baremes_libelle.Text = pBareme.Libelle;

            if (pBareme.TarifFixe.HasValue)
            {
                TXT_baremes_tarifFixe.Text = pBareme.TarifFixe.Value.ToString();
            }
            else
            {
                TXT_baremes_tarifFixe.Text = null;
            }

            if (pBareme.TarifMini.HasValue)
            {
                TXT_baremes_tarifMini.Text = pBareme.TarifMini.Value.ToString();
            }
            else
            {
                TXT_baremes_tarifMini.Text = null;
            }

            if (pBareme.TarifMaxi.HasValue)
            {
                TXT_baremes_tarifMaxi.Text = pBareme.TarifMaxi.Value.ToString();
            }
            else
            {
                TXT_baremes_tarifMaxi.Text = null;
            }
            if (pBareme.CodeVaccin.HasValue)
            {
                TXT_baremes_codeVaccin.Text = pBareme.CodeVaccin.ToString();
            }
            else
            {
                TXT_baremes_codeVaccin.Text = null;
            }
        }



        private void BTN_baremeAjout_ajouterBareme_Click(object sender, EventArgs e)
        {
            GroupBoxAjoutBareme.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GroupBoxAjoutBareme.Visible = false;
        }

        private void BTN_baremes_Modifier_Click(object sender, EventArgs e)
        {
            Baremes monBareme = new Baremes();

            monBareme.CodeGroupement = TXT_baremes_codeGroupement.Text;
            monBareme.DateVigueur = TXT_baremes_dateVigueur.Text;
            monBareme.TypeActe = TXT_baremes_typeActe.Text;
            monBareme.Libelle = TXT_baremes_libelle.Text;
            monBareme.TarifFixe = float.Parse(TXT_baremes_tarifFixe.Text);
            monBareme.TarifMini = float.Parse(TXT_baremes_tarifMini.Text);
            monBareme.TarifMaxi = float.Parse(TXT_baremes_tarifMaxi.Text);
            monBareme.CodeVaccin = Guid.Parse(TXT_baremes_codeVaccin.Text);

            MgtBaremes.ModifierBareme(monBareme);
            dataGridView_baremes.DataSource = MgtBaremes.AffichierTout();
        }

        private void BTN_bareme_supprimer_Click(object sender, EventArgs e)
        {
            Baremes pBareme = (Baremes)dataGridView_baremes.CurrentRow.DataBoundItem;
            MgtBaremes.SupprimerBareme(pBareme);
            dataGridView_baremes.DataSource = MgtBaremes.AffichierTout();
        }
    }
}
