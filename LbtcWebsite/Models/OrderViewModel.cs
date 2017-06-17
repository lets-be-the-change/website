using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LbtcWebsite.Models
{
    public class OrderViewModel
    {
        public string Id { get; set; }
        public string TransactionId { get; set; }
        public string Status { get; set; }
        public string Currency { get; set; }
        public double? Amount { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public string RedirectUrl { get; set; }
        public string WebhookUrl { get; set; }
        public string CreatedAt { get; set; }
        public string ResourceUri { get; set; }
    }
}