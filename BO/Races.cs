using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BO
{
    public class Races
    {
        // Attribut
        private string _race;
        public string Race
        {
            get { return _race; }
            set { _race = value; }
        }

        private string _espece;
        public string Espece
        {
            get { return _espece; }
            set { _espece = value; }
        }
        
        // Constructeur
        public Races() 
        {
            this.Race = null;
            this.Espece = null;
        }

        public Races(string pRace, string pEspece)
        {
            this.Race = pRace;
            this.Espece = pEspece;
        }

        public Races(DataRow maRace)
        {
            this.Race = maRace["Race"].ToString();
            this.Espece = maRace["Espece"].ToString();
        }

        // ToString 
        public override string ToString()
        {
            return this.Race + " - " + this.Espece;
        }
    }
}
