using FethiTekyaygilWebsite.Data.POCOs.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FethiTekyaygilWebsite.Data.POCOs
{
    [Table("ProjectTable")]
    public class Project : BasePOCO
    {
        [Required]
        public string TurkishName { get; set; }

        [Required]
        public string EnglishName { get; set; }

        public string Link { get; set; }

        public string Link2 { get; set; }

        [Required, DataType(DataType.MultilineText)]
        public string TurkishExplanation { get; set; }

        [Required, DataType(DataType.MultilineText)]
        public string EnglishExplanation { get; set; }

        public bool IsMobile { get; set; }

        public int Sira { get; set; }
    }
}
