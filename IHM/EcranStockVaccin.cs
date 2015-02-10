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
            //int i = -1;
            InitializeComponent();
            dataGridView_stockVaccins.DataSource = MgtVaccins.getAllVaccins();
            Couleur();
          
            string[] lineOfContents = File.ReadAllLines("C:\\Users\\d1410alheincm\\Desktop\\Fournisseur.txt");
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split(',');
                Combo_stock_fournisseur.Items.Add(tokens[0]);
            }

            Combo_stock_fournisseur.SelectedIndex = 0;

            groupBox_stockAjout.Visible = false;

        }

        private void dataGridView_stockVaccins_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Vaccins pCodeVaccin = (Vaccins)dataGridView_stockVaccins.CurrentRow.DataBoundItem;
            TXT_stock_nomVaccin.Text = pCodeVaccin.NomVaccin;
            TXT_stock_quantite.Text = pCodeVaccin.QuantiteStock.ToString();
        }

        private void BTN_sotck_ajouter_Click(object sender, EventArgs e)
        {

        }

        private void Couleur()
        {
            foreach (DataGridViewRow vacc1 in dataGridView_stockVaccins.Rows)
            {
                for (int i = 0; i < dataGridView_stockVaccins.Rows.Count; i++)
                {
                    if (dataGridView_stockVaccins.Rows[i].Cells["QuantiteStock"].Value != null)
                    {
                        if ((int)dataGridView_stockVaccins.Rows[i].Cells["QuantiteStock"].Value <= 0)
                        {
                            dataGridView_stockVaccins.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void BTN_sotckAjout_AjouterVaccin_Click(object sender, EventArgs e)
        {
            groupBox_stockAjout.Visible = true;
        }

        private void BTN_sotckAjout_AnnulerAjout_Click(object sender, EventArgs e)
        {
            groupBox_stockAjout.Visible = false;
        }


    }
}
