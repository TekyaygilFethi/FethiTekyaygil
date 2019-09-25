using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FethiTekyaygilWebsite.MVC.ViewComponents
{
    [ViewComponent]
    public class FollowMeViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("_FollowMe");
        }
    }
}
