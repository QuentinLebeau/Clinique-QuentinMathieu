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
                                  " FROM Veterinaires";
                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                foreach (DataRow unVeto in resultat.Rows)
                {
                    listeVeto.Add(new Veterinaires(unVeto));
                }

                return listeVeto;
            }
        }

        public static List<Veterinaires> ajouterVeto()
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                List<Veterinaires> listeVeto = new List<Veterinaires>();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " exec ajout_Veterinaire " +
                                  " '', ''";
                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                foreach (DataRow unVeto in resultat.Rows)
                {
                    listeVeto.Add(new Veterinaires(unVeto));
                }

                return listeVeto;
            }
        }
    }
}