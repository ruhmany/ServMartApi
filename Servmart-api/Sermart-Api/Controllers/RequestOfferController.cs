using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.RequestOfferDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sermart_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestOfferController : ControllerBase
    {
        private readonly IRequestOfferRepo _repo;

        public RequestOfferController(IRequestOfferRepo repo)
        {
            _repo = repo;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _repo.GetAll();
            return Ok(result);
        }

        [HttpPatch]
        public async Task<IActionResult> Update(RequestOfferUpdateDTO requestOfferUpdateDTO)
        {
            var result = await _repo.Update(requestOfferUpdateDTO);
            if (result is null)
                return BadRequest("No Offer With this ID");
            return Ok(result);
        }
    }
}
