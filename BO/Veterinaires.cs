using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BO
{
    public class Veterinaires
    {
        // Attributs
        private int? _codeVeto;
        public int? CodeVeto
        {
            get { return _codeVeto; }
            set { _codeVeto = value; }
        }

        private string _nomVeto;
        public string NomVeto
        {
            get { return _nomVeto; }
            set { _nomVeto = value; }
        }

        private string _motPasse;
        public string MotPasse
        {
            get { return _motPasse; }
            set { _motPasse = value; }
        }

        private bool? _archive;
        public bool? Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }
        
        // Constructeurs
        public Veterinaires()
        {
            this.Archive = null;
            this.CodeVeto = null;
            this.MotPasse = null;
            this.NomVeto = null;
        }

        public Veterinaires(DataRow monVeto)
        {
            this.Archive = bool.Parse(monVeto["Archive"].ToString());
            this.CodeVeto = int.Parse(monVeto["CodeVeto"].ToString());
            this.MotPasse = monVeto["MotPasse"].ToString();
            this.NomVeto = monVeto["NomVeto"].ToString();
        }
    }
}
