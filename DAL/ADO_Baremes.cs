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
    public class ADO_Baremes
    {
        public static List<Baremes> GetAll()
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable maDataTable = new DataTable();
                List<Baremes> listeBaremes = new List<Baremes>();

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM Baremes " + 
                                  " WHERE Archive = 0";

                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(maDataTable);

                foreach (DataRow unBaremes in maDataTable.Rows)
                {
                    listeBaremes.Add(new Baremes(unBaremes));
                }

                return listeBaremes;
            }
        }

        public static Baremes GetOne(Baremes pBareme)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM Baremes " +
                                  " WHERE CodeGroupement = @CodeGroupement " +
                                  " AND DateVigueur = @DateVigueur ";

                monParametre = new SqlParameter("@CodeGroupement", pBareme.CodeGroupement);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@DateVigueur", pBareme.DateVigueur);
                cmd.Parameters.Add(monParametre);

                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                return new Baremes(resultat.Rows[0]);
            }
        }

        public static void DeleteBareme(Baremes pBareme)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " Delete * " +
                                  " FROM Baremes " +
                                  " WHERE CodeGroupement = @CodeGroupement " +
                                  " AND DateVigueur = @DateVigueur ";

                monParametre = new SqlParameter("@CodeGroupement", pBareme.CodeGroupement);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@DateVigueur", pBareme.DateVigueur);
                cmd.Parameters.Add(monParametre);

                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateBareme(Baremes pBareme)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " Update Baremes" +
                                  " SET CodeGroupement = @codeGroupement, DateVigueur = @dateVigueur, " +
                                  " TypeActe = @typeActe, Libelle = @libelle, TarifFixe = @tarifFixe, " +
                                  " TarifMini = @tarifMini, TarifMaxi = @tarifMaxi, " +
                                  " CodeVaccin = @codeVaccin, 0";
                monParametre = new SqlParameter("@codeGroupement",pBareme.CodeGroupement);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@DateVigueur", pBareme.DateVigueur);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@typeActe", pBareme.TypeActe);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@libelle", pBareme.Libelle);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@tarifFixe",pBareme.TarifFixe);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@tarifMini",pBareme.TarifMini);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@tarifMaxi",pBareme.TarifMaxi);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@codeVaccin",pBareme.CodeVaccin);
                cmd.Parameters.Add(monParametre);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Baremes> ComboTypeActeBareme()
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable maDataTable = new DataTable();
                List<Baremes> listeBaremes = new List<Baremes>();

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT TypeActe " +
                                  " FROM Baremes ";

                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(maDataTable);

                foreach (DataRow unBaremes in maDataTable.Rows)
                {
                    listeBaremes.Add(new Baremes(unBaremes));
                }

                return listeBaremes;
            }
        }

        public static List<Baremes> ComboLibelle(string typeActe)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable maDataTable = new DataTable();
                List<Baremes> listeBaremes = new List<Baremes>();
                SqlParameter monParametre;
                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT Libelle " +
                                  " FROM Baremes " +
                                  " WHERE TypeActe = @typeActe";
                monParametre = new SqlParameter("@typeActe", typeActe);
                cmd.Parameters.Add(monParametre);
                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(maDataTable);

                foreach (DataRow unBaremes in maDataTable.Rows)
                {
                    listeBaremes.Add(new Baremes(unBaremes));
                }

                return listeBaremes;
            }
        }


        public static void AddBareme(Baremes pBareme)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlParameter monParametre;
                string dateVigueur = DateTime.Now.ToString("dd/MM/yy");
                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " exec ajout_bareme @codeGroupement, @dateVigueur, @typeActe, " +
                                  "@libelle, @tarifFixe, @tarifMini, @tarifMaxi, @codeVaccin";
                monParametre = new SqlParameter("@codeGroupement", pBareme.CodeGroupement);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@dateVigueur", dateVigueur);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@typeActe", pBareme.TypeActe);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@libelle", pBareme.Libelle);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@tarifFixe", pBareme.TarifFixe);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@tarifMini", pBareme.TarifMini);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@tarifMaxi", pBareme.TarifMaxi);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@codeVaccin", pBareme.CodeVaccin);
                cmd.Parameters.Add(monParametre);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
