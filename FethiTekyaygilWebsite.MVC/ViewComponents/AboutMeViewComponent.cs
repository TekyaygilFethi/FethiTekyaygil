using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;

namespace FethiTekyaygilWebsite.MVC.ViewComponents
{
    [ViewComponent]
    [ResponseCache(Duration = 3600)]
    public class AboutMeViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("_AboutMe");
        }
    }
}
