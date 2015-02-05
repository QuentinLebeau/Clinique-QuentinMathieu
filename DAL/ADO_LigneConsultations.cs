using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    class ADO_LigneConsultations
    {
        public static List<LignesConsultations> getListeConsultation()
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                List<LignesConsultations> listeConsultation = new List<LignesConsultations>();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM LignesConsultations";
                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                foreach (DataRow uneConsultation in resultat.Rows)
                {
                    listeConsultation.Add(new LignesConsultations(uneConsultation));
                }

                return listeConsultation;
            }
        }

        public static Consultation getOneLignesConsultation(Guid pCodeLignesConsultations)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                Consultation uneConsultation = new Consultation();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();
                SqlParameter monParametre;
                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM LignesConsultations" +
                                  " WHERE CodeConsultation = @codeConsultation";
                monParametre = new SqlParameter("@codeConsultation", pCodeLignesConsultations);
                cmd.Parameters.Add(monParametre);
                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                uneConsultation = new Consultation(resultat.Rows[0]);

                return uneConsultation;
            }
        }

        public static void ajouterLignesConsultations(LignesConsultations lignesConsultation)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                Veterinaires _veto = new Veterinaires();
                Animaux _animaux = new Animaux();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();
                SqlParameter monParametre;
                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                // A MODIFIER POUR PRENDRE EN COMPTE LES PROCEDURES  1 2 ET 3
                cmd.CommandText = " Insert into LignesConsultations values (newID(), newId(), @codeGroupement" +
                                  ", @dateVigueur, @prix, @rappelEnvoye, 0)";
                monParametre = new SqlParameter("@codeGroupement", lignesConsultation.CodeGroupement);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@dateVigueur", lignesConsultation.DateVigueur);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@prix", lignesConsultation.Prix);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@rappelEnvoye", lignesConsultation.RappelEnvoye);
                cmd.Parameters.Add(monParametre);
                monAdapter.Fill(resultat);
            }
        }

        public static void supprimerLignesConsultations(LignesConsultations lignesConsultation)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                List<LignesConsultations> listeConsultation = new List<LignesConsultations>();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();
                SqlParameter monParametre;
                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = "delete from LignesConsultations where CodeConsultations = @codeConsultations";
                monParametre = new SqlParameter("@codeConsultations", lignesConsultation.CodeConsultation);
                cmd.Parameters.Add(monParametre);
                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                foreach (DataRow uneConsultation in resultat.Rows)
                {
                    listeConsultation.Add(new LignesConsultations(uneConsultation));
                }
            }
        }

        public static void modifierLignesConsultations(LignesConsultations lignesConsultation)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                List<LignesConsultations> listeConsultation = new List<LignesConsultations>();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();
                    SqlParameter monParametre;
                    SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                    cmd.CommandText = "update Veterinaires set @codeGroupement, @dateVigueur, @prix, " +
                                      "@rappelEnvoye where CodeConsultation = @codeConsultations";
                    monParametre = new SqlParameter("@codeGroupement", lignesConsultation.CodeGroupement);
                    cmd.Parameters.Add(monParametre);
                    monParametre = new SqlParameter("@dateVigueur", lignesConsultation.DateVigueur);
                    cmd.Parameters.Add(monParametre);
                    monParametre = new SqlParameter("@prix", lignesConsultation.Prix);
                    cmd.Parameters.Add(monParametre);
                    monParametre = new SqlParameter("@rappelEnvoye", lignesConsultation.RappelEnvoye);
                    cmd.Parameters.Add(monParametre);
                    monParametre = new SqlParameter("@codeConsultations", lignesConsultation.CodeConsultation);
                    cmd.Parameters.Add(monParametre);
                    monAdapter.Fill(resultat);

                    foreach (DataRow uneConsultation in resultat.Rows)
                    {
                        listeConsultation.Add(new LignesConsultations(uneConsultation));
                    }
            }
        }
    }
}
