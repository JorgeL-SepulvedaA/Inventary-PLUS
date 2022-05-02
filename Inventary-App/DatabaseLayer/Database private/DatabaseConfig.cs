using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseLayer.Database_private
{
    public static class DatabaseConfig
    {
        private static readonly string name = "";
        private static readonly string connectionString = "";
        private static readonly string provider = "providerName=" + '"' + "System.Data.SqlClient" + '"';

        public static string ConnectionString { get { return connectionString; } }
    }
}
