using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SIGMA_PRUEBA.Models;
using SIGMA_PRUEBA;
using System;

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
            if( valalpr.Contains("Alumnos") ){
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
        //[HttpPost("{id, pss}"), FormatFilter]
        // [HttpPost("[action]"), FormatFilter]
        // public IActionResult login( [FromBody]LoginInput Vlogin )
        [HttpPost("{idofmod, nameofmod}"), FormatFilter]
        public IActionResult ingmodulos( string idofmod, string nameofmod )
        {
            AllParamsL lt = new AllParamsL();
            lt.valpr = 0;
            if( idofmod==null || nameofmod==null ){
                lt.valpr = 1;
                lt.Info = nameofmod;
                return View(lt);
            }
            long Iidofmod = (long)ManyProcs.str2long(idofmod);
            nameofmod = nameofmod+"-"+Iidofmod;
            ModulosParams ModP = db.Modulos.Where(s => 
                    s.Nombre == nameofmod ||
                    s.Codigo==Iidofmod
             ).FirstOrDefault();
            if( ModP!=null ){
                lt.valpr = 2;
                lt.Info = nameofmod;
                return View(lt);
            }
            ModP = new ModulosParams();
            ModP.Codigo = Iidofmod;
            ModP.Nombre = nameofmod;
            db.Modulos.Add(ModP);
            db.SaveChanges();
            lt.valpr = 0;
            lt.Info = nameofmod;
            return View(lt);
        }
        //
        //
        //
        //
        [HttpPost("[action]"), FormatFilter]
        public IActionResult ingprof( string idcodmod, string idcard, string name,
                                        string lnamep, string lnamem, 
                                        string direcc, string phone, 
                                        string dborn
                                         )
        {
            AllParamsL lt = new AllParamsL();
            if( ManyProcs.IsProfesor(idcard,db) ){
                lt.valpr = 1;
                return View(lt);
            }
            if( ManyProcs.IsProfAsig(idcard,db) ){
                lt.valpr = 2;
                return View(lt);
            }
            if( ManyProcs.IsModuAsig(idcodmod,db) ){
                lt.valpr = 3;
                return View(lt);
            }
            ProfesoresParams prfp = new ProfesoresParams();
            prfp.Codigo = ManyProcs.str2long(idcard);
            prfp.Nombre = name;
            prfp.ApellidoP = lnamep;
            prfp.ApellidoM = lnamem;
            prfp.Direccion = direcc;
            prfp.Telefono = ManyProcs.str2long(phone);
            prfp.Nacimiento = ManyProcs.str2date(dborn);
            //
            RelacionesModulosParams rlp = new RelacionesModulosParams();
            rlp.CodigoAdjunto = prfp.Codigo;
            rlp.CodigoModulo = db.Modulos.Where(s =>s.Nombre==idcodmod).FirstOrDefault().Codigo;
            rlp.AprobadoProfesor = 2;
            //
            db.Profesores.Add(prfp);
            db.RelacionesModulos.Add(rlp);
            db.SaveChanges();
            lt.valpr = 0;
            lt.Info = name + " " + lnamep + " " + lnamem + " para el modulo " + idcodmod;
            return View(lt);
        }
        //
        //
        //
        //
        [HttpPost("[action]"), FormatFilter]
        public IActionResult ingalum( string idcodmod, string idcard, string name,
                                        string lnamep, string lnamem, 
                                        string dborn
                                         )
        {
            AllParamsL lt = new AllParamsL();
            AlumnosParams alpar = new AlumnosParams();
            alpar.Codigo = ManyProcs.str2long(idcard);
            alpar.Nombre = name;
            alpar.ApellidoP = lnamep;
            alpar.ApellidoM = lnamem;
            alpar.Nacimiento = ManyProcs.str2date(dborn);
            if( ManyProcs.IsAlumno(idcard,db) ){
                lt.valpr = 1;
            }else{
                db.Alumnos.Add(alpar);
                db.SaveChanges();
                lt.valpr = 0;
            }
            if( ManyProcs.IsModuAsigAlu(idcodmod,idcard,db) ){
                lt.valpr = lt.valpr + 2;
                lt.Info = idcodmod;
                return View(lt);
            }
            //
            RelacionesModulosParams rlp = new RelacionesModulosParams();
            rlp.CodigoAdjunto = alpar.Codigo;
            rlp.CodigoModulo = db.Modulos.Where(s =>s.Nombre==idcodmod).FirstOrDefault().Codigo;
            rlp.AprobadoProfesor = 0;
            //
            db.RelacionesModulos.Add(rlp);
            db.SaveChanges();
            lt.valpr = 0;
            lt.Info = name + " " + lnamep + " " + lnamem + " para el modulo " + idcodmod;
            return View(lt);
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
