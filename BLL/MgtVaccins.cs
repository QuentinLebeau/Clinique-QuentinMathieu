using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using BLL;
using DAL;

namespace BLL
{
    public class MgtVaccins
    {
        public static List<Vaccins> getAllVaccins()
        {
            return ADO_Vaccins.getListeVaccins();
        }

        public static void addVaccins(string nomVaccin, int QuantiteVaccin, int Periode)
        {
            ADO_Vaccins.ajouterVaccins(nomVaccin, QuantiteVaccin, Periode);
        }

        public static void deleteVaccins(Guid Codevaccin)
        {
            ADO_Vaccins.supprimerVaccin(Codevaccin);
        }

        public static void updateVaccins(Guid codeVaccin, string nomVaccin, int QuantiteVaccin, int Periode)
        {
            ADO_Vaccins.updateVaccin(codeVaccin, nomVaccin, QuantiteVaccin, Periode);
        }
    }
}
