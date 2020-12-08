using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FethiTekyaygilWebsite.MVC.Controllers
{
    [Route("videos")]
    public class VideosController : Controller
    {
        [HttpGet,Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}