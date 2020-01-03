using FethiTekyaygilWebsite.Data.POCOs.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FethiTekyaygilWebsite.Data.POCOs
{
    [Table("ContactTable")]
    public class Contact:BasePOCO
    {
        [Required]
        public string Name { get; set; }

        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required,DataType(DataType.MultilineText)]
        public string Message { get; set; }

        [Required]
        public DateTime SendDate { get; set; } = DateTime.Now;
    }
}
