using System;
using System.Collections.Generic;
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
    }
}
