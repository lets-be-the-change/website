using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LbtcWebsite.Models
{
    public class ContactUsViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1000000000,9999999999)]
        public long PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Message { get; set; }

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}