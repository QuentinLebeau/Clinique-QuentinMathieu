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

        public static void AjoutBareme(Baremes pBareme)
        {
            ADO_Baremes.AddBareme(pBareme);
        }

        public static List<Baremes> ComboTypeActe()
        {
            return ADO_Baremes.ComboTypeActeBareme();
        }

        public static List<Baremes> ComboLibelle(string typeActe)
        {
            return ADO_Baremes.ComboLibelle(typeActe);
        }
    }
}
