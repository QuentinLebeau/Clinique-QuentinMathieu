using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ConnectionBDD
    {

        private static IDbConnection cnx;

        public static DbConnection SeConnecter()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["connexionSQL"];
            DbConnection cnx = DbProviderFactories.GetFactory(settings.ProviderName).CreateConnection();

            cnx.ConnectionString = settings.ConnectionString;
            cnx.Open();

            return cnx;
        }

        public static IDbCommand creerRequete(string requete)
        {
            IDbCommand cmd = cnx.CreateCommand();
            cmd.CommandText = requete;
            cmd.CommandType = CommandType.Text;
            return cmd;
        }

        public static IDbCommand creerProcedureStockee(string requete)
        {
            IDbCommand cmd = cnx.CreateCommand();
            cmd.CommandText = requete;
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        public static void creerParametre(IDbCommand cmd, string nomParametre, object valeur, ParameterDirection direction = ParameterDirection.Input, DbType type = DbType.String, int taille = 0)
        {
            IDbDataParameter param = cmd.CreateParameter();
            param.ParameterName = nomParametre;
            param.Value = valeur;
            param.DbType = type;
            param.Direction = direction;
            if (taille > 0)
            {
                param.Size = taille;
            }
            cmd.Parameters.Add(param);
        }
    }
}
