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
            return ADO_vaccins.getListeVaccins();
        }

        public static void addVaccins(string nomVeto, string prenomVeto, string motPasse)
        {
            //return ADO_vaccins.;
        }
    }
}
