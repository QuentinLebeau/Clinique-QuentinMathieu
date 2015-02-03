using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class LignesConsultations
    {
        // Attributs
        private int? _codeConsultation;
        public int? CodeConsultation
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
        
        // PAS FINIS !
    }
}
