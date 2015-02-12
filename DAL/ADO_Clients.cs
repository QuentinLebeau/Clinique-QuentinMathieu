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
    public class ADO_Clients
    {
        DbConnection cnx = ConnectionBDD.SeConnecter();

        public List<Clients> GetAll()
        {
            cnx = ConnectionBDD.SeConnecter();
            try
            {
                DataTable maDataTable = new DataTable();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                List<Clients> listeClient = new List<Clients>();

                SqlCommand cmd = (SqlCommand) cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM Clients " +
                                  " WHERE Archive = 0 ; ";

                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(maDataTable);

                foreach (DataRow unClient in maDataTable.Rows)
                {
                    listeClient.Add(new Clients(unClient));
                }

                return listeClient;
            }
            catch (Exception ex)
            {
                throw new Exception("Une erreur c'est produite lors de la séléction de tous les clients :\n" + ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

        public Clients GetOne(Guid? pCodeClient)
        {
            cnx = ConnectionBDD.SeConnecter();
            try
            {
                DataTable maDataTable = new DataTable();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand) cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM Clients " +
                                  " WHERE CodeClient = @codeClient ";

                monParametre = new SqlParameter("@codeClient", pCodeClient);
                cmd.Parameters.Add(monParametre);

                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(maDataTable);
                
                return new Clients(maDataTable.Rows[0]);
            }
            catch (Exception ex)
            {
                throw new Exception("Une erreur c'est produite lors de la séléction d'un client :\n" + ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

        public Clients GetOneWithoutArchive(Guid? pCodeClient)
        {
            cnx = ConnectionBDD.SeConnecter();
            try
            {
                DataTable maDataTable = new DataTable();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM Clients " +
                                  " WHERE CodeClient = @codeClient " +
                                  " AND Archive = 0 ;";

                monParametre = new SqlParameter("@codeClient", pCodeClient);
                cmd.Parameters.Add(monParametre);

                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(maDataTable);

                return new Clients(maDataTable.Rows[0]);
            }
            catch (Exception ex)
            {
                throw new Exception("Une erreur c'est produite lors de la séléction d'un client non archivé :\n" + ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

        public void Add(Clients unClient)
        {
            cnx = ConnectionBDD.SeConnecter();
            try
            {
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand) cnx.CreateCommand();
                cmd.CommandText = " exec ajout_client @NomClient, @PrenomClient, @Adresse1, @Adresse2, @CodePostal, @Ville, @NumTel, @Assurance, @Email, @Archive;";

                monParametre = new SqlParameter("@NomClient", unClient.NomClient);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@PrenomClient", unClient.PrenomClient);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Adresse1", unClient.Adresse1);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Adresse2", unClient.Adresse2);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@CodePostal", unClient.CodePostal);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Ville", unClient.Ville);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@NumTel", unClient.NumTel ?? String.Empty);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Assurance", unClient.Assurance ?? String.Empty);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Email", unClient.Email ?? String.Empty);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Archive", unClient.Archive ?? false);
                cmd.Parameters.Add(monParametre);

                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Echec de l'insertion d'un client :\n" + ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

        public void Update(Clients unClient)
        {
            cnx = ConnectionBDD.SeConnecter();
            try
            {
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " UPDATE Clients " +
                                  " SET NomClient = @NomClient, PrenomClient = @PrenomClient, Adresse1 = @Adresse1, Adresse2 = @Adresse2, CodePostal = @CodePostal, Ville = @Ville, NumTel = @NumTel, Assurance = @Assurance, Email = @Email, Remarque = @Remarque, Archive =  @Archive ; ";

                monParametre = new SqlParameter("@NomClient", unClient.NomClient);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@PrenomClient", unClient.PrenomClient);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Adresse1", unClient.Adresse1);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Adresse2", unClient.Adresse2);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@CodePostal", unClient.CodePostal);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Ville", unClient.Ville);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@NumTel", unClient.NumTel);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Assurance", unClient.Assurance);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Email", unClient.Email);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Remarque", unClient.Remarque);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Archive", unClient.Archive);
                cmd.Parameters.Add(monParametre);

                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Echec de la modification du client :\n" + ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

        public void Delete(Guid pCodeClient)
        {
            cnx = ConnectionBDD.SeConnecter();
            try
            {
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " UPDATE Animaux SET Archive = 1 WHERE CodeClient = @codeClient ; " +
                                  " UPDATE Clients SET Archive = 1 WHERE CodeClient = @codeClient ; ";

                monParametre = new SqlParameter("@codeClient", pCodeClient);
                cmd.Parameters.Add(monParametre);

                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Echec de la suppression du client :\n" + ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

        public static Clients Rechercher(string nomClient)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                Clients unClient = new Clients();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable maDataTable = new DataTable();
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT TOP(1) * " +
                                  " FROM Clients" +
                                  " WHERE NomClient LIKE '%' + @nomClient + '%'" +
                                  " AND Archive = 0 ;";

                monParametre = new SqlParameter("@nomClient", nomClient);
                cmd.Parameters.Add(monParametre);

                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(maDataTable);

                foreach (DataRow clientEnCours in maDataTable.Rows)
                {
                    unClient = new Clients(clientEnCours);
                    break;
                }

                return unClient;
            }
        }
    }
}
