using FethiTekyaygilWebsite.Data.Attributes;
using FethiTekyaygilWebsite.Data.POCOs.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FethiTekyaygilWebsite.Data.POCOs
{
    [Table("PersonalTalentTable")]
    public class PersonalTalent:BasePOCO
    {
        public PersonalTalent()
        {
            WorkTalents = new List<WorkTalent>();
            Languages = new List<Language>();
            CommunicationTalents = new List<CommunicationTalent>();
        }


        [SkipProperty]
        public virtual List<Language> Languages { get; set; }

        [SkipProperty]
        public virtual List<CommunicationTalent> CommunicationTalents { get; set; }

        //[Required,DataType(DataType.MultilineText)]
        //public string TurkishCommunicationTalents { get; set; }

        //[Required, DataType(DataType.MultilineText)]
        //public string EnglishCommunicationTalents { get; set; }

        [SkipProperty]
        public virtual List<WorkTalent> WorkTalents { get; set; }
    }
}
