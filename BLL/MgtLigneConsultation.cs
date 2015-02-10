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

        public static void Ajouter(Agendas monAgenda)
        {
            ADO_Agendas.Add(monAgenda);
        }

        public static void Modifier(LignesConsultations maLigneConsultation)
        {
            ADO_Agendas.Update(LignesConsultations maLigneConsultation);
        }

        public static void Supprimer(Agendas monAgenda)
        {
            ADO_Agendas.Delete(monAgenda);
        }
    }
}
