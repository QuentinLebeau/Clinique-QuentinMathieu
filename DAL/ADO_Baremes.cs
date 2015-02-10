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
    }
}
