using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.UserDTOs;
using Domain_Layer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
        public async Task<IActionResult> UpdateUser([FromForm] UserUpdateDTO userDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _userRepo.UpdateUser(userDTO);
            _unitOfWork.CommitChanges();
            if (result is null)
                return BadRequest();
            return Ok(new { result.LName, result.FName, result.Address, result.Gender, result.ProfilePic, result.UserName });

        }
        [HttpPost("UpdatePassword")]
        public async Task<IActionResult> UpdatePassword([FromForm] ChangePasswordDTO changePasswordDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _userRepo.ChangePassword(changePasswordDTO);
            _unitOfWork.CommitChanges();
            if (result is null) return BadRequest();
            return Ok(result);
        }
        [HttpPost("UpDateRole")]
        public async Task<IActionResult> UPDateRole([FromBody]UserRoleDTO userRoleDTO)
        
        {
            if (!ModelState.IsValid)
            { return BadRequest(ModelState); }
            userRoleDTO.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var Result = await _userRepo.ChangRole(userRoleDTO);
            _unitOfWork.CommitChanges();
            if (Result is null) return BadRequest(); return Ok(Result);
        }
        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _userRepo.GetAllUsers());
        }
        [HttpPost("UpdateEmail")]
        public async Task<ActionResult<User>> ChangeEmail(ChangeEmailDTO changeEmailDTO)
        {
             if (!ModelState.IsValid)
            { return BadRequest(ModelState); }
            changeEmailDTO.Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var updatedUser = await _userRepo.ChageEmail(changeEmailDTO);
            _unitOfWork.CommitChanges();

            return Ok(updatedUser);
        
        
        }
    }
}
