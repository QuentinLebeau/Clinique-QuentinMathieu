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

        public static void ajouterConsultationEnCours(Consultation consultation)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                ADO_Animal monAnimalDAL = new ADO_Animal();
                Veterinaires _veto = ADO_Veterinaires.getOneVeto(consultation.CodeVeto.Value);
                Animaux _animaux = monAnimalDAL.GetOne(consultation.CodeAnimal.Value);

                SqlParameter monParametre;
                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();

                cmd.CommandText = " exec ajout_Consultation1 @DateConsultation, @nomVeto, @nomAnimal";

                monParametre = new SqlParameter("@nomVeto", _veto.NomVeto);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@nomAnimal",_animaux.NomAnimal);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@DateConsultation", consultation.DateConsultation.Value);
                cmd.Parameters.Add(monParametre);

                cmd.ExecuteNonQuery();
           }
        }

        public static void ajouterDeuxLignesNonFacture(Consultation consultation)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                ADO_Animal monAnimalDAL = new ADO_Animal();
                Veterinaires _veto = ADO_Veterinaires.getOneVeto(consultation.CodeVeto.Value);
                Animaux _animaux = monAnimalDAL.GetOne(consultation.CodeAnimal.Value);

                SqlParameter monParametre;
                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();

                cmd.CommandText = " exec ajout_Consultation2 @DateConsultation, @nomVeto, @nomAnimal";

                monParametre = new SqlParameter("@nomVeto", _veto.NomVeto);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@nomAnimal", _animaux.NomAnimal);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@DateConsultation", consultation.DateConsultation.Value);
                cmd.Parameters.Add(monParametre);

                cmd.ExecuteNonQuery();
            }
        }

        public static void ajouterConsultationLigne(Consultation consultation)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                ADO_Animal monAnimalDAL = new ADO_Animal();
                Veterinaires _veto = ADO_Veterinaires.getOneVeto(consultation.CodeVeto.Value);
                Animaux _animaux = monAnimalDAL.GetOne(consultation.CodeAnimal.Value);

                SqlParameter monParametre;
                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();

                cmd.CommandText = " exec ajout_Consultation3 @DateConsultation, @nomVeto, @nomAnimal";

                monParametre = new SqlParameter("@nomVeto", _veto.NomVeto);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@nomAnimal", _animaux.NomAnimal);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@DateConsultation", consultation.DateConsultation.Value);
                cmd.Parameters.Add(monParametre);

                cmd.ExecuteNonQuery();
            }
        }

        public static void Delete(Consultation consultation)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlParameter monParametre;
                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();

                cmd.CommandText = " DELETE FROM LignesConsultations WHERE CodeConsultation =  @CodeConsultation ;" +
                                  " DELETE FROM Consultations WHERE CodeConsultation =  @CodeConsultation; ";

                monParametre = new SqlParameter("@CodeConsultation", consultation.CodeConsultation);
                cmd.Parameters.Add(monParametre);

                cmd.ExecuteNonQuery();
            }
        }

        public static void Update(Consultation consultation)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlParameter monParametre;
                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " UPDATE Consultations " +
                                    " SET Commentaire = @commentaire " +
                                    " WHERE CodeConsultation = @codeConsultation";

                monParametre = new SqlParameter("@commentaire", consultation.Commentaire);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@codeConsultation", consultation.CodeConsultation);
                cmd.Parameters.Add(monParametre);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
