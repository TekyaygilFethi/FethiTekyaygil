using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FethiTekyaygilWebsite.Data.Models.ResponseModels.HobbyModels
{
    public class HobbyResponseModel
    {
        [Required]
        public string Name { get; set; }

        public string VideoName { get; set; }

        public string ImageName { get; set; }

        public string Explanation { get; set; }
    }
}
