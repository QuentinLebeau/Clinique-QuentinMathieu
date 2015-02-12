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
                _instance.clientDAL = new ADO_Clients();
                _instance._listeClients = _instance.clientDAL.GetAll(); ;
            }
            else
            {
                _instance.clientDAL = new ADO_Clients();
                _instance._listeClients = _instance.clientDAL.GetAll(); ;
            }
            return _instance;
        }

        public List<Clients> ClientsListe
        {
            get { return AfficherTout(); }
        }

        public List<Clients> AfficherTout()
        {
            return clientDAL.GetAll();
        }

        public Clients AfficherUneSeul(Guid? pCodeClient)
        {
            return clientDAL.GetOne(pCodeClient);
        }

        public Clients AfficherUneSeulNonArchive(Guid? pCodeClient)
        {
            return clientDAL.GetOneWithoutArchive(pCodeClient);
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

        public Clients Rechercher(string nomClient)
        {
            return ADO_Clients.Rechercher(nomClient);
        }
    }
}
