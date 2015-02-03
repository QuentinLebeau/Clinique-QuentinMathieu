using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BO
{
    public class Clients
    {
        // Attributs
        private int? _codeClient;
        public int? CodeClient
        {
            get { return _codeClient; }
            set { _codeClient = value; }
        }

        private string _nomClient;
        public string NomClient
        {
            get { return _nomClient; }
            set { _nomClient = value; }
        }

        private string _adresse1;
        public string Adresse1
        {
            get { return _adresse1; }
            set { _adresse1 = value; }
        }

        private string _adresse2;
        public string Adresse2
        {
            get { return _adresse2; }
            set { _adresse2 = value; }
        }

        private string _codePostal;
        public string CodePostal
        {
            get { return _codePostal; }
            set { _codePostal = value; }
        }

        private string _ville;
        public string Ville
        {
            get { return _ville; }
            set { _ville = value; }
        }

        private string _numTel;
        public string NumTel
        {
            get { return _numTel; }
            set { _numTel = value; }
        }

        private string _assurance;
        public string Assurance
        {
            get { return _assurance; }
            set { _assurance = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _remarque;
        public string Remarque
        {
            get { return _remarque; }
            set { _remarque = value; }
        }

        private bool? _archive;
        public bool? Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }
        
        // Constructeurs
        public Clients()
        {
            this.Adresse1 = null;
            this.Adresse2 = null;
            this.Archive = null;
            this.Assurance = null;
            this.CodeClient = null;
            this.CodePostal = null;
            this.Email = null;
            this.NomClient = null;
            this.NumTel = null;
            this.Remarque = null;
            this.Ville = null;
        }

        // Constructeurs
        public Clients(DataRow monClient)
        {
            this.Adresse1 = monClient["Adresse1"].ToString();
            this.Adresse2 = monClient["Adresse2"].ToString();
            this.Archive = Boolean.Parse(monClient["Archive"].ToString());
            this.Assurance = monClient["Assurance"].ToString();
            this.CodeClient = int.Parse(monClient["CodeClient"].ToString());
            this.CodePostal = monClient["CodePostal"].ToString();
            this.Email = monClient["Email"].ToString();
            this.NomClient = monClient["NomClient"].ToString();
            this.NumTel = monClient["NumTel"].ToString();
            this.Remarque = monClient["Remarque"].ToString();
            this.Ville = monClient["Ville"].ToString();
        }   
    }
}
