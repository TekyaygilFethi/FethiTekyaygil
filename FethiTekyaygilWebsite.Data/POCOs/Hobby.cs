using FethiTekyaygilWebsite.Data.POCOs.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FethiTekyaygilWebsite.Data.POCOs
{
    [Table("HobbyTable")]
    public class Hobby:BasePOCO
    {
        [Required]
        public string TurkishName { get; set; }

        [Required]
        public string EnglishName { get; set; }

        [Required]
        public string VideoName { get; set; }

        [Required]
        public string ImageName { get; set; }

        [Required,DataType(DataType.MultilineText)]
        public string TurkishExplanation { get; set; }

        [Required,DataType(DataType.MultilineText)]
        public string EnglishExplanation { get; set; }
    }
}
