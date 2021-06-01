using System;
using System.Collections.Generic;

namespace VetResource.Models
{
    public partial class ResCont
    {
        public decimal ResourceId { get; set; }
        public string ResourceName { get; set; }
        public string WebsiteUrl { get; set; }
        public string ContactInfo { get; set; }
        public string Address { get; set; }
    }
}
