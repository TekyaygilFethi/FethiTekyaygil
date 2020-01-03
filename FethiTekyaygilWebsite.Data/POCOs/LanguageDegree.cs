using FethiTekyaygilWebsite.Data.Attributes;
using FethiTekyaygilWebsite.Data.POCOs.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FethiTekyaygilWebsite.Data.POCOs
{
    [Table("LanguageDegreeTable")]
    public class LanguageDegree:BasePOCO
    {
        public LanguageDegree()
        {
            Categories = new List<LanguageCategory>();
        }
        [Required,MaxLength(2)]
        public string Degree { get; set; }

        [SkipProperty]
        public virtual List<LanguageCategory> Categories { get; set; }
    }
}
