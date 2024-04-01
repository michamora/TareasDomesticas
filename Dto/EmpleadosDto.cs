namespace TareasDomesticas.Models
{
    public class EmpleadosDto
    {
         public int empleadoId { get; set; }
         public string nombre {get; set;}
        
         public TareasDto? tareas {get; set; }
    }
    
   
}