using FethiTekyaygilWebsite.Data.GlobalDatas;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.DeveloperModels;
using FethiTekyaygilWebsite.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace FethiTekyaygilWebsite.Business.ManagerFolder.BasicManagerFolder.DeveloperManagerFolder
{
    public class DeveloperManager:GenericManager<Developer>
    {
        public DeveloperResponseModel GetDeveloper()
        {
            try
            {
                string qry = string.Empty;
                if (Globals.Language == "TR")
                    qry = "SELECT Name,ImageName,Surname,Email, Birthday,TurkishTitle as Title, TurkishAboutMe as AboutMe FROM DeveloperTable";
                else
                    qry = "SELECT Name,ImageName,Surname,Email, Birthday,EnglishTitle as Title, EnglishAboutme as AboutMe FROM DeveloperTable";

                var responseObject = base.GetSingleCustom<DeveloperResponseModel>(qry);

                responseObject.ImageName = (Globals.MediaFolder + responseObject.ImageName).Replace("\\", "/");

                return responseObject;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
