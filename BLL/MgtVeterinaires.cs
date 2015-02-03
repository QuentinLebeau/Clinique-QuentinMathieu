using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class MgtVeterinaires
    {
        public static List<Veterinaires> getVeto()
        {
            return ADO_Veterinaires.getListeVeto();
        }
    }
}
