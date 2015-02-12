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
        private Guid? _numFacture;
        public Guid? NumFacture
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

        private Guid? _codeClient;
        public Guid? CodeClients
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

        private DateTime? _rappelEnvoye;
        public DateTime? RappelEnvoye
        {
            get { return _rappelEnvoye; }
            set { _rappelEnvoye = value; }
        }
        
        // Constructeur
        public Facture()
        {
            this.Archive = null;
            this.CodeClients = null;
            this.DateFacture = null;
            this.Etat = null;
            this.NumFacture = null;
            this.RappelEnvoye = null;
            this.TotalFacture = null;
        }

        public Facture(DataRow maFacture)
        {
            this.Archive = bool.Parse(maFacture["Archive"].ToString());
            this.CodeClients = Guid.Parse(maFacture["CodeClient"].ToString());
            this.DateFacture = DateTime.Parse(maFacture["DateFacture"].ToString());
            this.Etat = int.Parse(maFacture["Etat"].ToString());
            this.NumFacture = Guid.Parse(maFacture["NumFacture"].ToString());

            if (!String.IsNullOrWhiteSpace(maFacture["RappelEnvoye"].ToString()))
            {
                this.RappelEnvoye = DateTime.Parse(maFacture["RappelEnvoye"].ToString());
            }
            
            this.TotalFacture = float.Parse(maFacture["TotalFacture"].ToString());
        }
    }
}
