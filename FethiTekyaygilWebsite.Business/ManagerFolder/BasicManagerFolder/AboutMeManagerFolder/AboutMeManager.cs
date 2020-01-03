using FethiTekyaygilWebsite.Data.GlobalDatas;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.HobbyModels;
using FethiTekyaygilWebsite.Data.POCOs;
using System;
using System.Collections.Generic;

namespace FethiTekyaygilWebsite.Business.ManagerFolder.BasicManagerFolder.AboutMeManagerFolder
{
    public class AboutMeManager : GenericManager<Hobby>
    {
        public List<HobbyResponseModel> GetHobbies()
        {
            try
            {
                string qry = string.Empty;
                if (Globals.Language == "TR")
                    qry = "SELECT TurkishName as Name,ImageName,VideoName,TurkishExplanation as Explanation FROM HobbyTable";
                else
                    qry = "SELECT EnglishName as Name,ImageName,VideoName,EnglishExplanation as Explanation FROM HobbyTable";

                var responseObjectList = base.GetCustom<HobbyResponseModel>(qry);

                foreach (var responseObject in responseObjectList)
                {
                    responseObject.ImageName = (Globals.MediaFolder + responseObject.ImageName).Replace("\\", "/");
                    responseObject.VideoName = (Globals.MediaFolder + responseObject.VideoName).Replace("\\", "/");
                }

                return responseObjectList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
