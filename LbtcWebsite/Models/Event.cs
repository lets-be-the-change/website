using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LbtcWebsite.Models
{
    public class Event
    {
        public Guid ID { get; set; }

        public string EventName { get; set; }

        public string EventDescription { get; set; }

        public byte[] Image { get; set; }
    }
}