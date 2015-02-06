using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class LignesConsultations
    {
        // Attributs
        private Guid? _codeConsultation;
        public Guid? CodeConsultation
        {
            get { return _codeConsultation; }
            set { _codeConsultation = value; }
        }

        private int? _numLigne;
        public int? NumLigne
        {
            get { return _numLigne; }
            set { _numLigne = value; }
        }

        private string _codeGroupement;
        public string CodeGroupement
        {
            get { return _codeGroupement; }
            set { _codeGroupement = value; }
        }

        private DateTime? _dateVigueur;

        public DateTime? DateVigueur
        {
            get { return _dateVigueur; }
            set { _dateVigueur = value; }
        }

        private float? _prix;

        public float? Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        private bool? _rappelEnvoye;

        public bool? RappelEnvoye
        {
            get { return _rappelEnvoye; }
            set { _rappelEnvoye = value; }
        }

        private bool? _archive;

        public bool? Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }

        public LignesConsultations()
        {
            this.CodeConsultation= null;
            this.NumLigne = null;
            this.CodeGroupement = null;
            this.DateVigueur = null;
            this.Prix = null;
            this.RappelEnvoye = null;
            this.Archive = null;
        }

         public LignesConsultations(DataRow maLigneConsultations)
        {
            this.CodeConsultation = Guid.Parse(maLigneConsultations["CodeConsultation"].ToString());
            this.NumLigne = int.Parse(maLigneConsultations["NumLigne"].ToString());
            this.CodeGroupement = maLigneConsultations["CodeGroupement"].ToString();
            this.DateVigueur = DateTime.Parse(maLigneConsultations["DateVigueur"].ToString());
            this.Prix = float.Parse(maLigneConsultations["Prix"].ToString());
            this.RappelEnvoye = bool.Parse(maLigneConsultations["RappelEnvoye"].ToString());
            this.Archive = bool.Parse(maLigneConsultations["Archive"].ToString());
        }
    }
}
