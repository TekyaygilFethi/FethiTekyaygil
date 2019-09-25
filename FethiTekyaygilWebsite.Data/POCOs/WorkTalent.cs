using FethiTekyaygilWebsite.Data.Attributes;
using FethiTekyaygilWebsite.Data.POCOs.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FethiTekyaygilWebsite.Data.POCOs
{
    [Table("WorkTalentTable")]
    public class WorkTalent:BasePOCO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public double Rate { get; set; }

        [Required]
        public int PeronalTalentID { get; set; }

        [SkipProperty,ForeignKey("PersonalTalentID")]
        public virtual PersonalTalent PersonalTalent { get; set; }

        public int CategoryNumber { get; set; }
    }
}
