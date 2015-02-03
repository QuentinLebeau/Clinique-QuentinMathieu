using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BO
{
    public class Animaux
    {
        // Attributs
        private int? _codeAnimal;
        public int? CodeAnimal
        {
            get { return _codeAnimal; }
            set { _codeAnimal = value; }
        }

        private string _nomAnimal;
        public string NomAnimal
        {
            get { return _nomAnimal; }
            set { _nomAnimal = value; }
        }

        private char _sexe;
        public char Sexe
        {
            get { return _sexe; }
            set { _sexe = value; }
        }

        private string _couleur;
        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        private Races _race;
        public Races Race
        {
            get { return _race; }
            set { _race = value; }
        }

        private int? _codeClient;
        public int? CodeClient
        {
            get { return _codeClient; }
            set { _codeClient = value; }
        }

        private string _tatouage;
        public string Tatouage
        {
            get { return _tatouage; }
            set { _tatouage = value; }
        }

        private string _antecedents;
        public string Antecedents
        {
            get { return _antecedents; }
            set { _antecedents = value; }
        }

        private bool? _archive;
        public bool? Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }

        // Constructeur
        public Animaux()
        {
            this.Antecedents = null;
            this.Archive = null;
            this.CodeAnimal = null;
            this.CodeClient = null;
            this.Couleur = null;
            this.NomAnimal = null;
            this.Race = new Races();
            this.Sexe = ' ';
            this.Tatouage = null;
        }

        public Animaux(DataRow monAnimal)
        {
            this.Antecedents = monAnimal["Antecedents"].ToString();
            this.Archive = Boolean.Parse(monAnimal["Archive"].ToString());
            this.CodeAnimal = int.Parse(monAnimal["CodeAnimal"].ToString());
            this.CodeClient = int.Parse(monAnimal["CodeClient"].ToString());
            this.Couleur = monAnimal["Couleur"].ToString();
            this.NomAnimal = monAnimal["Couleur"].ToString();
            this.Race = new Races(monAnimal["Race"].ToString(), monAnimal["Espece"].ToString());
            this.Sexe = char.Parse(monAnimal["Sexe"].ToString());
            this.Tatouage = monAnimal["Tatouage"].ToString();
        }


    }
}
