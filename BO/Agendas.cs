using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Agendas
    {
        // Attributs
        private int? _codeVeto;
        public int? CodeVeto
        {
            get { return _codeVeto; }
            set { _codeVeto = value; }
        }

        private DateTime? _dateRDV;
        public DateTime? DateRDV
        {
            get { return _dateRDV; }
            set 
            { 
                _dateRDV = value;
                if (value.Value.Minute < 8)
                {
                    _dateRDV = new DateTime(value.Value.Year, value.Value.Month, value.Value.Day, value.Value.Hour, 0, 0);
                }
                else if (value.Value.Minute < 23)
                {
                    _dateRDV = new DateTime(value.Value.Year, value.Value.Month, value.Value.Day, value.Value.Hour, 15, 0);
                }
                else if (value.Value.Minute < 37)
                {
                    _dateRDV = new DateTime(value.Value.Year, value.Value.Month, value.Value.Day, value.Value.Hour, 30, 0);
                }
                else if (value.Value.Minute < 53)
                {
                    _dateRDV = new DateTime(value.Value.Year, value.Value.Month, value.Value.Day, value.Value.Hour, 45, 0);
                }
                else
                {
                    _dateRDV = new DateTime(value.Value.Year, value.Value.Month, value.Value.Day, value.Value.Hour, 0, 0);
                }
            }
        }

        private int? _codeAnimal;
        public int? CodeAnimal
        {
            get { return _codeAnimal; }
            set { _codeAnimal = value; }
        }
        
        // Constructeurs
        public Agendas()
        {
            this.CodeAnimal = null;
            this.CodeVeto = null;
            this.DateRDV = null;
        }

        public Agendas(DataRow monAgenda)
        {
            this.CodeAnimal = int.Parse(monAgenda["CodeAnimal"].ToString());
            this.CodeVeto = int.Parse(monAgenda["CodeVeto"].ToString());
            this.DateRDV = DateTime.Parse(monAgenda["DateRdv"].ToString());
        }
    }
}
