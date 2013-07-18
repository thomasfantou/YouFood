using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Local.Library
{
    public class ConnectionProvider
    {
        public static string ConnectionString()
        {
            string cnn = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
            return cnn;
        }

        public static string ServerConnectionString()
        {
            string cnn = System.Configuration.ConfigurationManager.AppSettings["ServerConnectionString"];
            return cnn;
        }

    }
}
