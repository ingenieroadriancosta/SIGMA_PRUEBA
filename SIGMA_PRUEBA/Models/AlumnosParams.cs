using System;
using System.ComponentModel.DataAnnotations;
namespace SIGMA_PRUEBA.Models
{
public class AlumnosParams
{
    // Default Id.
    public int Id { get; set; }
    public int Codigo { get; set; }
    public string Nombre { get; set; }
    public string ApellidoP { get; set; }
    public string ApellidoM { get; set; }
    public DateTime Nacimiento { get; set; }
}
}