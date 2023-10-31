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
        [HttpPost("api/AddRequest")]
        public async Task<IActionResult> Create([FromForm] RequestDTO requestDTO)
        {
            await _request.AddRequest(requestDTO);
            return Ok();
        }
        [HttpPost("Api/UpDate")]
        public IActionResult UpDate(Guid id,[FromBody] RequestUpdateDTO request) 
        {
            request.ClientId = id;
            _request.UPDate(request);
            return Ok();

        }
        [HttpPost("Api/Detete")]
        public IActionResult Delete(Guid id)
        {
            _request.Delete(id);
            return Ok();

        }

        [HttpGet("Api/getall")]
        
        //public IActionResult Getall() {
        
        //   var request = _request.GetRequestList();
        //    return Ok(request);
        //}
        [HttpGet("FilterRequest")]
        public IActionResult Filter(Guid clientId, decimal price, decimal? minPrice, decimal? maxPrice)
        {
            var filteredRequests = _request.filterReq(clientId, price, minPrice, maxPrice);
            return Ok(filteredRequests);
        }

    }
}
