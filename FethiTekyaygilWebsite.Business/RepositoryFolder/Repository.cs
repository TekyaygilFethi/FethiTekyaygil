using Dapper;
using FethiTekyaygilWebsite.Database.DatabaseContextFolder;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;

namespace FethiTekyaygilWebsite.Business.RepositoryFolder
{
    public class Repository : IRepository
    {
        DatabaseProvider provider;
        //private 

        public Repository(DatabaseProvider provider)
        {
            this.provider = provider;
        }

        public virtual IEnumerable<T> Query<T>(string query)
        {
            if (!string.IsNullOrWhiteSpace(query))
            {
                using (var connObject=DatabaseContextSelector.GetDbContext(provider))
                {
                    try
                    {
                        connObject.Open();
                        return connObject.Query<T>(query);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message + " \nQuery: " + query);
                    }
                }
            }
            else
                throw new Exception($"Query must be valid! Query: {query}");
        }

        public virtual int Execute(string query)
        {
            if (!string.IsNullOrWhiteSpace(query))
            {
                using (var connObject=DatabaseContextSelector.GetDbContext(provider))
                {
                    try
                    {
                        connObject.Open();
                        return connObject.Execute(query);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message + " \nQuery: " + query);
                    }
                }
            }
            else
                throw new Exception($"Query must be valid! Query: {query}");
        }


    }
}
