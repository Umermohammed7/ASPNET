namespace WebApplication1.Models
{

    using System.ComponentModel.DataAnnotations;

    namespace WebApplication1.Models
    {
        public class Produit
        {

            public int Id { get; set; }

            [Display(Name = "Designation")]
            [Required(ErrorMessage = "Merci de saisir le nom")]
            [MinLength(2, ErrorMessage = "Au moins deux caractères")]
            public string Name { get; set; }
            //[DataType(DataType.Password)]
            [Display(Name = "Prix")]
            [Required(ErrorMessage = "Merci de saisir le prix")]
            public double Email { get; set; }
            [Display(Name = "Addresse email")]
            [Required(ErrorMessage = "Merci de saisir le mail")]
        }
    }
    //public class Custommer
    //{

    //    public int Id { get; set; }

    //    public string Nom { get; set; }

    //    public string Prenom { get; set; }

    //    public string email { get; set; }

    //    // constructeur 


    //    public Custommer () { }

    //    // méthode pour afficher les infos du client 
    //    public string AfficherInfo()
    //    {
    //        return $"Client [ID: {Id}, Nom: {Nom}, Prénom: {Prenom}]";

    //    }

    //}
    // Exemple d'utilisation 
    //                  class Program
    //  //              {
    //                  static void Main(string[] args)
    //              {
    //                Client client1 = new Client(1, "umer", "muhamed");
    //              Console.WriteLine(client1.AfficherInfo());
    //        }
    //  }

}