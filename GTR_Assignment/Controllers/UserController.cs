using GTR_Assignment.EF.Model;
using GTR_Assignment.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GTR_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitofWork _unitofWork;

        public UserController(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }
        [HttpGet]
        [Route("GetAllUser")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var users = await _unitofWork.Users.All();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
        [HttpGet]
        [Route("GetUser/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var user = await _unitofWork.Users.GetById(id);
                if (user==null) return NotFound();
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
        [HttpPost]
        [Route("AddUser")]
        public async Task<IActionResult> AddUser(User user)
        {
            try
            {
                await _unitofWork.Users.Add(user);
                await _unitofWork.CompleteAsync();
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
        [HttpPatch]
        [Route("UpdateUser")]
        public async Task<IActionResult> Update( User user)
        {
            try
            {
                var existUser= await _unitofWork.Users.GetById(user.Id);
                if (existUser == null) return NotFound();
                _unitofWork.Users.Update(user);
                await _unitofWork.CompleteAsync();
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
        [HttpDelete]
        [Route("DeleteUser/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var user = await _unitofWork.Users.GetById(id);
                if (user == null) return NotFound();
                _unitofWork.Users.Delete(user);
                await _unitofWork.CompleteAsync();
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
    }
}
