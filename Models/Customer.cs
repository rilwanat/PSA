namespace PSA.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string NationalIdNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CustomerNumber { get; set; }
        public string TransactionHistory { get; set; }
    }
}
