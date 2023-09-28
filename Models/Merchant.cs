namespace PSA.Models
{
    public class Merchant
    {
        public int Id { get; set; }
        public string BusinessIdNumber { get; set; }
        public string BusinessName { get; set; }
        public string ContactName { get; set; }
        public string ContactSurname { get; set; }
        public DateTime DateOfEstablishment { get; set; }
        public string MerchantNumber { get; set; }
        public decimal? AverageTransactionVolume { get; set; }
    }
}
