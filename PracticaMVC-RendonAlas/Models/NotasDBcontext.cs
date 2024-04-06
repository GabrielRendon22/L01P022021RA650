using Microsoft.EntityFrameworkCore;
using PracticaMVC_RendonAlas.Models;
namespace PracticaMVC_RendonAlas.Models
{
    public class NotasDBcontext:DbContext
    {
        public NotasDBcontext(DbContextOptions options): base(options) 
        {
        }
        public DbSet<Alumnos> alumnos { get; set; }
        public DbSet<Departamento> departamentos { get; set; }
        public DbSet<Facultades> facultades { get; set; }
        public DbSet<PracticaMVC_RendonAlas.Models.Materias> Materias { get; set; } = default!;
        
    }
}
