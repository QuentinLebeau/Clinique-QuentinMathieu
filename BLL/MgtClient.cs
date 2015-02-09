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
        private List<Clients> _listeClients = new List<Clients>();
        //ADO_Clients monADO = new ADO_Clients();

        private static MgtClient _instance;
        private MgtClient()
        {
            _listeClients = clientDAL.GetAll();
        }

        public static MgtClient GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MgtClient();
            }
            else
            {
                _instance.clientDAL = new ADO_Clients();
            }
            return _instance;
        }

        public List<Clients> ClientsListe
        {
            get { return _listeClients; }
        }

        public List<Clients> AfficherTout()
        {
            return clientDAL.GetAll();
        }

        public Clients AfficherUneSeul(Guid? pCodeClient)
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

        public List<Clients> Rechercher(string nomClient)
        {
            return ADO_Clients.Rechercher(nomClient);
        }
    }
}
