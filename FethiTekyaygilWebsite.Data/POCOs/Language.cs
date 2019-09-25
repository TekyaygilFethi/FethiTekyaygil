using FethiTekyaygilWebsite.Data.Attributes;
using FethiTekyaygilWebsite.Data.POCOs.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FethiTekyaygilWebsite.Data.POCOs
{
    [Table("LanguageTable")]
    public class Language : BasePOCO
    {
        public Language()
        {
            Categories = new List<LanguageLanguageCategory>();
        }

        [Required]
        public string TurkishName { get; set; }

        [Required]
        public string EnglishName { get; set; }

        [Required]
        public int PersonalTalentID { get; set; }

        [SkipProperty,ForeignKey("PersonalTalentID")]
        public virtual PersonalTalent PersonalTalent { get; set; }

        [SkipProperty]
        public virtual List<LanguageLanguageCategory> Categories { get; set; }
    }
}
