using Microsoft.AspNetCore.Mvc;

namespace FethiTekyaygilWebsite.MVC.ViewComponents
{
    [ViewComponent]
    [ResponseCache(Duration = 3600)]
    public class EntranceViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("_Entrance");
        }
    }
}
