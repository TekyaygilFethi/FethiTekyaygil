using FethiTekyaygilWebsite.Business.ManagerFolder.ComplexManagerFolder;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.DeveloperModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FethiTekyaygilWebsite.MVC.ViewComponents
{
    [ViewComponent]
    public class DeveloperViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            DeveloperResponseModel model = null;
            using (var manager = new ComplexManager())
            {
                var response = manager.GetDeveloper();
                if (response.IsSuccess)
                {
                    model = response.Object;
                }
            }
            return View("_Developer", model);
        }
    }
}
