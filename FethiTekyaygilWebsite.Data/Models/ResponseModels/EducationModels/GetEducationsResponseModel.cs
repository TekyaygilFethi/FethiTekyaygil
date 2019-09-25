using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FethiTekyaygilWebsite.Data.Models.ResponseModels.EducationModels
{
    public class GetEducationsResponseModel
    {
        [Required]
        public string Department { get; set; }

        [Required]
        public string School { get; set; }
               
        [Required]
        public string Address { get; set; }
        
        [DataType(DataType.MultilineText)]
        public string Explanation { get; set; }

        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        [Required, DataType(DataType.Html)]
        public string WebSite { get; set; }
    }
}
