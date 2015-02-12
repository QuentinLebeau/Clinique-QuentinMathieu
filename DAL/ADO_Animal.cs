using BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ADO_Animal
    {
        DbConnection cnx;

        private DbConnection maConnexion()
        {
            return cnx = ConnectionBDD.SeConnecter();
        }
         

        public List<Animaux> GetAll()
        {
            try
            {
                DataTable maDataTable = new DataTable();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                List<Animaux> listeAnimaux = new List<Animaux>();

                SqlCommand cmd = (SqlCommand)maConnexion().CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM Animaux " +
                                  " WHERE Archive = 0 ; ";

                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(maDataTable);

                foreach (DataRow unAnimal in maDataTable.Rows)
                {
                    listeAnimaux.Add(new Animaux(unAnimal));
                }

                return listeAnimaux;
            }
            catch (Exception ex)
            {
                throw new Exception("Une erreur c'est produite lors de la séléction de tous les animaux :\n" + ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

        public Animaux GetOne(Guid pCodeAnimal)
        {
            try
            {
                DataTable maDataTable = new DataTable();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand)maConnexion().CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM Animaux " +
                                  " WHERE CodeAnimal = @codeAnimal ";

                monParametre = new SqlParameter("@codeAnimal", pCodeAnimal);
                cmd.Parameters.Add(monParametre);

                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(maDataTable);

                return new Animaux(maDataTable.Rows[0]);
            }
            catch (Exception ex)
            {
                throw new Exception("Une erreur c'est produite lors de la séléction d'un animal :\n" + ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

        public void Add(Animaux unAnimal)
        {
            try
            {
                SqlParameter monParametre;
                Clients proprietaire = new ADO_Clients().GetOne(unAnimal.CodeClient.Value);

                if (!unAnimal.Archive.HasValue)
                {
                    unAnimal.Archive = false;
                }

                SqlCommand cmd = (SqlCommand)maConnexion().CreateCommand();
                cmd.CommandText = " exec ajout_animal @Nomclient, @PrenomClient, @NomAnimal, @Sexe, @Couleur, @Espece, @Race, @Archive;";
                
                monParametre = new SqlParameter("@Nomclient", proprietaire.NomClient);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@PrenomClient", proprietaire.PrenomClient);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@NomAnimal", unAnimal.NomAnimal);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Sexe", unAnimal.Sexe);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Couleur", unAnimal.Couleur);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Race", unAnimal.Race.Race);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Espece", unAnimal.Race.Espece);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Archive", unAnimal.Archive.Value);
                cmd.Parameters.Add(monParametre);

                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Echec de l'insertion d'un animal :\n" + ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

        public void Update(Animaux monAnimal)
        {
            try
            {
                SqlParameter monParametre;

                if (!monAnimal.Archive.HasValue)
                {
                    monAnimal.Archive = false;
                }

                SqlCommand cmd = (SqlCommand)maConnexion().CreateCommand();
                cmd.CommandText = " UPDATE Animaux " +
                                  " SET NomAnimal = @NomAnimal, Sexe = @Sexe, Couleur = @Couleur, Race = @Race, Espece = @Espece, CodeClient = @CodeClient, Tatouage = @Tatouage, Antecedents = @Antecedents, Archive = @Archive " +
                                  " WHERE CodeAnimal = @CodeAnimal ; ";

                monParametre = new SqlParameter("@NomAnimal", monAnimal.NomAnimal);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Sexe", monAnimal.Sexe);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Couleur", monAnimal.Couleur ?? String.Empty);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Race", monAnimal.Race.Race);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Espece", monAnimal.Race.Espece);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@CodeClient", monAnimal.CodeClient);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Tatouage", monAnimal.Tatouage ?? String.Empty);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Antecedents", monAnimal.Antecedents ?? String.Empty);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Archive", monAnimal.Archive);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@CodeAnimal", monAnimal.CodeAnimal.Value);
                cmd.Parameters.Add(monParametre);

                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Echec de la modification de l'animal :\n" + ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

        public void Delete(Guid pCodeAnimal)
        {                
            try
            {
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand)maConnexion().CreateCommand();
                cmd.CommandText = " UPDATE Animaux SET Archive = 1" +
                                  " WHERE CodeAnimal = @codeAnimal ; ";

                monParametre = new SqlParameter("@codeAnimal", pCodeAnimal);
                cmd.Parameters.Add(monParametre);

                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Echec de la suppression de l'animal :\n" + ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }
    }
}
