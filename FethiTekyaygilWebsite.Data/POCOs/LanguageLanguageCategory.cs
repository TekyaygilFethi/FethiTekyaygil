using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FethiTekyaygilWebsite.Data.POCOs
{
    [Table("LanguageLanguageCategoryTable")]
    public class LanguageLanguageCategory
    {
        [Key,ForeignKey("LanguageID")]
        public virtual Language Language { get; set; }

        [Key,ForeignKey("LanguageCategoryID")]
        public virtual LanguageCategory LanguageCategory { get; set; }

        public int LanguageID { get; set; }

        public int LanguageCategoryID { get; set; }
    }
}
