using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Produit
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        [Display(Name = "Designation")]
        public string Name { get; set; }

        [Display(Name = "Prix")]
        [Required(ErrorMessage = "merci de donner un prix")]
        public double Price { get; set; }

    }
}
