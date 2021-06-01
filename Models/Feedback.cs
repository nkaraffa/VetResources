using System;
using System.Collections.Generic;

namespace VetResource.Models
{
    public partial class Feedback
    {
        public decimal FeedbackId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string FeedbackText { get; set; }
    }
}
