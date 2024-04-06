using System.ComponentModel.DataAnnotations;
namespace PracticaMVC_RendonAlas.Models
{
    public class Facultades
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "Facultad")]
        public string? facultad { get; set; }

    }
}
