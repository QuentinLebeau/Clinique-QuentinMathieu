using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BO
{
    public class Facture
    {
        // Attributs
        private int? _numFacture;
        public int? NumFacture
        {
            get { return _numFacture; }
            set { _numFacture = value; }
        }

        private DateTime? _dateFacture;
        public DateTime? DateFacture
        {
            get { return _dateFacture; }
            set { _dateFacture = value; }
        }

        private int? _codeClient;
        public int? CodeClients
        {
            get { return _codeClient; }
            set { _codeClient = value; }
        }

        private float? _totalFacture;
        public float? TotalFacture
        {
            get { return _totalFacture; }
            set { _totalFacture = value; }
        }

        private bool? _archive;
        public bool? Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }

        private int? _etat;
        public int? Etat
        {
            get { return _etat; }
            set 
            {
                _etat = value;
                if (value != 0 && value != 1 && value != 2)
                {
                    throw new Exception("La valeur doit être comprise entre 0 et 2");
                }
            }
        }
        
    }
}
