using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.RequestOfferDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sermart_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class RequestOfferController : ControllerBase
    {
        private readonly IRequestOfferRepo _repo;
        private readonly IUnitOfWork _unitOfWork;

        public RequestOfferController(IRequestOfferRepo repo, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _unitOfWork = unitOfWork;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _repo.GetAll();
            return Ok(result);
        }

        [HttpPatch]
        public async Task<IActionResult> Update(UpdateRequestOfferDTO updateRequestOfferDTO)
        {
            var result = await _repo.Update(updateRequestOfferDTO);
            _unitOfWork.CommitChanges();
            if(result == null)
            {
                return BadRequest("Failed to update this request");
            }
            return Ok(result);
        }

    }
}
