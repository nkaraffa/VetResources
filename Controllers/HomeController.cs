using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VetResource.Models;
using VetResource.Services;

namespace VetResource.Controllers
{
    public class HomeController : Controller
    {
        // Variables to access & pass DB data
        private IVetRepository _vetRepository;
        private IVso _vso;
        public HomeController(IVetRepository vetRepository, IVso vso)
        {
            _vetRepository = vetRepository;
            _vso = vso;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "A resource to help you during - or after - your military transition.";
            return View();
        }

        public IActionResult AboutImg()
        {
            return File($@"\images\Military.jpg", "image/jpeg");
        }

        public IActionResult Resources()
        {
            ViewData["Title"] = "Veteran Resources";
            ViewData["Message"] = "Information on various veterans resource groups.";

            var model = _vetRepository.GetAllResources();       //Variable to pass DB data
            return View(model);
        }

        public IActionResult VSOs()
        {
            ViewData["Title"] = "Veteran Service Organizations";
            ViewData["Message"] = "Information on various veterans organizations.";

            var model = _vso.GetVsoconts();
            return View(model);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Feel free to contact us.";

            return View();
        }

        //Thank you to Deepali
        public IActionResult TYD()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
