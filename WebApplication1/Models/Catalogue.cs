using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Catalogue
    {

        [Key] // genere la clef primaire dans la base 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // si l'option [key] ne fonctionne pas et que identity ne s'affiche pas 

        public int Pages { get; set; }
    }
}
