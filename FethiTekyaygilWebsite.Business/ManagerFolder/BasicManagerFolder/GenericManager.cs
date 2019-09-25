using FethiTekyaygilWebsite.Business.ManagerFolder.IManagerFolder;
using FethiTekyaygilWebsite.Business.RepositoryFolder;
using FethiTekyaygilWebsite.Data.Attributes;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.GenericModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FethiTekyaygilWebsite.Business.ManagerFolder.BasicManagerFolder
{
    public class GenericManager<T> : BaseManager where T : class
    {
        Repository repository;

        public GenericManager()
        {
            repository = new Repository(Database.DatabaseContextFolder.DatabaseProvider.MSSQL);
        }

        public ResponseObject<List<T>> GetAll()
        {
            ResponseObject<List<T>> response = new ResponseObject<List<T>>();

            try
            {
                var getContactsQuery = $"SELECT * FROM {typeof(T).Name}Table";
                var responseObject = repository.Query<T>(getContactsQuery);

                response.IsSuccess = true;
                response.Message = "success";
                response.Object = responseObject.ToList();
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public ResponseObject<int> Create(T item)
        {
            ResponseObject<int> response = new ResponseObject<int>();

            try
            {
                var dict = GetColumnAndValuesOfItem(item);
                //dict["SendDate"]=repository.Query<string>("SELECT GETDATE()").FirstOrDefault();

                var props = String.Join(",", dict.Keys);
                var values = String.Join(",", dict.Values);

                var createQuery = $"INSERT INTO {typeof(T).Name}Table ({props}) VALUES ({values})";
                repository.Execute(createQuery);


                var idQuery = $"SELECT ID FROM {typeof(T).Name}Table WHERE ";


                foreach (var kvPair in dict)
                {
                        idQuery += $"{kvPair.Key}={kvPair.Value} AND ";
                }

                idQuery = idQuery.Substring(0, idQuery.Length - 5);

                int newID = repository.Query<int>(idQuery).FirstOrDefault();

                response.IsSuccess = true;
                response.Message = "success";
                response.Object = newID;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public List<TEntity> GetCustom<TEntity>(string query)
        {
            try
            {
                var responseObject = repository.Query<TEntity>(query);

                return responseObject.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TEntity GetSingleCustom<TEntity>(string query)
        {
            return GetCustom<TEntity>(query).FirstOrDefault();
        }

        private Dictionary<string, string> GetColumnAndValuesOfItem(T item)
        {
            Dictionary<string, string> responseDict = new Dictionary<string, string>();

            var properties = typeof(T).GetProperties().Where(w => w.Name != "ID" && w.GetCustomAttributes(typeof(SkipPropertyAttribute), true).Length == 0).ToList();

            foreach (var property in properties)
            {
                if (property.PropertyType == typeof(int) || property.PropertyType == typeof(double))
                    responseDict.Add(property.Name, property.GetValue(item, null).ToString());
                else if (property.PropertyType == typeof(DateTime))
                    responseDict.Add(property.Name, "'" + (property.GetValue(item, null) as DateTime?).Value.ToString(@"yyyy/MM/dd hh:mm:ss tt", new CultureInfo("en-US")) + "'");
                else
                    responseDict.Add(property.Name, "'" + property.GetValue(item, null).ToString() + "'");
            }

            return responseDict;
        }

    }
}
