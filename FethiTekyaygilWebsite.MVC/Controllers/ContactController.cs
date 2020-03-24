
using Dapper;
using FethiTekyaygilWebsite.MVC.Helpers.ConfigManager;
using FethiTekyaygilWebsite.MVC.Model.RequestModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;
using System.Globalization;

namespace FethiTekyaygilWebsite.MVC.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public JsonResult SendContact([FromBody]AddContactModel contactModel)
        {
            if (ModelState.IsValid)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

                using (var connObject = new SqlConnection(configuration.GetConnectionString("MsSQL")))
                {
                    string query = $"INSERT INTO ContactTable (Name,Email,Message,SendDate) VALUES('{contactModel.Name}','{contactModel.Email}','{contactModel.Message}','{DateTime.Now}') ";
                    try
                    {
                        connObject.Open();
                        connObject.Execute(query);
                    }
                    catch (Exception ex)
                    {
                        return Json(new { IsSuccess = false, Message = ex.Message + " \nQuery: " + query });
                    }
                }
                return Json(new { IsSuccess = true, Message = contactModel.Language == "EN" ? "Your messsage has been successfully sent!" : "Mesajınız başarıyla gönderildi!" });
            }
            else
            {
                return Json(new { IsSuccess = false, Message = "Model hatalı! Lütfen boş alanları doldurunuz!" });
            }
        }
    }
}