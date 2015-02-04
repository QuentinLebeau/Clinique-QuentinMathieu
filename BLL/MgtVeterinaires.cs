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

        public static void ajouterVeto(string nomVeto, string prenomVeto, string motPasse)
        {
            ADO_Veterinaires.ajouterVeto(nomVeto, prenomVeto, motPasse);
        }

        public static void supprimerVeto(Veterinaires veto)
        {
            ADO_Veterinaires.supprimerVeto(veto);
        }

        public static void reinitialiserMotPasseVeto(Veterinaires veto, string newCode, 
                                                     string confirmMDP)
        {
            ADO_Veterinaires.reinitialiserMotPasseVeto(veto, newCode, confirmMDP);
        }
    }
}
