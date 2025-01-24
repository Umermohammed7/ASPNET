using System.ComponentModel.DataAnnotations;


namespace WebApplication1.Models
{
    public class Client
    {

        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        [Display(Name = "Nom")]
        public string Name { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        [Display(Name = "Prénom")]
        public string Prenom { get; set; }
    }
}
