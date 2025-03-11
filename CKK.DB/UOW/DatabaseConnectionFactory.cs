using CKK.DB.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.DB.UOW
{
    public class DatabaseConnectionFactory : IConnectionFactory
    {
        //Method that places name in the conncectionStrings
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        //sets name of connectionString 
        //private readonly string connectionString = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = StructuredProjectDB";
        private readonly string connectionString = "Server=localhost\\SQLEXPRESS;Database=StructuredProjectDB;Trusted_Connection=True;";
        
        public IDbConnection GetConnection
        {
            get
            {
                DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);

                var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
                var conn = factory.CreateConnection();
                conn.ConnectionString = connectionString;
                return conn;
            }
           
        }
    }
}
