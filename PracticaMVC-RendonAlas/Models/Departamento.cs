using System.ComponentModel.DataAnnotations;
namespace PracticaMVC_RendonAlas.Models
{
    public class Departamento
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "departamento")]
        public string? departamento { get; set; }

    }
}
