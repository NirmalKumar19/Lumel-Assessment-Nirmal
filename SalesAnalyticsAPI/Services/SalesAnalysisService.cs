using Microsoft.EntityFrameworkCore;
using SalesAnalyticsAPI.Data;
using SalesAnalyticsAPI.DTO;

namespace SalesAnalyticsAPI.Services
{
    public class SalesAnalysisService
    {
        private readonly SalesDbContext _context;

        public SalesAnalysisService(SalesDbContext context) => _context = context;

        public async Task<RevenueResponseDto> CalculateRevenueAsync(DateTime start, DateTime end)
        {
            var revenue = await _context.Orders
                .Where(o => o.DateOfSale >= start && o.DateOfSale <= end)
                .SumAsync(o => o.QuantitySold * o.UnitPrice * (1 - o.Discount));

            return new RevenueResponseDto { TotalRevenue = revenue };
        }
    }

}
