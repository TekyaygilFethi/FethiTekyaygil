using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FethiTekyaygilWebsite.Data.Models.ResponseModels.TimelineModels
{
    public class TimelineResponseModel
    {
        [Required]
        public string Position { get; set; }

        [Required]
        public string Institution { get; set; }


        //public byte[] ImageBlob { get; set; }

        public string ImageName { get; set; }

        //public string ImageExt { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsPresent { get; set; }

        public string Address { get; set; }

        [DataType(DataType.MultilineText)]
        public string Explanation { get; set; }

        [Required, DataType(DataType.Html)]
        public string WebSite { get; set; }

        public bool IsEducation { get; set; }
    }
}
