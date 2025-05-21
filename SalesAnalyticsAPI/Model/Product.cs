namespace SalesAnalyticsAPI.Model
{
    public class Product
    {
        public string ProductID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
