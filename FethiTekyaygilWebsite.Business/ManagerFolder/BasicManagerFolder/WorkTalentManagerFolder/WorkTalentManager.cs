using FethiTekyaygilWebsite.Data.GlobalDatas;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.WorkTalentModels;
using FethiTekyaygilWebsite.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace FethiTekyaygilWebsite.Business.ManagerFolder.BasicManagerFolder.WorkTalentManagerFolder
{
    public class WorkTalentManager:GenericManager<WorkTalent>
    {
        public List<TempWorkTalent> GetWorkTalentsForDisplay()
        {
            try
            {
                string qry = "SELECT Name,Rate,CategoryNumber as Category FROM WorkTalentTable";

                var responseObject = base.GetCustom<TempWorkTalent>(qry);

                return responseObject;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
