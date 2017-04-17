using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LbtcWebsite.Models
{
    public class Event
    {
        public Guid ID { get; set; }

        [Required]
        [Display(Name ="Event Name")]
        public string EventName { get; set; }

        [Required]
        [Display(Name = "Event Description")]
        public string EventDescription { get; set; }

        [Required]
        [Display(Name = "Event Image")]
        public byte[] Image { get; set; }
    }
}