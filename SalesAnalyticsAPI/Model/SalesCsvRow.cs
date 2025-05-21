using CsvHelper.Configuration.Attributes;

namespace SalesAnalyticsAPI.Model
{
    public class SalesCsvRow
    {
        [Name("Order ID")]
        public string OrderId { get; set; }

        [Name("Product ID")]
        public string ProductId { get; set; }

        [Name("Customer ID")]
        public string CustomerId { get; set; }

        [Name("Product Name")]
        public string ProductName { get; set; }

        [Name("Category")]
        public string Category { get; set; }

        [Name("Region")]
        public string Region { get; set; }

        [Name("Date of Sale")]
        public DateTime DateOfSale { get; set; }

        [Name("Quantity Sold")]
        public int QuantitySold { get; set; }

        [Name("Unit Price")]
        public decimal UnitPrice { get; set; }

        [Name("Discount")]
        public decimal Discount { get; set; }

        [Name("Shipping Cost")]
        public decimal ShippingCost { get; set; }

        [Name("Payment Method")]
        public string PaymentMethod { get; set; }

        [Name("Customer Name")]
        public string CustomerName { get; set; }

        [Name("Customer Email")]
        public string CustomerEmail { get; set; }

        [Name("Customer Address")]
        public string CustomerAddress { get; set; }
    }
}
