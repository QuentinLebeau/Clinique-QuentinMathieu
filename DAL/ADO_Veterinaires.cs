using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace DAL
{
    public class ADO_Veterinaires
    {
        public static List<Veterinaires> getListeVeto()
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                List<Veterinaires> listeVeto = new List<Veterinaires>();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM Veterinaires" +
                                  " WHERE Archive = 0";
                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                foreach (DataRow unVeto in resultat.Rows)
                {
                    listeVeto.Add(new Veterinaires(unVeto));
                }

                return listeVeto;
            }
        }

        public static Veterinaires getOneVeto(Guid pCodeVeto)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                Veterinaires unVeto = new Veterinaires();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable maDataTable = new DataTable();
                SqlParameter monParametre;

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM Veterinaires" +
                                  " WHERE CodeVeto = @codeVeto";

                monParametre = new SqlParameter("@codeVeto", pCodeVeto);
                cmd.Parameters.Add(monParametre);

                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(maDataTable);

                foreach (DataRow uneOccurence in maDataTable.Rows)
                {
                    unVeto = new Veterinaires(uneOccurence);
                }

                return unVeto;
            }
        }

        public static void ajouterVeto(string pNomVeto, string pPrenomVeto, string pMotPasse)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                List<Veterinaires> listeVeto = new List<Veterinaires>();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();
                SqlParameter monParametre;
                pNomVeto = pNomVeto.ToUpper();
                pPrenomVeto = pPrenomVeto[0].ToString().ToUpper()
                    + pPrenomVeto.Substring(1).ToLower();
                pMotPasse = pMotPasse.ToUpper();
                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " exec ajout_Veterinaire @nomVeto, @motPasse, 0";
                monParametre = new SqlParameter("@nomVeto", pNomVeto + ' ' + pPrenomVeto);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@motPasse", pMotPasse);
                cmd.Parameters.Add(monParametre);
                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                foreach (DataRow unVeto in resultat.Rows)
                {
                    listeVeto.Add(new Veterinaires(unVeto));
                }
           }
        }

        public static void supprimerVeto(Veterinaires veto)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                List<Veterinaires> listeVeto = new List<Veterinaires>();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();
                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = "update Veterinaires set Archive = 1 where CodeVeto = '" + veto.CodeVeto + "'";
                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                foreach (DataRow unVeto in resultat.Rows)
                {
                    listeVeto.Add(new Veterinaires(unVeto));
                }
            }
        }

        public static void reinitialiserMotPasseVeto(Veterinaires veto, 
                                                     string pNouveauCode, string pVerifCode)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                List<Veterinaires> listeVeto = new List<Veterinaires>();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();
                if (pNouveauCode.Equals(pVerifCode))
	            {
                    SqlParameter monParametre;
                    SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                    cmd.CommandText = "update Veterinaires set MotPasse = @MotPasse where CodeVeto = @coceVeto";
                    monParametre = new SqlParameter("@MotPasse", pNouveauCode);
                    cmd.Parameters.Add(monParametre);
                    monParametre = new SqlParameter("@codeVeto", veto.CodeVeto);
                    cmd.Parameters.Add(monParametre);
                    monAdapter.SelectCommand = cmd;
                    monAdapter.Fill(resultat);

                    foreach (DataRow unVeto in resultat.Rows)
                    {
                        listeVeto.Add(new Veterinaires(unVeto));
                    }
	            }
                
            }
        }
    }
}