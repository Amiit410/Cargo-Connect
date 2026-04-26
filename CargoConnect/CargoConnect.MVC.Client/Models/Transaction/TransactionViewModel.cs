namespace CargoConnect.MVC.Client.Models.Transaction
{
    public class TransactionViewModel
    {
        public Guid Id { get; set; }

        public Guid BookingId { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public DateTime Timestamp { get; set; }
    }
}