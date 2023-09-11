using GTR_Assignment.EF.Model;
using GTR_Assignment.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GTR_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCartController : ControllerBase
    {
        private readonly IUnitofWork _unitofWork;

        public ProductCartController(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        [HttpPost("addCart")]
        public async Task<IActionResult> AddCart(ProductCart productCart)
        {

            try
            {
                await _unitofWork.ProductCarts.Add(productCart);
                await _unitofWork.CompleteAsync();
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
        [HttpGet("GetCart/{id}")]
        public async Task<IActionResult> GetCart(int id)
        {
            try
            {
                var cart = await _unitofWork.ProductCarts.GetById(id);
                if (cart == null) return NotFound();
                return Ok(cart);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
        [HttpGet("GetCartByUser/{id}")]
        public async Task<IActionResult> GetCartByUser(int id)
        {
            try
            {
                var cart = await _unitofWork.ProductCarts.GetByUserId(id);
                if (cart == null) return NotFound();
                return Ok(cart);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

    }
}
