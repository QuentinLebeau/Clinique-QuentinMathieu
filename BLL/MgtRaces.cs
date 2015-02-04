using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class MgtRaces
    {
        public static List<Races> AfficherTout()
        {
            return ADO_Races.GetAll();
        }

        public static Races AfficherUneSeul(Races uneRace)
        {
            return ADO_Races.GetOne(uneRace);
        }

        public static void Ajouter(Races uneRace)
        {
            ADO_Races.Add(uneRace);
        }

        public static void Modifier(Races uneNouvlleRace, Races uneAncienneRace)
        {
            ADO_Races.Update(uneNouvlleRace, uneAncienneRace);
        }

        public static void Supprimer(Races uneRace)
        {
            ADO_Races.Delete(uneRace);
        }
    }
}
