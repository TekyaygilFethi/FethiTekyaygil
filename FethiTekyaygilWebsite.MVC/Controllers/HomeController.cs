using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;
using System;
using System.Globalization;
using System.Threading;

namespace FethiTekyaygilWebsite.MVC.Controllers
{
    public class HomeController : Controller
    {
        [ResponseCache(Duration = 3600)]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ErrorPage(string message)
        {
            ViewData["ErrorMessage"] = message;
            return View();
        }
    }
}
