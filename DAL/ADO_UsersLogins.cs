using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ADO_UsersLogins
    {
        

        public static Boolean Authentification(string identifiant, string motDePasse)
        {
            SqlCommand cmd;
            SqlParameter paramIdentifiant;
            SqlParameter paramMDP;
            SqlDataAdapter da;
            ConnectionBDD.seConnecter2();
            cmd = new SqlCommand();
            cmd.CommandText =
                "select count(*) from UsersLogins where Identifiant = @identifiant and MotDePasse = @motDePasse";
            paramIdentifiant = new SqlParameter("@identifiant", identifiant);
            paramMDP = new SqlParameter("@MotDePasse", motDePasse);
            cmd.Parameters.Add(paramIdentifiant);
            cmd.Parameters.Add(paramMDP);
            DataTable maDatatable = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(maDatatable);

            if (maDatatable.Rows.Count > 0 && maDatatable.Rows.Count < 2)
            {
                return true;
            }
            else
	        {
                return false;
	        }
        }
    }
}
