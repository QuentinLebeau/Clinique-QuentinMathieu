using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Configuration;

namespace DAL
{
    public class ConnectionBDD
    {
        public static DbConnection SeConnecter()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["connexionSQL"];
            DbConnection cnx = DbProviderFactories.GetFactory(settings.ProviderName).CreateConnection();

            cnx.ConnectionString = settings.ConnectionString;
            cnx.Open();

            return cnx;
        }
    }
}
