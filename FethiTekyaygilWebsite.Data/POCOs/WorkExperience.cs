using FethiTekyaygilWebsite.Data.POCOs.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FethiTekyaygilWebsite.Data.POCOs
{
    [Table("WorkExperienceTable")]
    public class WorkExperience : BasePOCO
    {
        [Required]
        public string TurkishPosition { get; set; }

        [Required]
        public string EnglishPosition { get; set; }

        [Required]
        public string Company { get; set; }

        public string ImageName { get; set; }

        //public byte[] Image { get; set; }

        public string ImageExt { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsPresent { get; set; }

        [DataType(DataType.MultilineText)]
        public string TurkishExplanation { get; set; }

        [DataType(DataType.MultilineText)]
        public string EnglishExplanation { get; set; }

        [Required]
        public string WebSite { get; set; }

        public string TurkishAddress { get; set; }

        public string EnglishAddress { get; set; }
    }
}
