using Application_Layer.Helpers;
using ApplicationLayer.IRepos;
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
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepo _orderRepo;
        private readonly UserManager<User> _usermanager;
        private readonly IUnitOfWork _unitofwork;
        public OrderController(IOrderRepo orderRepo, UserManager<User> usermanager, IUnitOfWork unitofwork)
        {
            _orderRepo = orderRepo;
            _usermanager = usermanager;
            _unitofwork = unitofwork;
        }


        [HttpPost]
        public async Task<IActionResult> MakeOrder()
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _usermanager.FindByIdAsync(userid);
            var orderitemslist = OrderHelper.GetOrderItems(user.Cart);
            var order = new Order { Items = orderitemslist };
            order.UserID = userid;
            user.Orders.Add(order);
            _unitofwork.CommitChanges();            
            return Ok();
        }

    }
}
