using System.Collections.Generic;
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
            if( db.Modulos.Where(s => s.Codigo == 12354 ).FirstOrDefault()==null ){
                ModulosParams modp = new ModulosParams();
                modp.Codigo = 12354;
                modp.Nombre = "Calculo-"+modp.Codigo;
                db.Add(modp);
                //
                AlumnosParams alup = new AlumnosParams();
                alup.Codigo = 1;
                alup.Nombre = "Adrian";
                alup.ApellidoP = "Costa";
                alup.ApellidoM = "Ospino";
                alup.Nacimiento = System.DateTime.Now;
                db.Add(alup);
                //
                RelacionesModulosParams relp = new RelacionesModulosParams();
                relp.CodigoModulo = 12354;
                relp.CodigoAdjunto = 1;
                relp.AprobadoProfesor = 0;
                db.Add(relp);
                //
                //
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
            lt.Lmod = null;
            string modname = Request.Query["id"];
            string valalpr = Request.Query["valalpr"]+"";
            ModulosParams ModP = db.Modulos.Where(s => s.Nombre == modname ).FirstOrDefault();
            if( ModP==null ){
                lt.Info = "Error en ModPNULL";
                return View( lt );
            }
            if( valalpr.Contains("0") ){
                lt.Lrela = db.RelacionesModulos.Where(s => s.CodigoModulo == ModP.Codigo && s.CodigoAdjunto<2 ).ToList();
            }else{
                lt.valpr = 2;
                lt.Lrela = db.RelacionesModulos.Where(s => s.CodigoModulo == ModP.Codigo && s.AprobadoProfesor==2 ).ToList();
            }
            if( lt.Lrela==null ){
                lt.Info = "Error en lt.Lrela";
                return View( lt );
            }
            //
            if( lt.valpr==2 ){
                ProfesoresParams ALP = null;
                lt.Lprof = new List<ProfesoresParams>();
                foreach( var values in lt.Lrela ){
                    ALP = db.Profesores.Where( s => s.Codigo==values.CodigoAdjunto ).FirstOrDefault();
                    if( ALP!=null ){
                        lt.Lprof.Add(ALP);
                    }
                }
            }else{
                AlumnosParams ALP = null;
                lt.Lalum = new List<AlumnosParams>();
                foreach( var values in lt.Lrela ){
                    ALP = db.Alumnos.Where( s => s.Codigo==values.CodigoAdjunto ).FirstOrDefault();
                    if( ALP!=null ){
                        lt.Lalum.Add(ALP);
                    }
                }
            }
            lt.Info = modname;
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
