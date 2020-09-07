using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
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
        }
    }
}