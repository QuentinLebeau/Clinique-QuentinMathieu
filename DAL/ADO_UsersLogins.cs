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
    public class ADO_UsersLogins
    {
        public static DataTable Authentification(string identifiant, string motDePasse)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlParameter monParametre;
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();

                SqlCommand cmd = (SqlCommand) cnx.CreateCommand();
                cmd.CommandText = " SELECT Id " +
                                  " FROM UsersLogins " +
                                  " WHERE Identifiant = @identifiant " +
                                  " AND MotDePasse = @motDePasse ";

                monParametre = new SqlParameter("@identifiant", identifiant);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@motDePasse", motDePasse);
                cmd.Parameters.Add(monParametre);

                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                return resultat;
            }
        }
    }
}
