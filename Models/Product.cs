namespace Homework_4._4.Models
{
    public class Product
    {
        public decimal Price { get; set; } 
        public string OriginCountry { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public DateTime PackagingDate { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
