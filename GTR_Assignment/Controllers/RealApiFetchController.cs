using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GTR_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RealApiFetchController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RealApiFetchController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet("GetProductListAll")]
        public async Task<IActionResult> GetProductListAll()
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient();

                var apiUrl = "https://www.pqstec.com/InvoiceApps/values/GetProductListAll";

                var response = await httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    return Ok(content);
                }
                else
                {
                    // If the request is not successful, return an error response
                    return StatusCode((int)response.StatusCode, "External API request failed");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions and return an error response
                return BadRequest($"Error: {ex.Message}");
            }
        }
    }
}
