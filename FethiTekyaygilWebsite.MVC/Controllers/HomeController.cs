using FethiTekyaygilWebsite.Business.ManagerFolder.ComplexManagerFolder;
using FethiTekyaygilWebsite.Data.GlobalDatas;
using FethiTekyaygilWebsite.Data.Language;
using Microsoft.AspNetCore.Mvc;

namespace FethiTekyaygilWebsite.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //IndexResponseModel model = null;

            //using (var manager = new ComplexManager())
            //{
            //    var response = manager.GetDatas();
            //    if (response.IsSuccess)
            //    {
            //        model = response.Object;
            //    }
            //}
            return View();
        }

        [HttpPost]
        public JsonResult ChangeLanguage(string Language)
        {
            if (Language != Globals.Language)
            {
                Globals.Language = Language;
                return Json(new { IsSuccess = true });
            }
            else
            {
                return Json(new { IsSuccess = false, Message = LanguageDictionary.GetString("LanguageChangeError") });
            }
        }

        [HttpGet]
        public JsonResult GetWorkTalents()
        {
            using (var manager = new ComplexManager())
            {
                var response = manager.GetWorkTalents();

                if (response.IsSuccess)
                    return Json(new { IsSuccess = "true", Item = response.Object });
                else
                    return Json(new { IsSuccess = "false", Item = response.Object });
            }
        }
        public IActionResult ErrorPage(string message)
        {
            ViewData["ErrorMessage"] = message;
            return View();
        }
    }
}
