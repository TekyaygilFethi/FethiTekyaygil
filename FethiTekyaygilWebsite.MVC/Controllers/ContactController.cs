using FethiTekyaygilWebsite.Business.ManagerFolder.BasicManagerFolder.ContactManagerFolder;
using FethiTekyaygilWebsite.Data.Models.RequestModels.ContactModels;
using Microsoft.AspNetCore.Mvc;

namespace FethiTekyaygilWebsite.MVC.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        public JsonResult SendContact([FromBody]AddContactModel contactModel)
        {
            if (ModelState.IsValid)
            {
                using (var context = new ContactManager())
                {
                    var response = context.CreateContact(contactModel);
                    if (response.IsSuccess)
                        return Json(new { IsSuccess = true });
                    else
                        return Json(new { IsSuccess = false });
                }
            }
            else
            {
                return Json(new { IsSuccess = false });
            }
        }
    }
}