using FethiTekyaygilWebsite.Business.ManagerFolder.ComplexManagerFolder;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.PersonalTalentModels;
using Microsoft.AspNetCore.Mvc;

namespace FethiTekyaygilWebsite.MVC.ViewComponents
{
    [ViewComponent]
    public class PersonalTalentsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            GetPersonalTalentModel model = null;
            using (var manager = new ComplexManager())
            {
                var response = manager.GetPersonalTalents();
                if (response.IsSuccess)
                {
                    model = response.Object;
                }
            }
            return View("_PersonalTalents", model);
        }
    }
}
