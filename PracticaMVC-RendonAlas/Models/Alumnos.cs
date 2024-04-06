using System.ComponentModel.DataAnnotations;
namespace PracticaMVC_RendonAlas.Models
{
    public class Alumnos
    {
        [Key]
        [Display(Name ="ID")]
        public int id { get; set; }
        [Display(Name = "Código")]
        public string? codigo { get; set; }
        [Display(Name = "Nombre del Alumno")]
        public string? nombre { get; set; }
        [Display(Name = "Apellido del Alumno")]
        public string? apellidos { get; set; }
        [Display(Name = "Dui del Alumno")]
        public int dui { get; set; }
        [Display(Name = "Estado")]
        public int estado { get; set; } 


    }
}
