using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Empleados
{
    [Key]
    public int empleadoId { get; set; }
    public string? nombre { get; set; }
   
}