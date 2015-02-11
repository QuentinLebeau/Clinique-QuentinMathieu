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
using System.IO;

namespace Clinique
{
    public partial class EcranStockVaccin : Form
    {
        public EcranStockVaccin()
        {
            Vaccins _vaccins = new Vaccins();
            InitializeComponent();
            dataGridView_stockVaccins.DataSource = MgtVaccins.getAllVaccins();


            string[] lineOfContents = File.ReadAllLines("C:\\Users\\d1410alheincm\\Desktop\\Fournisseur.txt");
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split(',');
                Combo_stock_fournisseur.Items.Add(tokens[0]);
            }

            Combo_stock_fournisseur.SelectedIndex = 0;

            groupBox_stockAjout.Visible = false;
            TXT_stock_nomVaccin.Enabled = false;
            TXT_stock_codeVaccin.Visible = false;

        }

        private void dataGridView_stockVaccins_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Vaccins pCodeVaccin = (Vaccins)dataGridView_stockVaccins.CurrentRow.DataBoundItem;
            TXT_stock_codeVaccin.Text = pCodeVaccin.CodeVaccin.ToString();
            TXT_stock_nomVaccin.Text = pCodeVaccin.NomVaccin;
            TXT_stock_quantite.Text = pCodeVaccin.QuantiteStock.ToString();
            TXT_stockVaccin_dateValidite.Text = pCodeVaccin.PeriodeValidite.ToString();
        }

        private void BTN_sotck_modifier_Click(object sender, EventArgs e)
        {
            MgtVaccins.updateVaccins(Guid.Parse(TXT_stock_codeVaccin.Text), TXT_stock_nomVaccin.Text, int.Parse(TXT_stock_quantite.Text),
                                    int.Parse(TXT_stockVaccin_dateValidite.Text));
            dataGridView_stockVaccins.DataSource = MgtVaccins.getAllVaccins();
        }

        private void BTN_sotckAjout_AjouterVaccin_Click(object sender, EventArgs e)
        {
            groupBox_stockAjout.Visible = true;
        }

        private void BTN_sotckAjout_AnnulerAjout_Click(object sender, EventArgs e)
        {
            groupBox_stockAjout.Visible = false;
        }

        private void BTN_stock_annuler_Click(object sender, EventArgs e)
        {
            TXT_stock_nomVaccin.Text = null;
            TXT_stock_quantite.Text = null;
            TXT_stockVaccin_dateValidite.Text = null;
        }

        private void BTN_stockAjout_Ajouter_Click(object sender, EventArgs e)
        {
            MgtVaccins.addVaccins(textBox_NomVaccin.Text, int.Parse(textBox_PeriodeValiditeVaccin.Text.ToString()),
                            int.Parse(textBox_QuantiteVaccin.Text.ToString()));
            dataGridView_stockVaccins.DataSource = MgtVaccins.getAllVaccins();
        }

        private void BTN_Stock_Supprimer_Click(object sender, EventArgs e)
        {
            MgtVaccins.deleteVaccins(Guid.Parse(TXT_stock_codeVaccin.Text));
           dataGridView_stockVaccins.DataSource = MgtVaccins.getAllVaccins();
        }


    }
}
