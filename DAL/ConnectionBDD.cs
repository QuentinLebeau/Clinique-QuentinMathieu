using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class ConnectionBDD
    {

        private static IDbConnection _cnx;

        public static DbConnection SeConnecter()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["connexionSQL"];
            DbConnection cnx = DbProviderFactories.GetFactory(settings.ProviderName).CreateConnection();

            cnx.ConnectionString = settings.ConnectionString;
            cnx.Open();

            return cnx;
        }

        public static IDbConnection seConnecter2()
        {
            try
            {
                if (((_cnx == null)
                            || ((_cnx.State == ConnectionState.Closed)
                            || (_cnx.State == ConnectionState.Broken))))
                {
                    ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["BDD_Clinique"];
                    _cnx = DbProviderFactories.GetFactory(settings.ProviderName).CreateConnection();
                    _cnx.ConnectionString = settings.ConnectionString;
                    _cnx.Open();
                }
                return _cnx;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(string.Format("Une erreur est survenue à la connexion à la base de données : {0}", ex.Message));
            }
        }
    }
}
