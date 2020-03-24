using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FethiTekyaygilWebsite.MVC.ViewComponents
{
    [ViewComponent]
    public class HobbiesViewComponent : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
