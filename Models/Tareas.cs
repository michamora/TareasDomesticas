using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Tareas
{
    [Key]
    public int tareaId { get; set; }
    public string fecha { get; set; }
    public string? descripcion { get; set; }
    public string? nombre { get; set; }
    public int empleadoId { get; set; }
    public string estado { get; set; }
    public string codigoAcceso { get; set; }

   
}

public class TareaService
{
    private readonly HttpClient _httpClient;

    public TareaService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
}
