using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class UsersLogins
    {
        private int? _id;

        public int? Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _identifiant;

        public string Identifiant
        {
            get { return _identifiant; }
            set { _identifiant = value; }
        }

        private string _motDePasse;

        public string MotDePasse
        {
            get { return _motDePasse; }
            set { _motDePasse = value; }
        }
        
        public UsersLogins() 
        {
            this.Id = null;
            this.Identifiant = null;
            this.MotDePasse = null;
        }

        public UsersLogins(DataRow monCompte)
        {
            this.Id = int.Parse(monCompte["Id"].ToString());
            this.Identifiant = monCompte["Identifiant"].ToString();
            this.MotDePasse = monCompte["MotDePasse"].ToString();
        }
        
    }
}
