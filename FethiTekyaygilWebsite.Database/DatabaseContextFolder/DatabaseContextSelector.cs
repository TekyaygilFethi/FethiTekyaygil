using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace FethiTekyaygilWebsite.Database.DatabaseContextFolder
{
    public enum DatabaseProvider
    {
        MySQL,
        MSSQL
    }

    public class DatabaseContextSelector
    {
        private static readonly string MySQLConnectionString = @"server=localhost;database=FethiTekyaygilWebsiteDatabase;user=root;password=Idecon1*";
        private static readonly string MSSQLConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=FethiTekyaygilWebsiteDatabase;Integrated Security=True";


        public static string GetConnectionString(DatabaseProvider provider)
        {
            if (provider == DatabaseProvider.MySQL)
            {
                return MySQLConnectionString;
            }
            else if (provider == DatabaseProvider.MSSQL)
            {
                return MSSQLConnectionString;
            }
            else
                throw new Exception("Provider is not valid!");
        }

        public static DbConnection GetDbContext(DatabaseProvider provider)
        {
            if (provider == DatabaseProvider.MySQL)
            {                
                return new MySqlConnection(MySQLConnectionString);
            }
            else if (provider == DatabaseProvider.MSSQL)
            {
                return new SqlConnection(MSSQLConnectionString);
            }
            else
                throw new Exception("Provider is not valid!");
        }
    }
}
