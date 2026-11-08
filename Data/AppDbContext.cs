using Actividad17.Models;
using Microsoft.EntityFrameworkCore;

namespace Actividad17.Data;

// DbContext: el "puente" entre el código C# y la base de datos SQL Server.
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // DbSet = tabla. Esta propiedad crea la tabla "Estudiantes".
    public DbSet<Estudiante> Estudiantes => Set<Estudiante>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // La matrícula no se puede repetir.
        modelBuilder.Entity<Estudiante>()
            .HasIndex(e => e.Matricula)
            .IsUnique();
    }
}
