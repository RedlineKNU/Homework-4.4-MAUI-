namespace Homework_4._4.Models
{
    public class Food : Product
    {
        public DateTime ExpirationDate { get; set; }
        public int Quantity { get; set; }
        public string UnitOfMeasure { get; set; } = string.Empty;
    }
}
