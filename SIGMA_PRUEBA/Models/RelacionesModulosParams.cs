using System;
using System.ComponentModel.DataAnnotations;
namespace SIGMA_PRUEBA.Models
{
public class RelacionesModulosParams
{
    // Default Id.
    public int Id { get; set; }
    public int CodigoModulo { get; set; }
    public int CodigoAdjunto { get; set; }
    //
    //
    //
    /* 
        0 Matriculado no aprobado,
        1 Aprobado,
        2 Profesor.
    */
    public int AprobadoProfesor { get; set; }
    //
    //
    //
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public RelacionesModulosParams()
    {          
        this.CreatedDate  = DateTime.UtcNow;
        this.ModifiedDate = DateTime.UtcNow;
    }
}
}