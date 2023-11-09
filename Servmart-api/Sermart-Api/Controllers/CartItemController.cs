using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.CartItemDTOs;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Sermart_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CartItemController : ControllerBase
    {
        private readonly IcartItemRepo _repo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _manager;

        public CartItemController(IUnitOfWork unitOfWork, IcartItemRepo repo, UserManager<User> manager)
        {
            _unitOfWork = unitOfWork;
            _repo = repo;
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _repo.GetAllItems();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddItem(string productid)
        {
            var userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _manager.FindByIdAsync(userID);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _repo.Add(productid, userID);
            if(result == null)
                return BadRequest(result);
            user.Cart.Items.Add(result);
            _unitOfWork.CommitChanges();
            return Ok(result);
        }

        [HttpPatch]
        public async Task<IActionResult> Update(CartItemUpdateDTO cartItemUpdateDTO)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = _repo.Update(cartItemUpdateDTO);
            if(result == null)
                return BadRequest(result);
            _unitOfWork.CommitChanges();
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = _repo.Delete(id);
            if(result == null)
                return BadRequest(result);
            _unitOfWork.CommitChanges();
            return Ok(result);
        }
    }
}
