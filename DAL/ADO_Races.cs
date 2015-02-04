using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using BO;

namespace DAL
{
    public class ADO_Races
    {
        public static List<Races> GetAll()
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable maDataTable = new DataTable();
                List<Races> listeRace = new List<Races>();

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM Races ";

                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(maDataTable);

                foreach (DataRow uneRace in maDataTable.Rows)
                {
                    listeRace.Add(new Races(uneRace));
                }

                return listeRace;
            }
        }

        public static Races GetOne(Races maRace)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM Races " + 
                                  " WHERE Race = @race " +
                                  " AND Espece = @espece ";

                monParametre = new SqlParameter("@race", maRace.Race);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@espece", maRace.Espece);
                cmd.Parameters.Add(monParametre);

                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                return new Races(resultat.Rows[0]);
            }
        }

        public static void Add(Races maRace)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand) cnx.CreateCommand();
                cmd.CommandText = " INSERT INTO Races(Race, Espece) " +
                                  " VALUES (@race, @espece);";

                monParametre = new SqlParameter("@race", maRace.Race);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@espece", maRace.Espece);
                cmd.Parameters.Add(monParametre);

                try
                {
                    cmd.ExecuteScalar();
                }
                catch (Exception)
                {
                    throw new Exception("Echec de l'insertion de la race");
                }                
            }
        }

        // Attention, modification de la clé primaire, risque d'erreurs !
        public static void Update(Races maNouvelleRace, Races monAncienneRace)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " UPDATE Races " +
                                  " SET (Race = @nouvelleRace, Espece = @nouvelleEspece) " +
                                  " WHERE Race = @ancienneRace " +
                                  " AND Espece = @ancienneEspece ;";

                monParametre = new SqlParameter("@nouvelleRace", maNouvelleRace.Race);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@nouvelleEspece", maNouvelleRace.Espece);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@ancienneRace", monAncienneRace.Race);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@ancienneEspece", monAncienneRace.Espece);
                cmd.Parameters.Add(monParametre);

                try
                {
                    cmd.ExecuteScalar();
                }
                catch (Exception)
                {
                    throw new Exception("Echec de la modification de la race");
                }
            }
        }

        public static void Delete(Races maRace)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " DELETE FROM Races " +
                                  " WHERE Race = @race " +
                                  " AND Espece = @espece ";

                monParametre = new SqlParameter("@race", maRace.Race);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@espece", maRace.Espece);
                cmd.Parameters.Add(monParametre);

                try
                {
                    cmd.ExecuteScalar();
                }
                catch (Exception)
                {
                    throw new Exception("Echec de la suppression de la race");
                }
            }
        }
    }
}
