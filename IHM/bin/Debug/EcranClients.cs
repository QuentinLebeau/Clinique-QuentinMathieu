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
    public partial class EcranClients : Form
    {
        //private Clients _employeCourant;

        //private int IndiceCourant
        //{
        //    get { return _courant; }
        //    set
        //    {
        //        _courant = value;
        //        _employeCourant = MgtEmploye.GetInstance().EmployesListe.ElementAt(_courant);
        //        NavBarre.apresEnable = (_courant != MgtEmploye.GetInstance().EmployesListe.Count - 1);
        //        NavBarre.avantEnable = (_courant != 0);
        //        AfficherEmployeCourant();
        //    }
        //}

        //private Employe EmployeCourant
        //{
        //    get { return _employeCourant; }
        //}

        public EcranClients()
        {
            InitializeComponent();
        }

        private void navBar1_Navigation(object sender, ControlsLibrary.NavBarEventArgs e)
        {
            //switch (e.navAction)
            //{
            //    case ControlsLibrary.NavBar.NavActionEnum.suivant:
            //        IndiceCourant += 1;
            //        break;
            //    case ControlsLibrary.NavBar.NavActionEnum.precedent:
            //        IndiceCourant -= 1;
            //        break;
            //    case ControlsLibrary.NavBar.NavActionEnum.premier:
            //        IndiceCourant = 0;
            //        break;
            //    case ControlsLibrary.NavBar.NavActionEnum.dernier:
            //        IndiceCourant = MgtEmploye.GetInstance().EmployesListe.Count() - 1;
            //        break;
            //}
        }
    }
}
