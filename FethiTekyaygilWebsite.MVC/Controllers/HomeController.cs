using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
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
