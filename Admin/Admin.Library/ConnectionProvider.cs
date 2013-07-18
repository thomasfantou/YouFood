using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Admin.Library
{
    public class ConnectionProvider
    {
        public static string ConnectionString()
        {
            string cnn = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
            return cnn;
        }
    }
}
