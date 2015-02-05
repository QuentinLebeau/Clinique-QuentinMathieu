using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Consultation
    {
        // Attributs
        private Guid? _codeConsultation;
        public Guid? CodeConsultation
        {
            get { return _codeConsultation; }
            set { _codeConsultation = value; }
        }
        
        private DateTime? _dateConsultation;
        public DateTime? DateConsultation
        {
            get { return _dateConsultation; }
            set { _dateConsultation = value; }
        }

        private int? _codeVeto;
        public int? CodeVeto
        {
            get { return _codeVeto; }
            set { _codeVeto = value; }
        }

        private int? _codeAnimal;
        public int? CodeAnimal
        {
            get { return _codeAnimal; }
            set { _codeAnimal = value; }
        }

        private string _commentaire;
        public string Commentaire
        {
            get { return _commentaire; }
            set { _commentaire = value; }
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
                    throw new Exception("La valeur doit être : 0, 1 ou 2");
                }
            }
        }

        private int? _numFacture;
        public int? NumFacture
        {
            get { return _numFacture; }
            set { _numFacture = value; }
        }

        private bool? _archive;
        public bool? Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }
        
        // Constructeurs
        public Consultation()
        {
            this.Archive = null;
            this.CodeAnimal = null;
            this.CodeConsultation = null;
            this.CodeVeto = null;
            this.Commentaire = null;
            this.DateConsultation = null;
            this.Etat = null;
            this.NumFacture = null;
        }

        public Consultation(DataRow maConsultation)
        {
            this.Archive = bool.Parse(maConsultation["Archive"].ToString());
            this.CodeAnimal = int.Parse(maConsultation["CodeAnimal"].ToString());
            this.CodeConsultation = Guid.Parse(maConsultation["CodeConsultation"].ToString());
            this.CodeVeto = int.Parse(maConsultation["CodeVeto"].ToString());
            this.Commentaire = maConsultation["Commentaire"].ToString();
            this.DateConsultation = DateTime.Parse(maConsultation["DateConsultation"].ToString());
            this.Etat = int.Parse(maConsultation["Etat"].ToString());
            this.NumFacture = int.Parse(maConsultation["NumFacture"].ToString());
        }
    }
}
