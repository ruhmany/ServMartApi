using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.RateDTOs;
using Infrastructure_Layer.IRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sermart_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RateController : ControllerBase
    {
        private readonly IRateRepo _repo;
        private readonly IUnitOfWork _unitOfWork;

        public RateController(IUnitOfWork unitOfWork, IRateRepo repo)
        {
            _unitOfWork = unitOfWork;
            _repo = repo;
        }

        [HttpPost("RateProduct")]
        public async Task<IActionResult> RateProduct(RateProductDTO rateProductDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _repo.RateProduct(rateProductDTO);
            _unitOfWork.CommitChanges();
            return Ok(result);
        }


        [HttpPost("RateService")]
        public async Task<IActionResult> RateService(RateServiceDTO rateProductDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _repo.RateService(rateProductDTO);
            _unitOfWork.CommitChanges();
            return Ok(result);
        }
    }
}
