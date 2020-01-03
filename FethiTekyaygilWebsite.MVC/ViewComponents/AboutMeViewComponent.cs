using FethiTekyaygilWebsite.Business.ManagerFolder.ComplexManagerFolder;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.HobbyModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FethiTekyaygilWebsite.MVC.ViewComponents
{
    [ViewComponent]
    public class AboutMeViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<HobbyResponseModel> model = null;
            using (var manager = new ComplexManager())
            {
                var response = manager.GetHobbies();
                if (response.IsSuccess)
                {
                    model = response.Object;
                }
            }
            return View("_AboutMe", model);

        }
    }
}
