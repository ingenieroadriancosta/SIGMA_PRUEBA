using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SIGMA_PRUEBA.Models;

namespace SIGMA_PRUEBA.Controllers
{
    public class apartado{
                public int apar{get;set;}
            }

    [Microsoft.AspNetCore.Mvc.Route("/")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //
        //
        //
        //
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //
        //
        //
        //
        public IActionResult Index()
        {
            return View();
        }
        //
        //
        //
        //
        [HttpGet("[action]")]
        public IActionResult relmodulos()
        {
            apartado apa = new apartado();
            apa.apar = 10;
            return View( apa );
        }
        //
        //
        //
        //
        [HttpGet("[action]")]
        public IActionResult Privacy()
        {
            return View();
        }


        [HttpGet("[action]")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
