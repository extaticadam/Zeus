using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioLibrary.DataAccess;

namespace PortfolioLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitialiseConnections(bool database)
        {
            if (database)
            {
                SQLConnector SQL = new SQLConnector();
                Connections.Add(SQL);
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
