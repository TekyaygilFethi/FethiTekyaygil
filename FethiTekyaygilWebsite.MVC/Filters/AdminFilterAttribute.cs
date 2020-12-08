using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FethiTekyaygilWebsite.MVC.Filters
{
    public class AdminFilterAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context == default)
                throw new ArgumentNullException(nameof(context));

            if (context.HttpContext.User.Claims.Where(w => w.Type == "UserRole").Select(s => s.Value).SingleOrDefault() != "Admin")
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Home", action = "Index" }));
            }
        }
    }
}
