using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Models
{
    public class Produit
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength =3)]

        public string Name { get; set; }

        [Required]
        //   [StringLength (100, MinimumLength = 3)]
        public double Price  { get; set; }

        [Required]
        public int Qte { get; set; }


        //public string Description { get; set; }


    }
}
