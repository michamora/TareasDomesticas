using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<Tareas> Tareas { get; set; } = null!;
    public DbSet<Empleados> Empleados { get; set; } = null!;
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
    }
    
}