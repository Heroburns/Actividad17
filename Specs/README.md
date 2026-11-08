# Actividad 17 — Entity Framework Core + SQL Server

**Alumno:** David Alejandro Reyes Andrade · **Grupo:** 3C
**Carrera:** Ingeniería de Tecnologías de Internet — Universidad de Colima

## Objetivo
Configurar Entity Framework Core (EF Core) en una aplicación Blazor para guardar
los datos de los estudiantes en SQL Server y administrar operaciones CRUD.

## Qué se implementó

| Requisito | Dónde está |
|---|---|
| Paquetes NuGet de EF Core y SQL Server | `Actividad17.csproj` |
| Modelo `Estudiante` | `Models/Estudiante.cs` |
| `DbContext` | `Data/AppDbContext.cs` |
| Cadena de conexión | `appsettings.json` → `ConnectionStrings:DefaultConnection` |
| Registro del contexto en servicios | `Program.cs` → `AddDbContextFactory<AppDbContext>` |
| Migraciones | carpeta `Migrations/` |
| CRUD en Blazor | `Components/Pages/Estudiantes.razor` (`/estudiantes`) |

## Paquetes NuGet
- `Microsoft.EntityFrameworkCore.SqlServer` — EF Core + proveedor de SQL Server
- `Microsoft.EntityFrameworkCore.Design` — necesario para crear migraciones
- `Microsoft.EntityFrameworkCore.Tools` — comandos de migraciones

## Cómo ejecutar
1. Iniciar SQL Server (Docker): `docker compose up -d`
2. Instalar herramienta de EF (una sola vez): `dotnet tool install --global dotnet-ef --version "10.*"`
3. Aplicar migraciones (crea la base de datos `Actividad17Db` y la tabla `Estudiantes`):
   `dotnet ef database update`
4. Ejecutar: `dotnet run` y abrir `/estudiantes`

## Operaciones CRUD
| Operación | Método en `Estudiantes.razor` | EF Core |
|---|---|---|
| Crear | `Guardar()` (Id = 0) | `Add` + `SaveChangesAsync` |
| Leer | `CargarEstudiantes()` | `ToListAsync` |
| Actualizar | `Guardar()` (Id ≠ 0) | `Update` + `SaveChangesAsync` |
| Eliminar | `Eliminar(id)` | `FindAsync` + `Remove` + `SaveChangesAsync` |
