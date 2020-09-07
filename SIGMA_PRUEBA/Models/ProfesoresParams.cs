using System;
using System.ComponentModel.DataAnnotations;
namespace SIGMA_PRUEBA.Models
{
public class ProfesoresParams
{
    // Default Id.
    public long Id { get; set; }
    public long Codigo { get; set; }
    public string Nombre { get; set; }
    public string ApellidoP { get; set; }
    public string ApellidoM { get; set; }
    public string Direccion { get; set; }
    public long Telefono { get; set; }
    public DateTime Nacimiento { get; set; }
}
}