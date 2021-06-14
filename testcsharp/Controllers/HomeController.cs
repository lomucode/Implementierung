using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using testcsharp.Models;

namespace testcsharp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Registry()
        {
            return View();
        }

        public IActionResult UniSiegen()
        {
            return View();
        }
        public IActionResult HellenicMediterraneanUniversity()
        {
            return View();
        }
        public IActionResult ThePolytechnicInstituteofPorto()
        {
            return View();
        }
        public IActionResult UniMaribor()
        {
            return View();
        }
        public IActionResult Unicusano()
        {
            return View();
        }
        public IActionResult UniOrleans()
        {
            return View();
        }
        public IActionResult VilniusTech()
        {
            return View();
        }
        public IActionResult Athenathon()
        {
            return View();
        }
        public IActionResult FAQ()
        {
            return View();
        }
        public IActionResult Impressum()
        {
            return View();
        }
        public IActionResult Datenschutz()
        {
            return View();
        }

        public IActionResult Settings()
        {
            return View();
        }
        
        public IActionResult Profil()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Login()
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
