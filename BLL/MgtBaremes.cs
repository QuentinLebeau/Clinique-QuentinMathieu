using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MgtBaremes
    {
        public static List<Baremes> AffichierTout()
        {
            return ADO_Baremes.GetAll();
        }

        public static Baremes AfficherUnSeul(Baremes pBareme)
        {
            return ADO_Baremes.GetOne(pBareme);
        }

        public static void SupprimerBareme(Baremes pBareme)
        {
            ADO_Baremes.DeleteBareme(pBareme);
        }

        public static void ModifierBareme(Baremes pBareme)
        {
            ADO_Baremes.UpdateBareme(pBareme);
        }

    }
}
