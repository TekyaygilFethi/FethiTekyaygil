using FethiTekyaygilWebsite.Data.POCOs.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FethiTekyaygilWebsite.Data.POCOs
{
    [Table("EducationTable")]
    public class Education : BasePOCO
    {
        [Required]
        public string TurkishDepartment { get; set; }

        [Required]
        public string EnglishDepartment { get; set; }

        [Required]
        public string TurkishSchool { get; set; }

        [Required]
        public string EnglishSchool { get; set; }
        
        public string ImageName { get; set; }
        //public byte[] Image { get; set; }

        public string ImageExt { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsPresent { get; set; }

        [Required]
        public string TurkishAddress { get; set; }

        [Required]
        public string EnglishAddress { get; set; }

        [Required, DataType(DataType.Html)]
        public string WebSite { get; set; }

        [DataType(DataType.MultilineText)]
        public string TurkishExplanation { get; set; }

        [DataType(DataType.MultilineText)]
        public string EnglishExplanation { get; set; }
    }
}
