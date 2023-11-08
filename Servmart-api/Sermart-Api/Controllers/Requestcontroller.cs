using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.RequestDTOS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Sermart_Api.Controllers
{
	[Route( "api/[controller]" )]
	[ApiController]
	public class Requestcontroller : ControllerBase
	{
		private readonly IRequestRepo _request;
		private readonly IUnitOfWork _unitOfWork;

		public Requestcontroller( IRequestRepo request, IUnitOfWork unitOfWork )
		{
			_request = request;
			_unitOfWork = unitOfWork;
		}

		[HttpPost( "Create" )]
		[Authorize]
		public async Task<IActionResult> Create( [FromForm] RequestDTO requestDTO )
		{
			requestDTO.ClientId = User.FindFirstValue( ClaimTypes.NameIdentifier );
			var request = await _request.AddRequest( requestDTO );
			_unitOfWork.CommitChanges();
			return Ok( request );
		}

		[HttpPost( "Update" )]
		public IActionResult UpDate( string id, [FromBody] RequestUpdateDTO request )
		{
			request.ClientId = id;
			_request.UPDate( request );
			_unitOfWork.CommitChanges();
			return Ok();


		}

		[HttpPost( "Delet" )]
		public IActionResult Delete( string id )
		{
			_request.Delete( id );
			_unitOfWork.CommitChanges();
			return Ok();

		}

		[HttpGet( "GetAll" )]
		public async Task<IActionResult> Getall()
		{
			var request = await _request.GetAllRequests();
			return Ok( request );
		}

		[HttpGet( "FilterRequest" )]
		public IActionResult Filter( string userId, decimal price, decimal? minPrice, decimal? maxPrice )
		{
			var filteredRequests = _request.filterReq( userId, price, minPrice, maxPrice );
			return Ok( filteredRequests );
		}

	}
}
