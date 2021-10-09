using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.DataAccessLayer
{
    public enum ConnectionType
    {
            Sql
        ,   Text
    }
    public static class GlobalConfig
    {

        #region Constructior
        public GlobalConfig()
        {
            // TO DO 
            //InitializeComponent();
        }

        public static IDataConnection Connection { get; private set; }


        public static void InitializeConnection(ConnectionType connType)
        {
            switch (connType)
            {
                case ConnectionType.Sql:
                    Connection = new SqlConnector();
                    break;

                case ConnectionType.Text:
                    Connection = new TextConnector();
                    break;
            }
        }

        public static ConnectionType AppConfigConnectionTypeKey
        {
            get
            {
                string configValue = string.Empty;

                configValue = ConfigurationManager.AppSettings["SqlServer"];        // TO DO  - procedure save sql server name to DB connection string
                configValue = ConfigurationManager.AppSettings["SqlDB"];            // TO DO  - procedure save DB name to DB connection string
                configValue = ConfigurationManager.AppSettings["ConnectionType"];

                ConnectionType value = (ConnectionType)Enum.Parse(typeof(ConnectionType), configValue);
                return value;
            }
        }
    }
}
