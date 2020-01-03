using FethiTekyaygilWebsite.Business.ManagerFolder.ComplexManagerFolder;
using FethiTekyaygilWebsite.Data.Language;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.ProjectModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FethiTekyaygilWebsite.MVC.ViewComponents
{
    [ViewComponent]
    public class ProjectsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<GetProjectsModel> model = null;
            using (var manager = new ComplexManager())
            {
                var response = manager.GetProjects();
                if (response.IsSuccess)
                {
                    model = response.Object;
                }
            }
            return View("_Projects", model);
        }

    }
}
