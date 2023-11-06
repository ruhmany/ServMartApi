using Application_Layer.Repos;
using Domain_Layer.DTOs.RequestDTOS;
using Infrastructure_Layer.IRepos;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Sermart_Api.Controllers
{
    public class Requestcontroller : ControllerBase
    {
        private readonly IRequestRepo _request;

        public Requestcontroller(IRequestRepo request)
        {
            _request = request;

        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromForm] RequestDTO requestDTO)
        {
            var request = await _request.AddRequest(requestDTO);
            return Ok(request);
        }
        [HttpPost("Update")]
        public IActionResult UpDate(Guid id,[FromBody] RequestUpdateDTO request) 
        {
            request.ClientId = id;
            _request.UPDate(request);
            return Ok();


        }
        [HttpPost("Delet")]
        public IActionResult Delete(Guid id)
        {
            _request.Delete(id);
            return Ok();

        }

        [HttpGet("GetAll")]

        public async Task<IActionResult> Getall()
        {

            var request = await _request.GetAllRequests();
            return Ok(request);
        }
        [HttpGet("FilterRequest")]
        public IActionResult Filter(Guid clientId, decimal price, decimal? minPrice, decimal? maxPrice)
        {
            var filteredRequests = _request.filterReq(clientId, price, minPrice, maxPrice);
            return Ok(filteredRequests);
        }

    }
}
