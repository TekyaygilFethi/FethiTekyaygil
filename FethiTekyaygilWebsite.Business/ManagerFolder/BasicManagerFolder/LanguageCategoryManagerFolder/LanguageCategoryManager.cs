using FethiTekyaygilWebsite.Data.GlobalDatas;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.LanguageCategoryModels;
using FethiTekyaygilWebsite.Data.POCOs;
using System;
using System.Collections.Generic;

namespace FethiTekyaygilWebsite.Business.ManagerFolder.BasicManagerFolder.LanguageCategoryManagerFolder
{
    public class LanguageCategoryManager : GenericManager<LanguageCategory>
    {
        public List<TempLanguageCategory> GetLanguageCategoriesForDisplay()
        {
            try
            {
                string qry = string.Empty;
                if (Globals.Language == "TR")
                    qry = "SELECT lc.TurkishCategory as Name,ld.Degree FROM LanguageCategoryTable as lc JOIN LanguageDegreeTable as ld ON lc.LanguageDegreeID=ld.ID ";
                else
                    qry = "SELECT lc.EnglishCategory as Name,ld.Degree FROM LanguageCategoryTable as lc JOIN LanguageDegreeTable as ld ON lc.LanguageDegreeID=ld.ID ";

                var responseObject = base.GetCustom<TempLanguageCategory>(qry);

                return responseObject;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
