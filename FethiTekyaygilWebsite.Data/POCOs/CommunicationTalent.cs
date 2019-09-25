using FethiTekyaygilWebsite.Data.POCOs.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FethiTekyaygilWebsite.Data.POCOs
{
    public class CommunicationTalent:BasePOCO
    {
        [Required]
        public string TurkishCommunicationTalent { get; set; }
        [Required]
        public string EnglishCommunicationTalent { get; set; }
        [Required]
        public string ImagePath { get; set; }
        public int PersonalTalentID { get; set; }
        [ForeignKey("PersonalTalentID")]
        public virtual PersonalTalent PersonalTalent { get; set; }
    }
}
