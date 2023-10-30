using Application_Layer.Repos;
using Domain_Layer.DTOs;
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
        [HttpPost("Add")]
        public async Task<IActionResult> Create([FromBody] RequestDTO requestDTO)
        {
            await _request.AddRequest(requestDTO);
            return Ok();
        }
        [HttpPost("Id")]
        public IActionResult UpDate(Guid id,[FromBody] RequestUpdateDTO request) 
        {
            request.ClientId = id;
            _request.UPDate(request);
            return Ok();

        }
        [HttpPost("Detete")]
        public IActionResult Delete(Guid id)
        {
            _request.Delete(id);
            return Ok();

        }

        [HttpGet("get")]
        
        public IActionResult Getall() {
        
           var request = _request.GetRequestList();
            return Ok(request);
        }
       

    }
}
