using GTR_Assignment.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GTR_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RealApiFetchController : ControllerBase
    {
        private readonly IUnitofWork _unitofWork;

        public RealApiFetchController(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        [HttpGet("GetProductListAll")]
        public async Task<IActionResult> GetProductListAll()
        {
            try
            {
                HttpClient http= new HttpClient();
                var response = await http.GetAsync("https://www.pqstec.com/InvoiceApps/values/GetProductListAll");
                var result = await response.Content.ReadAsStringAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpGet("GetProductListAllJSON")]
        public async Task<IActionResult> GetProductListAllJSON()
        {
            try
            {
                var res= await _unitofWork.Products.All();
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
    }
}
