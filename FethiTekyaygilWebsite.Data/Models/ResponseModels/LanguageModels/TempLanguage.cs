using FethiTekyaygilWebsite.Data.Models.ResponseModels.LanguageCategoryModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FethiTekyaygilWebsite.Data.Models.ResponseModels.LanguageModels
{
    public class TempLanguage
    {
        public string Name { get; set; }

        public List<TempLanguageCategory> TempLanguageCategory { get; set; }
    }
}
