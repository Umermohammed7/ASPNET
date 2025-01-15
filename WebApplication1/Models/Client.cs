namespace WebApplication1.Models
{
    public class Client
    {
       
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        private string Adresse { get; set; }

        public string Address { get; set; }



        // constructeur 

        public Client (int id, string Nom, string Prenom)
        {
            Id = id;
            Nom = Nom;
            Prenom = Prenom;

        }

        // méthode pour afficher les infos du client 
        public string AfficherInfo()
        {
            return $"Client [ID: {Id}, Nom: {Nom}, Prénom: {Prenom}]";

        }

    }
    // Exemple d'utilisation 
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client(1, "umer", "muhamed");
            Console.WriteLine(client1.AfficherInfo());
        }
    }

}
