using CsvHelper;
using SalesAnalyticsAPI.Data;
using SalesAnalyticsAPI.Model;
using System.Formats.Asn1;
using System.Globalization;

namespace SalesAnalyticsAPI.Services
{
    public class CsvImportService
    {
        private readonly SalesDbContext _context;

        public CsvImportService(SalesDbContext context)
        {
            _context = context;
        }

        public async Task ImportAsync(string filePath)
        {
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<SalesCsvRow>().ToList();

            foreach (var row in records)
            {
                if (!_context.Customers.Any(c => c.CustomerID == row.CustomerId))
                {
                    _context.Customers.Add(new Customer
                    {
                        CustomerID = row.CustomerId,
                        Name = row.CustomerName,
                        Email = row.CustomerEmail,
                        Address = row.CustomerAddress
                    });
                }

                if (!_context.Products.Any(p => p.ProductID == row.ProductId))
                {
                    _context.Products.Add(new Product
                    {
                        ProductID = row.ProductId,
                        Name = row.ProductName,
                        Category = row.Category
                    });
                }

                if (!_context.Orders.Any(o => o.OrderID == row.OrderId))
                {
                    _ = _context.Orders.Add(new Order
                    {
                        OrderID = row.OrderId,
                        ProductID = row.ProductId,
                        CustomerID = row.CustomerId,
                        Region = row.Region,
                        DateOfSale = row.DateOfSale,
                        QuantitySold = row.QuantitySold,
                        UnitPrice = row.UnitPrice,
                        Discount = row.Discount,
                        ShippingCost = row.ShippingCost,
                        PaymentMethod = row.PaymentMethod
                    });
                }
            }

            await _context.SaveChangesAsync();
        }
    }

}
