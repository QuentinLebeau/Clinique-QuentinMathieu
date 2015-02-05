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
        private Guid? _codeVeto;
        public Guid? CodeVeto
        {
            get { return _codeVeto; }
            set { _codeVeto = value; }
        }

        private DateTime? _dateRDV;
        public DateTime? DateRDV
        {
            get { return _dateRDV; }
            set { _dateRDV = value; }
        }

        private Guid? _codeAnimal;
        public Guid? CodeAnimal
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
            this.CodeAnimal = Guid.Parse(monAgenda["CodeAnimal"].ToString());
            this.CodeVeto = Guid.Parse(monAgenda["CodeVeto"].ToString());
            this.DateRDV = DateTime.Parse(monAgenda["DateRdv"].ToString());
        }
    }
}
