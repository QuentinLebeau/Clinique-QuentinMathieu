﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;

namespace BO
{
    public class Veterinaires
    {
        // Attributs
        private Guid? _codeVeto;

        [Browsable(false)]
        public Guid? CodeVeto
        {
            get { return _codeVeto; }
            set { _codeVeto = value; }
        }

        private string _nomVeto;

        [DisplayName("Code Nom")]
        public string NomVeto
        {
            get { return _nomVeto; }
            set { _nomVeto = value; }
        }

        private string _motPasse;
        
        [DisplayName("Mot de passe")]
        public string MotPasse
        {
            get { return _motPasse; }
            set { _motPasse = value; }
        }

        private bool? _archive;

        [Browsable(false)]
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

        /// <summary>
        /// construire une instance de veto initialisée
        /// </summary>
        public Veterinaires(Guid codeVeto, string nomVeto, string motPasse, bool archive)
        {
            this.CodeVeto = codeVeto;
            this.NomVeto = nomVeto;
            this.MotPasse = motPasse;
            this.Archive = archive;
        }
        
        public Veterinaires(DataRow monVeto)
        {
            this.Archive = bool.Parse(monVeto["Archive"].ToString());
            this.CodeVeto = Guid.Parse(monVeto["CodeVeto"].ToString());
            this.MotPasse = monVeto["MotPasse"].ToString();
            this.NomVeto = monVeto["NomVeto"].ToString();
        }

        public override string ToString()
        {
            return this.NomVeto;
        }
    }
}
