using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace DAL
{
    public class ADO_Vaccins
    {
        public static List<Vaccins> getListeVaccins()
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                List<Vaccins> listeVaccin = new List<Vaccins>();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM Vaccins" + 
                                  " WHERE Archive = 0";
                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                foreach (DataRow unVaccin in resultat.Rows)
                {
                    listeVaccin.Add(new Vaccins(unVaccin));
                }

                return listeVaccin;
            }
        }

        public static void ajouterVaccins(string pNomVaccin, int pQuantiteVaccin, int pPeriode)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlParameter monParametre;
                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " exec ajout_vaccin @nomVaccin, @quantite, @periode";
                monParametre = new SqlParameter("@nomVaccin", pNomVaccin);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@quantite", pQuantiteVaccin);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@periode", pPeriode);
                cmd.Parameters.Add(monParametre);

                cmd.ExecuteNonQuery();
            }
        }

        public static void supprimerVaccin(Guid pCodeVaccin)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {

                    SqlParameter monParametre;
                    SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                    cmd.CommandText = "update Vaccins set Archive = 1 where CodeVaccin = @codeVaccin";
                    monParametre = new SqlParameter("@codeVaccin", pCodeVaccin);
                    cmd.Parameters.Add(monParametre);

                    cmd.ExecuteNonQuery();
                }
            }

        public static void updateVaccin(Guid pCodeVaccin, string pNomVaccin, int pQuantiteVaccin, int pPeriode)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlParameter monParametre;
                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = "update Vaccins set NomVaccin = @nomVaccin, QuantiteStock = @quantiteVaccin, " + 
                                  "PeriodeValidite = @periode where CodeVaccin = @codeVaccin";
                monParametre = new SqlParameter("@nomVaccin", pNomVaccin);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@quantiteVaccin", pQuantiteVaccin);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@periode", pPeriode);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@codeVaccin", pCodeVaccin);
                cmd.Parameters.Add(monParametre);

                cmd.ExecuteNonQuery();
            }
        }
        }
    }
