﻿
using FethiTekyaygilWebsite.MVC.Model.RequestModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FethiTekyaygilWebsite.MVC.ViewComponents
{
    [ViewComponent]
    [ResponseCache(Duration = 3600)]
    public class ContactMeViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("_ContactMe",new AddContactModel());
        }
    }
}
