using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetResource.Models;

namespace VetResource.Controllers
{
    public class VetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
