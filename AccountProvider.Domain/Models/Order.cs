namespace AccountProvider.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ProductName { get; set; }
        public string Status { get; set; }
    }
}
