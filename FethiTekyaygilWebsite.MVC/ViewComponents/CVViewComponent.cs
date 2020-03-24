using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FethiTekyaygilWebsite.MVC.ViewComponents
{
    [ViewComponent]
    public class CVViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("_CV");
        }
    }
}
