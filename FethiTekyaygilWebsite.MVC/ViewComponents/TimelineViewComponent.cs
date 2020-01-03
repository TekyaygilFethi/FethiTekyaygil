using FethiTekyaygilWebsite.Business.ManagerFolder.ComplexManagerFolder;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.TimelineModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FethiTekyaygilWebsite.MVC.ViewComponents
{
    [ViewComponent]
    public class TimelineViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<TimelineResponseModel> model = null;
            using (var manager = new ComplexManager())
            {
                var response = manager.GetTimelines();
                if (response.IsSuccess)
                {
                    model = response.Object;
                }
            }
            return View("_Timeline", model);
        }
    }
}
