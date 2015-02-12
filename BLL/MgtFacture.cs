using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MgtFacture
    {
        public static List<Facture> AfficherTout()
        {
            return ADO_Facture.GettAll();
        }
    }
}
