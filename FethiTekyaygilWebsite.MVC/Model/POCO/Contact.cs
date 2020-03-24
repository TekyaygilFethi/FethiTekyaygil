using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FethiTekyaygilWebsite.MVC.Model.POCO
{
    public class Contact
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.MultilineText)]
        public string Message { get; set; }

        [Required]
        public DateTime SendDate { get; set; } = DateTime.Now;
    }
}
