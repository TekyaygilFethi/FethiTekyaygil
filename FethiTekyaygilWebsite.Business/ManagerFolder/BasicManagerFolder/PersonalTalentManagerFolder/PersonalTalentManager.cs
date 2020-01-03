using FethiTekyaygilWebsite.Data.GlobalDatas;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.CommunicationModels;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.LanguageCategoryModels;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.PersonalTalentModels;
using FethiTekyaygilWebsite.Data.POCOs;
using FethiTekyaygilWebsite.Database.DatabaseContextFolder;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FethiTekyaygilWebsite.Business.ManagerFolder.BasicManagerFolder.PersonalTalentManagerFolder
{
    public class PersonalTalentManager : GenericManager<PersonalTalent>
    {
        public GetPersonalTalentModel GetPersonalTalentsForDisplay()
        {
            try
            {
                using (var context = new GenericDatabaseContext())
                {
                    if (Globals.Language == "TR")
                    {
                        return context.PersonalTalents.Select(s => new GetPersonalTalentModel
                        {
                            CommunicationTalents = s.CommunicationTalents.Select(ss => new CommunicationRepsonseModel { CommTalent = ss.TurkishCommunicationTalent, ImageUrl = (Globals.MediaFolder + ss.ImagePath).Replace("\\", "/") }).ToList(),
                            TempLanguages = s.Languages.Select(ss => new Data.Models.ResponseModels.LanguageModels.TempLanguage
                            {
                                Name = ss.TurkishName,
                                TempLanguageCategory = ss.Categories.Join(context.LanguageCategories, a => a.LanguageCategoryID, b => b.ID, (llc, lc) => new TempLanguageCategory { Degree = lc.LanguageDegree.Degree, Name = lc.TurkishCategory }).ToList()
                            }).ToList(),
                            //TempWorkTalents = s.WorkTalents.Select(ss => new TempWorkTalent
                            //{
                            //    Name = ss.Name,
                            //    Rate = ss.Rate,
                            //Category = ss.CategoryNumber
                            //}).ToList()
                        }).FirstOrDefault();

                    }
                    else
                    {
                        return context.PersonalTalents.Select(s => new GetPersonalTalentModel
                        {
                            CommunicationTalents = s.CommunicationTalents.Select(ss => new CommunicationRepsonseModel { CommTalent = ss.EnglishCommunicationTalent, ImageUrl = (Globals.MediaFolder + ss.ImagePath).Replace("\\", "/") }).ToList(),
                            TempLanguages = s.Languages.Select(ss => new Data.Models.ResponseModels.LanguageModels.TempLanguage
                            {
                                Name = ss.EnglishName,
                                TempLanguageCategory = ss.Categories.Join(context.LanguageCategories, a => a.LanguageCategoryID, b => b.ID, (llc, lc) => new TempLanguageCategory { Degree = lc.LanguageDegree.Degree, Name = lc.EnglishCategory }).ToList()
                            }).ToList(),
                            //TempWorkTalents = s.WorkTalents.Select(ss => new TempWorkTalent
                            //{
                            //    Name = ss.Name,
                            //    Rate = ss.Rate,
                            //Category = ss.CategoryNumber
                            //}).ToList()
                        }).FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
