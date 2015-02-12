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
    public class ADO_Relance
    {
        public static DataTable GetAll()
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT A.NomAnimal AS Animal, (C.NomClient + ' ' + C.PrenomClient) AS Propriétaire " +
                                  " FROM Factures F " +
                                  " INNER JOIN Clients C ON F.CodeClient = C.CodeClient " +
                                  " INNER JOIN Animaux A ON A.CodeClient = C.CodeClient " +
                                  " INNER JOIN Consultations Consu ON Consu.NumFacture = F.NumFacture " +
                                  " INNER JOIN LignesConsultations LC ON LC.CodeConsultation = Consu.CodeConsultation " +
                                  " INNER JOIN Baremes B ON LC.CodeGroupement = B.CodeGroupement AND LC.DateVigueur = B.DateVigueur " +
                                  " INNER JOIN Vaccins V ON B.CodeVaccin = V.CodeVaccin " +
                                  " WHERE DATEDIFF(DAY, DATEADD(MONTH, V.PeriodeValidite, CONVERT(datetime,RIGHT(LC.DateVigueur ,2)+LEFT(LC.DateVigueur ,2)+SUBSTRING(LC.DateVigueur ,4,2))), SYSDATETIME()) >= 0 ;";
                
                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                return resultat;
            }
        }
    }
}
