    using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Baremes
    {
        private string _codeGroupement;

        public string CodeGroupement
        {
            get { return _codeGroupement; }
            set { _codeGroupement = value; }
        }

        private string _dateVigueur;

        public string DateVigueur
        {
            get { return _dateVigueur; }
            set { _dateVigueur = value; }
        }

        private string _typeActe;

        public string TypeActe
        {
            get { return _typeActe; }
            set { _typeActe = value; }
        }

        private string _libelle;

        public string Libelle
        {
            get { return _libelle; }
            set { _libelle = value; }
        }


        private float? _tarifFixe;

        public float? TarifFixe
        {
            get { return _tarifFixe; }
            set { _tarifFixe = value; }
        }

        private float? _tarifMini;

        public float? TarifMini
        {
            get { return _tarifMini; }
            set { _tarifMini = value; }
        }

        private float? _tarifMaxi;

        public float? TarifMaxi
        {
            get { return _tarifMaxi; }
            set { _tarifMaxi = value; }
        }

        private Guid? _codeVaccin;

        public Guid? CodeVaccin
        {
            get { return _codeVaccin; }
            set { _codeVaccin = value; }
        }

        private bool? _archive;

        public bool? Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }

        public Baremes()
        {
            this.CodeGroupement = null;
            this.DateVigueur = null;
            this.TypeActe = null;
            this.Libelle = null;
            this.TarifFixe = null;
            this.TarifMini = null;
            this.TarifMaxi = null;
            this.CodeVaccin = null;
            this.Archive = null;
        }

        public Baremes(DataRow monBaremes)
        {
            
            this.DateVigueur = monBaremes["DateVigueur"].ToString();
            this.TypeActe = monBaremes["TypeActe"].ToString();
            this.Libelle = monBaremes["Libelle"].ToString();
            this.CodeGroupement = monBaremes["CodeGroupement"].ToString();
            if (!String.IsNullOrWhiteSpace(monBaremes["TarifFixe"].ToString()))
            {
                this.TarifFixe = float.Parse(monBaremes["TarifFixe"].ToString());
            }

            if (!String.IsNullOrWhiteSpace(monBaremes["TarifMini"].ToString()))
            {
                this.TarifMini = float.Parse(monBaremes["TarifMini"].ToString());
            }

            if (!String.IsNullOrWhiteSpace(monBaremes["TarifMaxi"].ToString()))
            {
                this.TarifMaxi = float.Parse(monBaremes["TarifMaxi"].ToString());
            }

            if (!String.IsNullOrWhiteSpace(monBaremes["CodeVaccin"].ToString()))
            {
                this.CodeVaccin = Guid.Parse(monBaremes["CodeVaccin"].ToString());
            }

            if (!String.IsNullOrWhiteSpace(monBaremes["Archive"].ToString()))
            {
                this.Archive = Boolean.Parse(monBaremes["Archive"].ToString());
            }            
        }

        public override string ToString()
        {
            return this.Libelle;
        }
    }
}
