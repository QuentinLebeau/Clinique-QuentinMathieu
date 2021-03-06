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
            TXT_baremesAjout_dateVigueur.Enabled = false;
            TXT_baremesAjout_codeVaccin.Enabled = false;
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
            LBL_baremeAjout_erreur.Visible = false;
            comboBox_baremeAjout_TypeAct.DataSource = MgtBaremes.ComboTypeActe().Select(x => x.TypeActe).Distinct().ToList<string>();
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
            monBareme.TypeActe = comboBox_baremeAjout_TypeAct.Text;
            monBareme.Libelle = comboBox_ajoutBareme_Libelle.Text;
            if (!String.IsNullOrWhiteSpace(TXT_baremes_tarifFixe.Text))
            {
                monBareme.TarifFixe = float.Parse(TXT_baremes_tarifFixe.Text);
            }


            if (!String.IsNullOrWhiteSpace(TXT_baremes_tarifMini.Text))
            {
                monBareme.TarifMini = float.Parse(TXT_baremes_tarifMini.Text);
            }


            if (!String.IsNullOrWhiteSpace(TXT_baremes_tarifMaxi.Text))
            {
                monBareme.TarifMaxi = float.Parse(TXT_baremes_tarifMaxi.Text);
            }


            if (!String.IsNullOrWhiteSpace(TXT_baremes_codeVaccin.Text))
            {
                monBareme.CodeVaccin = Guid.Parse(TXT_baremes_codeVaccin.Text);    
            }

            

            MgtBaremes.ModifierBareme(monBareme);
            dataGridView_baremes.DataSource = MgtBaremes.AffichierTout();
        }

        private void BTN_bareme_supprimer_Click(object sender, EventArgs e)
        {
            Baremes pBareme = (Baremes)dataGridView_baremes.CurrentRow.DataBoundItem;
            MgtBaremes.SupprimerBareme(pBareme);
            dataGridView_baremes.DataSource = MgtBaremes.AffichierTout();
        }

        private void BTN_baremesAjout_ajout_Click(object sender, EventArgs e)
        {
            try
            {
                Baremes monBareme = new Baremes();

                monBareme.CodeGroupement = TXT_baremesAjout_codeGroupement.Text;
                monBareme.DateVigueur = TXT_baremesAjout_dateVigueur.Text;
                monBareme.TypeActe = comboBox_baremeAjout_TypeAct.Text;
                monBareme.Libelle = comboBox_ajoutBareme_Libelle.Text;
                if (!String.IsNullOrWhiteSpace(TXT_baremesAjout_tarifFixe.Text))
                {
                    monBareme.TarifFixe = float.Parse(TXT_baremesAjout_tarifFixe.Text);
                }


                if (!String.IsNullOrWhiteSpace(TXT_baremesAjout_tarifMini.Text))
                {
                    monBareme.TarifMini = float.Parse(TXT_baremesAjout_tarifMini.Text);
                }


                if (!String.IsNullOrWhiteSpace(TXT_baremesAjout_tarifMaxi.Text))
                {
                    monBareme.TarifMaxi = float.Parse(TXT_baremesAjout_tarifMaxi.Text);
                }


                if (!String.IsNullOrWhiteSpace(TXT_baremesAjout_codeVaccin.Text))
                {
                    monBareme.CodeVaccin = Guid.Parse(TXT_baremesAjout_codeVaccin.Text);
                }

                MgtBaremes.AjoutBareme(monBareme);
                dataGridView_baremes.DataSource = MgtBaremes.AffichierTout();
            }
            catch (Exception ex)
            {
                LBL_baremeAjout_erreur.Text = ("Problème lors de la saisie des informations : " + ex.Message);
                LBL_baremeAjout_erreur.ForeColor = System.Drawing.Color.Red;
                LBL_baremeAjout_erreur.Visible = true;
            }
        }

        private void comboBox_baremeAjout_TypeAct_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox_ajoutBareme_Libelle.DataSource = MgtBaremes.ComboLibelle(comboBox_baremeAjout_TypeAct.Text);
        }

        private void comboBox_ajoutBareme_Libelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(((Baremes)comboBox_ajoutBareme_Libelle.SelectedItem).CodeVaccin.Value.ToString()))
            {
                TXT_baremesAjout_codeVaccin.Text = ((Baremes)comboBox_ajoutBareme_Libelle.SelectedItem).CodeVaccin.Value.ToString();
            }
            else
            {
                TXT_baremesAjout_codeVaccin.Text = null;
            }
        }

        private void comboBox_ajoutBareme_Libelle_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }


    }
}
