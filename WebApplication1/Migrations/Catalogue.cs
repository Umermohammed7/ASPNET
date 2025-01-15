using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Migrations
{
    public class Catalogue
    {
        [Key]  // represente la clé primaire 
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int num { get; set; }
        public string nom {  get; set; }    

    }
}
