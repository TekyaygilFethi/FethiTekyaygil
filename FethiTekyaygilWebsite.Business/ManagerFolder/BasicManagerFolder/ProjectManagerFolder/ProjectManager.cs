using FethiTekyaygilWebsite.Data.GlobalDatas;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.ProjectModels;
using FethiTekyaygilWebsite.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace FethiTekyaygilWebsite.Business.ManagerFolder.BasicManagerFolder.ProjectManagerFolder
{
    public class ProjectManager: GenericManager<Project>
    {
        public List<GetProjectsModel> GetProjectsForDisplay()
        {
            try
            {
                string qry = string.Empty;
                if (Globals.Language == "TR")
                    qry = "SELECT TurkishName as Name, Link,Link2,IsMobile, TurkishExplanation as Explanation FROM ProjectTable ORDER BY Sira";
                else
                    qry = "SELECT EnglishName as Name, Link,Link2,IsMobile, EnglishExplanation as Explanation FROM ProjectTable ORDER BY Sira";

                var responseObject = base.GetCustom<GetProjectsModel>(qry);

                return responseObject;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
