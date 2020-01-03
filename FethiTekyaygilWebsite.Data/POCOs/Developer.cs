using FethiTekyaygilWebsite.Data.POCOs.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FethiTekyaygilWebsite.Data.POCOs
{
    [Table("DeveloperTable")]
    public class Developer : BasePOCO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string ImageName { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.DateTime)]
        public DateTime Birthday { get; set; }

        [Required]
        public string EnglishTitle { get; set; }

        [Required]
        public string TurkishTitle { get; set; }

        [Required]
        public string TurkishNativeLanguage { get; set; }

        [Required]
        public string EnglishNativeLanguage { get; set; }

        [Required]
        public string TurkishAboutMe { get; set; }

        [Required]
        public string EnglishAboutMe { get; set; }

    }
}
