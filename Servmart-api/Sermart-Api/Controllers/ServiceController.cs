using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.ServiceDTOs;
using Infrastructure_Layer.IRepos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Sermart_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IUnitOfWork _unitofwork;
        private readonly IServiceRepo _serviceRepo;

        public ServiceController(IServiceRepo serviceRepo, IUnitOfWork unitofwork)
        {
            _serviceRepo = serviceRepo;
            _unitofwork = unitofwork;
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddService([FromForm] ServiceDTO serviceDTO)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _serviceRepo.AddService(serviceDTO, userID);
            _unitofwork.CommitChanges();
            return Ok();
        }
    }
}
