using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SIGMA_PRUEBA.Models;

namespace SIGMA_PRUEBA.Controllers
{
    public class apartado{
        public int apar{get;set;}
        public string Sapar{get;set;}
    }

    [Microsoft.AspNetCore.Mvc.Route("/")]
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;
        // public HomeController(ILogger<HomeController> logger){_logger = logger;}
        //
        //
        //
        //
        private Models.DbContextSIGMA db;
        public HomeController(Models.DbContextSIGMA context) {
            this.db = context;
        }
        //
        //
        //
        //
        public IActionResult Index()
        {
            //  s => s.Id_card == (long)IdCard ).FirstOrDefault();
            if( db.Modulos.Where(s => s.Codigo == 12354 ).FirstOrDefault()==null ){
                ModulosParams modp = new ModulosParams();
                modp.Codigo = 12354;
                modp.Nombre = "Calculo-"+modp.Codigo;
                db.Add(modp);
                db.SaveChanges();
            }
            AllParamsL lt = new AllParamsL();
            lt.Lmod = db.Modulos.ToList();
            return View( lt );
        }
        //
        //
        //
        //
        [HttpGet("[action]")]
        public IActionResult relmodulos()
        {
            AllParamsL lt = new AllParamsL();
            lt.Lmod = db.Modulos.ToList();
            return View( lt );
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
