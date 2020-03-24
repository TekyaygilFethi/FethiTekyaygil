
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;

namespace FethiTekyaygilWebsite.MVC.ViewComponents
{
    [ViewComponent]
    [ResponseCache(Duration = 3600)]
    public class PersonalTalentsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("_PersonalTalents");
        }
    }
}
