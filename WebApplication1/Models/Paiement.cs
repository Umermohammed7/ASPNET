namespace WebApplication1.Models
{
    public class Paiement
    {
        private int id { get; }
        private DateTime date;
        private double Montant_total { get; set; }
        private string detail { get; set; }

        public Paiement()
        {

        }
    }
}
