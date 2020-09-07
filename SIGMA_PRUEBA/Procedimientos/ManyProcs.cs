using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using SIGMA_PRUEBA.Models;

namespace SIGMA_PRUEBA
{
    public class ManyProcs
    {
        //
        public static long str2long( string str ){
            try{
                return long.Parse(str);
            }catch( FormatException  ex ){
                Console.WriteLine( "------------------------------------------" );
                Console.WriteLine( "Error FUNCTION (ManyProcs.str2long):" + ex );
                Console.WriteLine( "------------------------------------------" );
                return -1;
            }
        }//
        public static DateTime str2date( string str ){
            try{
                return DateTime.Parse(str);
            }catch( FormatException  ex ){
                Console.WriteLine( "------------------------------------------" );
                Console.WriteLine( "Error FUNCTION (ManyProcs.str2date):" + ex );
                Console.WriteLine( "------------------------------------------" );
                return DateTime.Now;
            }
        }
        //
        //
        //
        //
        public static bool IsAlumno( string idcard, DbContextSIGMA db ){
            long id = str2long(idcard);
            return db.Alumnos.Where( s=> s.Codigo==id ).FirstOrDefault()!=null;
        }
        //
        //
        //
        //
        public static bool IsModuAsigAlu( string idcodmod, string idal, DbContextSIGMA db ){
            ModulosParams mdp = db.Modulos.Where( s => s.Nombre==idcodmod ).FirstOrDefault();
            if( mdp==null ){
                return false;
            }
            long id = str2long(idal);
            return db.RelacionesModulos.Where( s=> 
                        s.CodigoModulo==mdp.Codigo &&
                        s.CodigoAdjunto==id
                    ).FirstOrDefault()!=null;
        }
        //
        //
        //
        //
        public static bool IsProfesor( string idcard, DbContextSIGMA db ){
            long id = str2long(idcard);
            return db.Profesores.Where( s=> s.Codigo==id ).FirstOrDefault()!=null;
        }
        //
        //
        //
        //
        public static bool IsProfAsig( string idcard, DbContextSIGMA db ){
            long id = str2long(idcard);
            return db.RelacionesModulos.Where( s=> s.CodigoAdjunto==id ).FirstOrDefault()!=null;
        }
        //
        //
        //
        //
        public static bool IsModuAsig( string idcodmod, DbContextSIGMA db ){
            ModulosParams mdp = db.Modulos.Where( s => s.Nombre==idcodmod ).FirstOrDefault();
            if( mdp==null ){
                return false;
            }
            return db.RelacionesModulos.Where( s=> s.CodigoModulo==mdp.Codigo ).FirstOrDefault()!=null;
        }
        //
        //
    }
}