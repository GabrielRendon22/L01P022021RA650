using System.ComponentModel.DataAnnotations;
namespace PracticaMVC_RendonAlas.Models
{
    public class Materias

    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "Materia")]
        public string? materia { get; set; }
        [Display(Name = "Unidades valorativas")]
        public int unidades_valorativas { get; set; }
        [Display(Name = "Estado")]
        public string? estado { get; set; }
    }
}
