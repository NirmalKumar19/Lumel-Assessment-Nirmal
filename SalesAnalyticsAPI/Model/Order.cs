namespace SalesAnalyticsAPI.Model
{
    public class Order
    {
        public string OrderID { get; set; }
        public string ProductID { get; set; }
        public string CustomerID { get; set; }

        public string Region { get; set; }
        public DateTime DateOfSale { get; set; }
        public int QuantitySold { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal ShippingCost { get; set; }
        public string PaymentMethod { get; set; }

        public Product Product { get; set; }
        public Customer Customer { get; set; }

    }
}
