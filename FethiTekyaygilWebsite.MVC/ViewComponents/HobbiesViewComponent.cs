using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FethiTekyaygilWebsite.MVC.ViewComponents
{
    [ViewComponent]
    [ResponseCache(Duration = 3600)]
    public class HobbiesViewComponent : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
