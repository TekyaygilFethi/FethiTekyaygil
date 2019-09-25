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
        //private static readonly string MSSQLConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=FethiTekyaygilWebsiteDatabase;Integrated Security=True";
        private static readonly string MSSQLConnectionString = @"Server=236176ca-4c58-44c4-9dea-aad30092f879.sqlserver.sequelizer.com;Database=db236176ca4c5844c49deaaad30092f879;User ID=cmcjjbeuyyvslsha;Password=KF7uWtSa8iLUgjhnBFrQgpn4zDUMi5tyJwbshWXTSewmAyPXYLq4zG4usc4rGfZd;";

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
