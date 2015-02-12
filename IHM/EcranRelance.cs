using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinique
{
    public partial class EcranRelance : Form
    {
        public EcranRelance()
        {
            InitializeComponent();

            GRID_Relance.DataSource = MgtRelance.AfficheTout();
            
        }
    }
}
