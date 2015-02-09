using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MgtAgenda
    {
        public static List<Agendas> AfficherTout()
        {
            return ADO_Agendas.GetAll();
        }

        public static List<Agendas> AfficherToutAvecDetail()
        {
            return ADO_Agendas.GetAllWithDetail();
        }

        public static Agendas AfficherUneSeul(Agendas monAgenda)
        {
            return ADO_Agendas.GetOne(monAgenda);
        }

        public static void Ajouter(Agendas monAgenda)
        {
            ADO_Agendas.Add(monAgenda);
        }

        public static void Modifier(Agendas monNouvelAgenda, Agendas monAncienAgenda)
        {
            ADO_Agendas.Update(monNouvelAgenda, monAncienAgenda);
        }

        public static void Supprimer(Agendas monAgenda)
        {
            ADO_Agendas.Delete(monAgenda);
        }

        public static List<Agendas> AfficherToutAvecParametres(Guid codeVeto, DateTime dateRDV)
        {
            return ADO_Agendas.GetAgendaWithParams(codeVeto, dateRDV);
        }
    }
}
