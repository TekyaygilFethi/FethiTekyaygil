using FethiTekyaygilWebsite.Data.Language;
using Microsoft.AspNetCore.Mvc;

namespace FethiTekyaygilWebsite.MVC.ViewComponents
{
    [ViewComponent]
    public class EntranceViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("_Entrance");
        }
    }
}
