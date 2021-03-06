﻿using System;
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
        public static List<Veterinaires> getAllVeto()
        {
            return ADO_Veterinaires.getListeVeto();
        }

        public static Veterinaires getOneVeto(Guid pCodeVeto)
        {
            return ADO_Veterinaires.getOneVeto(pCodeVeto);
        }

        public static void addVeto(string nomVeto, string prenomVeto, string motPasse)
        {
            ADO_Veterinaires.ajouterVeto(nomVeto, prenomVeto, motPasse);
        }

        public static void deleteVeto(Veterinaires veto)
        {
            ADO_Veterinaires.supprimerVeto(veto);
        }

        public static void resetPasswordVeto(Veterinaires veto, string newCode, 
                                                     string confirmMDP)
        {
            ADO_Veterinaires.reinitialiserMotPasseVeto(veto, newCode, confirmMDP);
        }
    }
}
