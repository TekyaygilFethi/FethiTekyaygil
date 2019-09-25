using FethiTekyaygilWebsite.Data.Models.ResponseModels.CommunicationModels;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.LanguageModels;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.WorkTalentModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FethiTekyaygilWebsite.Data.Models.ResponseModels.PersonalTalentModels
{
    public class GetPersonalTalentModel
    {
        public string NativeLanguage { get; set; }

        public List<TempLanguage> TempLanguages { get; set; }

        public List<CommunicationRepsonseModel> CommunicationTalents { get; set; }

        //public List<TempWorkTalent> TempWorkTalents { get; set; }




        /*
         * public string NativeLanguage { get; set; }

        public string LanguageName { get; set; }

        public string CategoryName { get; set; }

        public string LanguageDegree { get; set; }

        public string WorkTalentName { get; set; }

        public string WorkTalentRate { get; set; }

        public string CommunicationTalents { get; set; }
         * 
         * 
         * */
    }
}
