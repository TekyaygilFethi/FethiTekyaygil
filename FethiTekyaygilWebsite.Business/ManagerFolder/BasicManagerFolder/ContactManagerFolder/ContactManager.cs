using FethiTekyaygilWebsite.Data.Models.RequestModels.ContactModels;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.GenericModels;
using FethiTekyaygilWebsite.Data.POCOs;
using System;

namespace FethiTekyaygilWebsite.Business.ManagerFolder.BasicManagerFolder.ContactManagerFolder
{
    public class ContactManager : GenericManager<Contact>
    {
        public ResponseObject<int> CreateContact(AddContactModel model)
        {
            try
            {
                var responseObject = base.Create(new Contact { Email = model.Email, Message = model.Message, Name = model.Name });

                return responseObject;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

