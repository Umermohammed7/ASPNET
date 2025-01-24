namespace WebApplication1.Models
{
    public class Paiement
    {
        public int id { get; set; }
        public DateTime date;
        public double Montant_total { get; set; }
        public string detail { get; set; }

        public Paiement()
        {

        }
    }
}
