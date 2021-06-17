using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetResource.Models;
using VetResource.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Http;

namespace VetResource.Controllers
{
    public class FeedbackController : Controller
    {
        // Variables that will allow for Feedback functionality
        private IFeedback _feedback;
        public FeedbackController (IFeedback feedback)
        {
            _feedback = feedback;
        }

        [HttpPost]
        public IActionResult Create(Feedback feedback)
        {
            Feedback newfeedback = _feedback.CreateFeedBack(feedback);
            return RedirectToAction("ThankYou", "Feedback");
        }

        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
