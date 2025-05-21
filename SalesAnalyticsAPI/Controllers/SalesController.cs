using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesAnalyticsAPI.DTO;
using SalesAnalyticsAPI.Services;

namespace SalesAnalyticsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly SalesAnalysisService _service;

        public SalesController(SalesAnalysisService service) => _service = service;

        [HttpPost("revenue")]
        public async Task<IActionResult> GetRevenue([FromBody] RevenueRequestDto dto)
        {
            var result = await _service.CalculateRevenueAsync(dto.StartDate, dto.EndDate);
            return Ok(result);
        }
    }
}
