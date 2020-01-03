using FethiTekyaygilWebsite.Data.Attributes;
using FethiTekyaygilWebsite.Data.POCOs.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FethiTekyaygilWebsite.Data.POCOs
{
    [Table("LanguageCategoryTable")]
    public class LanguageCategory : BasePOCO
    {

        public LanguageCategory()
        {
            Languages = new List<LanguageLanguageCategory>();
        }
        [Required]
        public string TurkishCategory { get; set; }

        [Required]
        public string EnglishCategory { get; set; }

        [Required]
        public int LanguageDegreeID { get; set; }
        
        public List<LanguageLanguageCategory> Languages { get; set; }

        [SkipProperty, ForeignKey("LanguageDegreeID")]
        public virtual LanguageDegree LanguageDegree { get; set; }
    }
}
