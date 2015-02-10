using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ADO_relance
    {
        public static DataTable getListeClients()
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                List<Clients> listeClient = new List<Clients>();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " select lc.CodeConsultation, lc.DateVigueur, lc.Prix, " +
                                  " DATEADD(MONTH, v.PeriodeValidite, lc.DateVigueur) as dateConsultationValidite " +
                                  " from Clients c" +
                                  " inner join Animaux a on c.CodeClient = a.CodeClient " +
                                  " inner join Consultations co on a.CodeAnimal = co.CodeAnimal " +
                                  " inner join LignesConsultations lc on co.CodeConsultation = lc.CodeConsultation " +
                                  " inner join Baremes b on lc.CodeGroupement = b.CodeGroupement " +
                                  " inner join Vaccins v on b.CodeVaccin = v.CodeVaccin;  ";
                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                //foreach (DataRow unClient in resultat.Rows)
                //{
                //    listeClient.Add(new Clients(unClient));
                //}

                return resultat;
            }
        }
    }
}
