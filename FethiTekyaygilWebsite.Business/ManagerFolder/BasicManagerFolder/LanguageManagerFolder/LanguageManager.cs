using FethiTekyaygilWebsite.Data.GlobalDatas;
using FethiTekyaygilWebsite.Data.POCOs;
using System;
using System.Collections.Generic;

namespace FethiTekyaygilWebsite.Business.ManagerFolder.BasicManagerFolder.LanguageManagerFolder
{
    public class LanguageManager : GenericManager<Language>
    {
        public List<string> GetLanguagesForDisplay()
        {
            try
            {
                string qry = string.Empty;
                if (Globals.Language == "TR")
                    qry = "SELECT TurkishName FROM LanguageTable";
                else
                    qry = "SELECT EnglishName FROM LanguageTable";

                var responseObject = base.GetCustom<string>(qry);

                return responseObject;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}