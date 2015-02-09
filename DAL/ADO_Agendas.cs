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
    public class ADO_Agendas
    {
        public static List<Agendas> GetAll()
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable maDataTable = new DataTable();
                List<Agendas> listeAgendas = new List<Agendas>();

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM Agendas ";

                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(maDataTable);

                foreach (DataRow unAgendas in maDataTable.Rows)
                {
                    listeAgendas.Add(new Agendas(unAgendas));
                }

                return listeAgendas;
            }
        }

        public static List<Agendas> GetAllWithDetail()
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable maDataTable = new DataTable();
                List<Agendas> listeAgendas = new List<Agendas>();
                Agendas monAgenda;

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                 " FROM Agendas Ag " +
                                 " INNER JOIN Veterinaires V ON Ag.CodeVeto = V.CodeVeto " +
                                 " INNER JOIN Animaux An ON Ag.CodeAnimal = An.CodeAnimal " +
                                 " INNER JOIN Clients C ON An.CodeClient = C.CodeClient ";

                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(maDataTable);

                foreach (DataRow unAgendas in maDataTable.Rows)
                {
                    monAgenda = new Agendas(unAgendas);
                    monAgenda.NomAnimal = unAgendas["NomAnimal"].ToString();
                    monAgenda.NomClient = unAgendas["NomClient"].ToString();
                    monAgenda.PrenomClient = unAgendas["PrenomClient"].ToString();
                    monAgenda.Race = unAgendas["Race"].ToString();

                    listeAgendas.Add(monAgenda);
                }

                return listeAgendas;
            }
        }

        public static Agendas GetOne(Agendas monAgenda)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM Agendas " +
                                  " WHERE CodeVeto = @CodeVeto " +
                                  " AND DateRdv = @DateRdv " +
                                  " AND CodeAnimal = @CodeAnimal ;";

                monParametre = new SqlParameter("@Agendas", monAgenda.CodeVeto);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@DateRdv", monAgenda.DateRDV);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@CodeAnimal", monAgenda.CodeAnimal);
                cmd.Parameters.Add(monParametre);

                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                return new Agendas(resultat.Rows[0]);
            }
        }

        public static void Add(Agendas monAgenda)
        {
            ADO_Animal animalDAL = new ADO_Animal();
            ADO_Clients clientDAL = new ADO_Clients();

            Animaux monAnimal = animalDAL.GetOne(monAgenda.CodeAnimal.Value);
            Clients monClient = clientDAL.GetOne(monAnimal.CodeClient.Value);
            Veterinaires monVeto = ADO_Veterinaires.getOneVeto(monAgenda.CodeVeto.Value);

            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " exec ajout_agenda @nomClient, @prenomClient, @nomAnimal, @nomVeto, @dateRdv ;";

                monParametre = new SqlParameter("@nomClient", monClient.NomClient);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@prenomClient", monClient.PrenomClient);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@nomAnimal", monAnimal.NomAnimal);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@nomVeto", monVeto.NomVeto);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@dateRdv", monAgenda.DateRDV);
                cmd.Parameters.Add(monParametre);
                
                try
                {
                    cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw new Exception("Echec de l'insertion dans l'agnda :\n" + ex.Message);
                }
            }
        }

        // Attention, modification de la clé primaire, risque d'erreurs !
        public static void Update(Agendas monNouvelAgenda, Agendas monAncienAgenda)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " UPDATE Agendas " +
                                  " SET (CodeVeto = @nouveauCodeVeto, DateRdv = @nouvelleDateRdv, CodeAnimal = @nouveauCodeAnimal) " +
                                  " WHERE CodeVeto = @ancienCodeVeto " +
                                  " AND DateRdv = @ancienneDateRdv " +
                                  " AND CodeAnimal = @ancienCodeAnimal ";

                monParametre = new SqlParameter("@nouveauCodeVeto", monNouvelAgenda.CodeVeto);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@nouvelleDateRdv", monNouvelAgenda.DateRDV);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@nouveauCodeAnimal", monNouvelAgenda.CodeAnimal);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@ancienCodeVeto", monAncienAgenda.CodeVeto);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@ancienneDateRdv", monAncienAgenda.DateRDV);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@ancienCodeAnimal", monAncienAgenda.CodeAnimal);
                cmd.Parameters.Add(monParametre);

                try
                {
                    cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw new Exception("Echec de la modification de l'agenda :\n" + ex.Message);
                }
            }
        }

        public static void Delete(Agendas monAgenda)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " DELETE FROM Agendas " +
                                  " WHERE CodeVeto = @CodeVeto " +
                                  " AND DateRdv = @DateRdv " +
                                  " AND CodeAnimal = @CodeAnimal ";

                monParametre = new SqlParameter("@CodeVeto", monAgenda.CodeVeto);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@DateRdv", monAgenda.DateRDV);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@CodeAnimal", monAgenda.CodeAnimal);
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


        public static List<Agendas> GetAgendaWithParams(Guid pCodeVeto, DateTime pDateRDV)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable maDataTable = new DataTable();
                List<Agendas> listeAgendas = new List<Agendas>();
                Agendas monAgenda;
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                 " FROM Agendas Ag " +
                                 " INNER JOIN Veterinaires V ON Ag.CodeVeto = V.CodeVeto " +
                                 " INNER JOIN Animaux An ON Ag.CodeAnimal = An.CodeAnimal " +
                                 " INNER JOIN Clients C ON An.CodeClient = C.CodeClient " +
                                 " WHERE Ag.DateRdv = " + pDateRDV +
                                 " AND Ag.CodeVeto = @codeVeto";

                monParametre = new SqlParameter("@dateRDV", pDateRDV);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@codeVeto", pCodeVeto);
                cmd.Parameters.Add(monParametre);
                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(maDataTable);

                foreach (DataRow unAgendas in maDataTable.Rows)
                {
                    monAgenda = new Agendas(unAgendas);
                    monAgenda.NomAnimal = unAgendas["NomAnimal"].ToString();
                    monAgenda.NomClient = unAgendas["NomClient"].ToString();
                    monAgenda.PrenomClient = unAgendas["PrenomClient"].ToString();
                    monAgenda.Race = unAgendas["Race"].ToString();

                    listeAgendas.Add(monAgenda);
                }

                return listeAgendas;
            }
        }
    }
}
