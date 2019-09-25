using FethiTekyaygilWebsite.Data.GlobalDatas;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.GenericModels;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.TimelineModels;
using FethiTekyaygilWebsite.Data.POCOs;
using System;
using System.Collections.Generic;

namespace FethiTekyaygilWebsite.Business.ManagerFolder.BasicManagerFolder.ExperienceManagerFolder
{
    public class ExperienceManager : GenericManager<WorkExperience>
    {
        public List<TimelineResponseModel> GetExperiencesForDisplay()
        {
            try
            {
                string qry = string.Empty;
                if (Globals.Language == "TR")
                    qry = "SELECT TurkishPosition as Position, Company as Institution, ImageName,StartDate,EndDate,IsPresent, TurkishExplanation as Explanation,TurkishAddress as Address, Website FROM WorkExperienceTable";
                else
                    qry = "SELECT EnglishPosition as Position, Company as Institution, ImageName,StartDate,EndDate,IsPresent, EnglishExplanation as Explanation,EnglishAddress as Address, Website FROM WorkExperienceTable";

                var responseObject = base.GetCustom<TimelineResponseModel>(qry);

                return responseObject;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
