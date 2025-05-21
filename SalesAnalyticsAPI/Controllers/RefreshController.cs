using Microsoft.AspNetCore.Mvc;
using SalesAnalyticsAPI.Services;

namespace SalesAnalyticsAPI.Controllers
{
    public class RefreshController : ControllerBase
    {
        private readonly CsvImportService _importService;

        public RefreshController(CsvImportService importService) => _importService = importService;

        [HttpPost]
        public async Task<IActionResult> Refresh()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "sales.csv");
            await _importService.ImportAsync(filePath);
            return Ok(new { message = "Data refreshed successfully" });
        }
    }
}
