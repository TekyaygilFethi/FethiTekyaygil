
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FethiTekyaygilWebsite.MVC.ViewComponents
{
    [ViewComponent]
    [ResponseCache(Duration = 3600)]
    public class ProjectsViewComponent:ViewComponent
    {
        //IMemoryCache _memoryCache;
        //public ProjectsViewComponent(IMemoryCache memoryCache)
        //{
        //    _memoryCache = memoryCache;
        //}

        public IViewComponentResult Invoke()
        {
            //const string key = "projectCaches";

            //if (_memoryCache.TryGetValue(key, out object list))
            //    return View("_Projects", list);

            //_memoryCache.Set(key, model, new MemoryCacheEntryOptions
            //{
            //    AbsoluteExpiration = DateTime.Now.AddHours(7),
            //    Priority = CacheItemPriority.Normal
            //});

            return View("_Projects");
        }

    }
}
