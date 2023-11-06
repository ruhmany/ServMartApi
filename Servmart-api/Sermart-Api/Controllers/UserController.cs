using Domain_Layer.DTOs.UserDTOs;
using ApplicationLayer.IRepos;
using Microsoft.AspNetCore.Mvc;

namespace Sermart_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _userRepo;

        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }


        [HttpPost("update")]
        public async Task<IActionResult> UpdateUser([FromForm]UserUpdateDTO userDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _userRepo.UpdateUser(userDTO);
            if (result is null)
                return BadRequest();
            return Ok(result);

        }

        
        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _userRepo.GetAllUsers());
        }

    }
}
