using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication1.Models
{
    public class Catalogue
    {
        [Key]//la clée primaire ici est numero_cat 
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int numero_cat {get;set;}
        public string nom {  get; set; }
    }
}
