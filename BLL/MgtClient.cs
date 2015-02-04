using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MgtClient
    {
        ADO_Clients clientDAL = new ADO_Clients();

        public List<Clients> AfficherTout()
        {
            return clientDAL.GetAll();
        }

        public Clients AfficherUneSeul(Guid pCodeClient)
        {
            return clientDAL.GetOne(pCodeClient);
        }

        public void Ajouter(Clients unClient)
        {
            clientDAL.Add(unClient);
        }

        public void Modifier(Clients unClient)
        {
            clientDAL.Update(unClient);
        }

        public void Supprimer(Guid pCodeClient)
        {
            clientDAL.Delete(pCodeClient);
        }
    }
}
