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
                                  " FROM Vaccins";
                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                foreach (DataRow unVaccin in resultat.Rows)
                {
                    listeVaccin.Add(new Vaccins(unVaccin));
                }

                return listeVaccin;
            }
        }

        public static void ajouterVaccins(string pNomVeto, string pPrenomVeto, string pMotPasse)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                string login;
                List<Vaccins> listeVeto = new List<Vaccins>();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();
                SqlParameter monParametre;
                pNomVeto = pNomVeto.ToUpper();
                pPrenomVeto = pPrenomVeto[0].ToString().ToUpper()
                    + pPrenomVeto.Substring(1).ToLower();
                pMotPasse = pMotPasse.ToUpper();
                login = pNomVeto[0].ToString().ToUpper() + pPrenomVeto.ToLower();
                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " exec ajout_Veterinaire @nomVeto, @motPasse, 0 ; exec ajout_UsersLogins @login, @motPasse";
                monParametre = new SqlParameter("@nomVeto", pNomVeto + ' ' + pPrenomVeto);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@motPasse", pMotPasse);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@login", login);
                cmd.Parameters.Add(monParametre);
                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                foreach (DataRow unVaccins in resultat.Rows)
                {
                    listeVeto.Add(new Vaccins(unVaccins));
                }
            }
        }
    }
}
