namespace Homework_4._4.Models
{
    public class Book : Product
    {
        public int NumberOfPages { get; set; }
        public string Publisher { get; set; } = string.Empty;
        public List<string> Authors { get; set; } = new List<string>();
    }
}
