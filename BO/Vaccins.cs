using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Vaccins
    {
        private Guid? _codeVaccin;

        public Guid? CodeVaccin
        {
            get { return _codeVaccin; }
            set { _codeVaccin = value; }
        }


        private string _nomVaccin;

        public string NomVaccin
        {
            get { return _nomVaccin; }
            set { _nomVaccin = value; }
        }

        private int? _quantiteStock;

        public int? QuantiteStock
        {
            get { return _quantiteStock; }
            set { _quantiteStock = value; }
        }

        private int? _periodeValidite;

        public int? PeriodeValidite
        {
            get { return _periodeValidite; }
            set 
            { 
                TypeCode typeCode;
                _periodeValidite = value;
            }
        }

        private bool? _archive;

        public bool? Archive
        {
            get { return _archive; }
            set 
            { 
                _archive = value;
            }
        }

        public Vaccins()
        {
            this.CodeVaccin = null;
            this.NomVaccin = null;
            this.QuantiteStock = null;
            this.PeriodeValidite = null;
            this.Archive = null;
        }

        public Vaccins(DataRow monVaccins)
        {
            this.CodeVaccin = Guid.Parse(monVaccins["CodeVaccin"].ToString());
            this.NomVaccin = monVaccins["NomVaccin"].ToString();
            this.QuantiteStock = int.Parse(monVaccins["QuantiteStock"].ToString());
            this.PeriodeValidite = int.Parse(monVaccins["PeriodeValidite"].ToString());
            this.Archive = bool.Parse(monVaccins["Archive"].ToString());
        }

        public override string ToString()
        {
            return this.NomVaccin;
        }
    }
}
