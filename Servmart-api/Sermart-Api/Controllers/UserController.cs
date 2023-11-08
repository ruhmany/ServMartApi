using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.UserDTOs;
using Microsoft.AspNetCore.Mvc;

namespace Sermart_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _userRepo;
        private readonly IUnitOfWork _unitOfWork;

        public UserController(IUserRepo userRepo, IUnitOfWork unitOfWork)
        {
            _userRepo = userRepo;
            _unitOfWork = unitOfWork;
        }


        [HttpPost("update")]
        public async Task<IActionResult> UpdateUser([FromForm]UserUpdateDTO userDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _userRepo.UpdateUser(userDTO);
            _unitOfWork.CommitChanges();
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
