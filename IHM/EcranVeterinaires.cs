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

namespace clinique
{
    public partial class EcranVeterinaires : Form
    {
        public EcranVeterinaires()
        {
            //tets
            InitializeComponent();
        }

        private void EcranVeterinaires_Load(object sender, EventArgs e)
        {

            DataGridVeto.DataSource = MgtVeterinaires.getVeto();
        }
    }
}
