using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MgtConsultation
    {
        public static List<Consultation> AfficherTout()
        {
            return ADO_Consultations.getListeConsultation();
        }

        public static Consultation AfficherUneSeul(Guid? pCodeConsultation)
        {
            return ADO_Consultations.getOneConsultation(pCodeConsultation.Value);
        }

        public static void AjouterNouvelleConsu(Consultation maConsultation)
        {
            ADO_Consultations.ajouterConsultationEnCours(maConsultation);
        }

        public static void AjouterLigne(Consultation maConsultation)
        {
            ADO_Consultations.ajouterConsultationLigne(maConsultation);
        }

        public static void AjouterNonFacture(Consultation maConsultation)
        {
            ADO_Consultations.ajouterDeuxLignesNonFacture(maConsultation);
        }

        public static void Modifier(Consultation maConsultation)
        {
            ADO_Consultations.modifierConsultation(maConsultation);
        }

        public static void Supprimer(Consultation maConsultation)
        {
            ADO_Consultations.supprimerConsultation(maConsultation);
        }
    }
}
