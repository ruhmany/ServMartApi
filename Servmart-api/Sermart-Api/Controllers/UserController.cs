using Domain_Layer.DTOs;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Model state is not valid");
            }
            var result = await _userRepo.RegisterAsync(model);
            if (!result.IsAuthenticated)
                return BadRequest("error while registering"+result.Message);
            return Ok(new { Token = result.Token, ExpiresOn = result.ExpiresOn, Role = result.Role });
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _userRepo.LoginAsync(model);
            if (!result.IsAuthenticated)
                return BadRequest(result.Message);
            return Ok(new { Token = result.Token, ExpiresOn = result.ExpiresOn, Role = result.Role });
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

    }
}
