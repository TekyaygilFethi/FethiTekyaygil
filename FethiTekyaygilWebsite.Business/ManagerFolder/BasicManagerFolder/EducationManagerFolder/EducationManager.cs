using FethiTekyaygilWebsite.Data.GlobalDatas;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.EducationModels;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.GenericModels;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.TimelineModels;
using FethiTekyaygilWebsite.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace FethiTekyaygilWebsite.Business.ManagerFolder.BasicManagerFolder.EducationManagerFolder
{
    public class EducationManager:GenericManager<Education>
    {
        public List<TimelineResponseModel> GetEducationsForDisplay()
        {
            try
            {
                string qry = string.Empty;
                if (Globals.Language == "TR")
                    qry = "SELECT TurkishDepartment as Position, TurkishSchool as Institution, ImageName,StartDate,EndDate,IsPresent, TurkishExplanation as Explanation,TurkishAddress as Address, Website, 'TRUE' as IsEducation FROM EducationTable";
                else
                    qry = "SELECT EnglishDepartment as Position, EnglishSchool as Institution, ImageName,StartDate,EndDate,IsPresent, EnglishExplanation as Explanation,EnglishAddress as Address, Website, 'TRUE' as IsEducation FROM EducationTable"; ;

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
