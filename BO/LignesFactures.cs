using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BO
{
    public class LignesFactures
    {
        // Attributs
        private int? _numFacture;
        public int? NumFacture
        {
            get { return _numFacture; }
            set { _numFacture = value; }
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

        private float? _prix;
        public float? Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        private bool? _archive;
        public bool? Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }
        
        // Constructeurs
        public LignesFactures()
        {
            this.Archive = null;
            this.CodeGroupement = null;
            this.NumFacture = null;
            this.NumLigne = null;
            this.Prix = null;
        }

        public LignesFactures(DataRow maLigneFacture)
        {
            this.Archive = Boolean.Parse(maLigneFacture["Archive"].ToString());
            this.CodeGroupement = maLigneFacture["CodeGroupement"].ToString();
            this.NumFacture = int.Parse(maLigneFacture["NumFacture"].ToString());
            this.NumLigne = int.Parse(maLigneFacture["NumLigne"].ToString());
            this.Prix = float.Parse(maLigneFacture["Prix"].ToString());
        }
    }
}
