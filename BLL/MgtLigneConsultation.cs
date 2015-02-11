using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MgtLigneConsultation
    {
        public static List<LignesConsultations> AfficherTout()
        {
            return ADO_LigneConsultations.getListeConsultation();
        }

        public static LignesConsultations AfficherUneSeul(LignesConsultations maLigneConsultation)
        {
            return ADO_LigneConsultations.getOneLignesConsultation(maLigneConsultation.CodeConsultation.Value, maLigneConsultation.NumLigne.Value);
        }

        public static void Ajouter(LignesConsultations maLigneConsultation)
        {
            ADO_LigneConsultations.Add(maLigneConsultation);
        }
        
        public static void Supprimer(LignesConsultations maLigneConsultation)
        {
            ADO_LigneConsultations.Delete(maLigneConsultation);
        }
    }
}
