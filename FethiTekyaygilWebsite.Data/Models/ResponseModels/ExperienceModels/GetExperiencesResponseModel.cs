using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FethiTekyaygilWebsite.Data.Models.ResponseModels.ExperienceModels
{
    public class GetExperiencesResponseModel
    {
        [Required]
        public string Position { get; set; }
        
        [Required]
        public string Institution { get; set; }

        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsPresent { get; set; }

        public string Address { get; set; }

        [DataType(DataType.MultilineText)]
        public string Explanation { get; set; }

        [Required, DataType(DataType.Html)]
        public string WebSite { get; set; }
    }
}
