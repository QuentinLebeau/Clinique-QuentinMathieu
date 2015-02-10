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
    public class ADO_Consultations
    {
        public static List<Consultation> getListeConsultation()
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                List<Consultation> listeConsultation = new List<Consultation>();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM Consultations";
                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                foreach (DataRow uneConsultation in resultat.Rows)
                {
                    listeConsultation.Add(new Consultation(uneConsultation));
                }

                return listeConsultation;
            }
        }

        public static Consultation getOneConsultation(Guid pCodeConsultation)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                Consultation uneConsultation = new Consultation();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();
                SqlParameter monParametre;
                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM Consultations" +
                                  " WHERE CodeConsultation = @codeConsultation";
                monParametre = new SqlParameter("@codeConsultation", pCodeConsultation);
                cmd.Parameters.Add(monParametre);
                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                uneConsultation = new Consultation(resultat.Rows[0]);

                return uneConsultation;
            }
        }

        public static void ajouterConsultations(Consultation consultation)
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
                cmd.CommandText = " exec ajout_Consultation1 @nomVeto, @nomAnimal";
                monParametre = new SqlParameter("@nomVeto", _veto.NomVeto);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@nomAnimal",_animaux.NomAnimal);
                cmd.Parameters.Add(monParametre);
                monAdapter.Fill(resultat);
           }
        }

        public static void supprimerConsultation(Consultation consultation)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                List<Consultation> listeConsultation = new List<Consultation>();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();
                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = "update Veterinaires set Archive = 1 where CodeVeto = '" + consultation.CodeConsultation + "'";
                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                foreach (DataRow uneConsultation in resultat.Rows)
                {
                    listeConsultation.Add(new Consultation(uneConsultation));
                }
            }
        }

        public static void modifierConsultation(Consultation consultation)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                List<Consultation> listeConsultation = new List<Consultation>();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();
                    SqlParameter monParametre;
                    SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                    cmd.CommandText = "update Veterinaires set @codeVeto, @dateConsultation, @codeAnimal, " +
                                      "@commentaire, @numFacture, @etat  where CodeVeto = @codeConsultation";
                    monParametre = new SqlParameter("@codeVeto", consultation.CodeVeto);
                    cmd.Parameters.Add(monParametre);
                    monParametre = new SqlParameter("@dateConsultation", consultation.DateConsultation);
                    cmd.Parameters.Add(monParametre);
                    monParametre = new SqlParameter("@codeAnimal", consultation.CodeAnimal);
                    cmd.Parameters.Add(monParametre);
                    monParametre = new SqlParameter("@commentaire", consultation.Commentaire);
                    cmd.Parameters.Add(monParametre);
                    monParametre = new SqlParameter("@numFacture", consultation.NumFacture);
                    cmd.Parameters.Add(monParametre);
                    monParametre = new SqlParameter("@etat", consultation.Etat);
                    cmd.Parameters.Add(monParametre);
                    monParametre = new SqlParameter("@codeConsultation", consultation.CodeConsultation);
                    cmd.Parameters.Add(monParametre);
                    monAdapter.SelectCommand = cmd;
                    monAdapter.Fill(resultat);

                    foreach (DataRow uneConsultation in resultat.Rows)
                    {
                        listeConsultation.Add(new Consultation(uneConsultation));
                    }
            }
        }
    }
}
