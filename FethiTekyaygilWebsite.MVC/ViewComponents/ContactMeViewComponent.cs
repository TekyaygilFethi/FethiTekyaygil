using FethiTekyaygilWebsite.Data.GlobalDatas;
using FethiTekyaygilWebsite.Data.Language;
using FethiTekyaygilWebsite.Data.Models.RequestModels.ContactModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FethiTekyaygilWebsite.MVC.ViewComponents
{
    [ViewComponent]
    public class ContactMeViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("_ContactMe",new AddContactModel());
        }
    }
}
