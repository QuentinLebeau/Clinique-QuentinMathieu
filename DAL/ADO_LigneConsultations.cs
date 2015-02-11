using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ADO_LigneConsultations
    {
        public static List<LignesConsultations> getListeConsultation()
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                List<LignesConsultations> listeConsultation = new List<LignesConsultations>();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();

                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM LignesConsultations";
                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                foreach (DataRow uneConsultation in resultat.Rows)
                {
                    listeConsultation.Add(new LignesConsultations(uneConsultation));
                }

                return listeConsultation;
            }
        }

        public static LignesConsultations getOneLignesConsultation(Guid pCodeConsultations, Guid pNumLigne)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                LignesConsultations uneConsultation = new LignesConsultations();
                SqlDataAdapter monAdapter = new SqlDataAdapter();
                DataTable resultat = new DataTable();
                SqlParameter monParametre;
                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " SELECT * " +
                                  " FROM LignesConsultations" +
                                  " WHERE CodeConsultation = @codeConsultation" +
                                  " AND NumLigne = @NumLigne ; ";

                monParametre = new SqlParameter("@codeConsultation", pCodeConsultations);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@NumLigne", pNumLigne);
                cmd.Parameters.Add(monParametre);

                monAdapter.SelectCommand = cmd;
                monAdapter.Fill(resultat);

                uneConsultation = new LignesConsultations(resultat.Rows[0]);

                return uneConsultation;
            }
        }

        public static void Add(LignesConsultations lignesConsultation)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlParameter monParametre;
                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();

                cmd.CommandText = " exec ajout_ligneConsultation @CodeConsultation, @DateVigueur, @CodeGroupement, @Prix, @RappelEnvoye, @Archive";

                monParametre = new SqlParameter("@CodeConsultation", lignesConsultation.CodeConsultation);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@CodeGroupement", lignesConsultation.CodeGroupement);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@DateVigueur", lignesConsultation.DateVigueur);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Prix", lignesConsultation.Prix);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@RappelEnvoye", lignesConsultation.RappelEnvoye);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@Archive", lignesConsultation.Archive);
                cmd.Parameters.Add(monParametre);

                cmd.ExecuteNonQuery();
            }
        }
                
        public static void Delete(LignesConsultations pLigneConsultation)
        {
            using (DbConnection cnx = ConnectionBDD.SeConnecter())
            {
                SqlParameter monParametre;
                SqlCommand cmd = (SqlCommand)cnx.CreateCommand();
                cmd.CommandText = " DELETE FROM LignesConsultations " +
                                  " WHERE CodeConsultation = @codeConsultations " +
                                  " AND NumLigne = @NumLigne; ";

                monParametre = new SqlParameter("@codeConsultations", pLigneConsultation.CodeConsultation);
                cmd.Parameters.Add(monParametre);
                monParametre = new SqlParameter("@NumLigne", pLigneConsultation.NumLigne);
                cmd.Parameters.Add(monParametre);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
