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
    public class ADO_Facture
    {
        public static List<Facture> GettAll()
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                List<Facture> listeFacture = new List<Facture>();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM Factures ;";

                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                foreach (DataRow uneConsultation in resultat.Rows)
                {
                    listeFacture.Add(new Facture(uneConsultation));
                }

                return listeFacture;
            }
        }
    }
}
