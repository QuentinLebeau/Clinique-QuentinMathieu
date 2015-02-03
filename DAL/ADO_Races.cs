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
        public static DataTable GetAll()
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM Races ";

                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                return resultat;
            }
        }

        public static DataTable GetOne(Races maRace)
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

                return resultat;
            }
        }

        public static void Ajouter(Races maRace)
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

        public static void Modifier(Races maRace)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " UPDATE Races " +
                                  " SET (Race = @race, Espece = @espece); ";

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
                    throw new Exception("Echec de la modification de la race");
                }
            }
        }

        public static void Supprimer(Races maRace)
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
