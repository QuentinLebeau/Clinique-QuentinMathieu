using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Agendas
    {
        // Attributs
        

        private Guid? _codeVeto;
        [Browsable(false)]
        public Guid? CodeVeto
        {
            get { return _codeVeto; }
            set { _codeVeto = value; }
        }

        private DateTime? _dateRDV;
        [DisplayName("Date Rendez-vous")]
        public DateTime? DateRDV
        {
            get { return _dateRDV; }
            set { _dateRDV = value; }
        }

        
        private Guid? _codeAnimal;
        [Browsable(false)]
        public Guid? CodeAnimal
        {
            get { return _codeAnimal; }
            set { _codeAnimal = value; }
        }

        // Attribut d'affichage        
        private string _nomClient;

        [DisplayName("Nom du client")]
        public string NomClient
        {
            get { return _nomClient; }
            set { _nomClient = value; }
        }

        
        private string _prenomClient;

        [DisplayName("Prenom du client")]
        public string PrenomClient
        {
            get { return _prenomClient; }
            set { _prenomClient = value; }
        }

       
        private string _nomAnimal;

         [DisplayName("Nom de l'animal")]
        public string NomAnimal
        {
            get { return _nomAnimal; }
            set { _nomAnimal = value; }
        }

        
        private string _race;

        [DisplayName("Race")]
        public string Race
        {
            get { return _race; }
            set { _race = value; }
        }

        // Constructeurs
        public Agendas()
        {
            this.CodeAnimal = null;
            this.CodeVeto = null;
            this.DateRDV = null;
            this.NomAnimal = null;
            this.NomClient = null;
            this.PrenomClient = null;
            this.Race = null;
        }

        public Agendas(DataRow monAgenda)
        {
            this.CodeAnimal = Guid.Parse(monAgenda["CodeAnimal"].ToString());
            this.CodeVeto = Guid.Parse(monAgenda["CodeVeto"].ToString());
            this.DateRDV = DateTime.Parse(monAgenda["DateRdv"].ToString());
            this.NomAnimal = null;
            this.NomClient = null;
            this.PrenomClient = null;
            this.Race = null;
        }
    }
}
