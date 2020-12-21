using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Dapper;
using FethiTekyaygilWebsite.MVC.Filters;
using FethiTekyaygilWebsite.MVC.Model.AdminModel;
using FethiTekyaygilWebsite.MVC.Model.POCO;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FethiTekyaygilWebsite.MVC.Controllers
{
    [Route("Admin")]
    public class AdminController : Controller
    {
        IConfigurationRoot configuration;

        public AdminController()
        {
            configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
        }

        //[AdminFilter]
        [Microsoft.AspNetCore.Authorization.Authorize]
        [Route("Messages")]
        public IActionResult Messages(string filterText = null, int page = 0)
        {
            ViewData["CurrentPage"] = page;
            var list = GetContacts(filterText, page);

            return View(list);
        }

        private List<Contact> GetContacts(string filterText = null, int page = 0)
        {
            var responseList = new List<Contact>();

            using (var connObject = new SqlConnection(configuration.GetConnectionString("MsSQL")))
            {
                string query = $"SELECT * FROM ContactTable";

                if (filterText != null)
                {
                    page = 0;
                    query += " WHERE Email LIKE '%" + filterText + "%' OR Message LIKE '%" + filterText + "%' OR Name LIKE '%" + filterText + "%' OR SendDate LIKE '%" + filterText + "%'";
                }
                 query+=$" ORDER BY SendDate DESC OFFSET {page*10} ROWS FETCH NEXT {10} ROWS ONLY";

                connObject.Open();

                responseList.AddRange(connObject.Query<Contact>(query));

                connObject.Close();

            }
            return responseList;
        }


        private List<Contact> ChangePage(List<Contact> list, int page)
        {
            return list.Skip(page * 10).Take(10).ToList();
        }

        private List<Contact> Filter(string filterText)
        {
            if (String.IsNullOrEmpty(filterText))
                GetContacts();
            else
            {
                using (var connObject = new SqlConnection(configuration.GetConnectionString("MsSQL")))
                {
                    string query = $"SELECT * FROM ContactTable WHERE Name LIKE '% @filter %' OR Email LIKE @filter OR Message LIKE @filter";

                    connObject.Open();

                    using (SqlCommand command = new SqlCommand(query, connObject))
                    {
                        command.Parameters.AddWithValue("@filter", "%" + filterText + "%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {


                            while (reader.Read())
                            {
                                new Contact
                                {
                                    ID = (int)reader[0],
                                    Name = (string)reader[1],
                                    Email = (string)reader[2],
                                    Message = (string)reader[3],
                                    SendDate = (DateTime)reader[4]
                                };
                            }
                        }
                    }
                    connObject.Close();

                }
            }
            return null;
        }


        [Route("LoginPage")]
        public IActionResult LoginPage()
        {
            return View();
        }


        [Route("Login"), HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                using (var connObject = new SqlConnection(configuration.GetConnectionString("MsSQL")))
                {
                    string query = $"SELECT * FROM UserTable WHERE Username=@username AND Password=@password";
                    try
                    {
                        connObject.Open();

                        using (SqlCommand command = new SqlCommand(query, connObject))
                        {
                            SqlParameter usernameParam = new SqlParameter
                            {
                                ParameterName = "@username",
                                Value = loginModel.Username
                            };

                            SqlParameter passwordParam = new SqlParameter
                            {
                                ParameterName = "@password",
                                Value = loginModel.Password
                            };


                            command.Parameters.Add(usernameParam);
                            command.Parameters.Add(passwordParam);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {

                                    var claims = new List<Claim>();
                                    claims.Add(new Claim("UserRole", "Admin"));

                                    var userIdentity = new ClaimsIdentity(claims, "login");

                                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                                    await HttpContext.SignInAsync(principal);


                                    return RedirectToAction("Messages");
                                    //userID = (string)reader[0];
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        return RedirectToAction("Error","Home");
                    }
                    finally
                    {
                        connObject.Close();
                    }
                }
                return Json(new { IsSuccess = false, Message = "Kullanıcı adı veya şifre hatalı!" });
            }
            else
            {
                return Json(new { IsSuccess = false, Message = "Kullanıcı adı veya şifre hatalı!" });
            }
        }

        public async Task<IActionResult> Logout(LoginModel loginModel)
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}