using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VetResource.Models
{
    public partial class Feedback
    {
        public decimal FeedbackId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }

        [DataType(DataType.MultilineText)]
        public string FeedbackText { get; set; }    //Allows for multiline text
    }
}
