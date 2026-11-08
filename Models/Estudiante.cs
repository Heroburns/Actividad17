using System.ComponentModel.DataAnnotations;

namespace Actividad17.Models;

// Modelo (entidad) Estudiante: cada propiedad será una columna de la tabla "Estudiantes".
public class Estudiante
{
    // Llave primaria. EF Core la detecta por el nombre "Id" y la hace autoincremental.
    public int Id { get; set; }

    [Required(ErrorMessage = "La matrícula es obligatoria.")]
    [StringLength(20)]
    public string Matricula { get; set; } = string.Empty;

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(60)]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "Los apellidos son obligatorios.")]
    [StringLength(80)]
    public string Apellidos { get; set; } = string.Empty;

    [Required(ErrorMessage = "El correo es obligatorio.")]
    [EmailAddress(ErrorMessage = "Correo no válido.")]
    [StringLength(100)]
    public string Correo { get; set; } = string.Empty;

    [Required(ErrorMessage = "La carrera es obligatoria.")]
    [StringLength(100)]
    public string Carrera { get; set; } = string.Empty;

    [Range(1, 12, ErrorMessage = "El semestre debe estar entre 1 y 12.")]
    public int Semestre { get; set; } = 1;
}
