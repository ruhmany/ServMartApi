using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.ServiceDTOs;
using Infrastructure_Layer.IRepos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Sermart_Api.Controllers
{
	[Route( "api/[controller]" )]
	[ApiController]
	public class ServiceController : ControllerBase
	{
		private readonly IUnitOfWork _unitofwork;
		private readonly IServiceRepo _serviceRepo;

		public ServiceController( IServiceRepo serviceRepo, IUnitOfWork unitofwork )
		{
			_serviceRepo = serviceRepo;
			_unitofwork = unitofwork;
		}

		[HttpGet( "GetAllServices" )]
		public async Task<IActionResult> GetAll()
		{
			var result = await _serviceRepo.GetAll();
			return Ok( result );
		}

		[HttpGet( "GetServiceByID" )]
		public async Task<IActionResult> GetByID( string ID )
		{
			var result = await _serviceRepo.GetByID( ID );
			if ( result == null )
			{
				return BadRequest( result );
			}
			return Ok( result );
		}

		[HttpPost( "AddService" )]
		[Authorize( Roles = "ServiceProvider" )]
		public async Task<IActionResult> AddService( [FromForm] ServiceDTO serviceDTO )
		{
			if ( !ModelState.IsValid )
			{
				return BadRequest( ModelState );
			}
			serviceDTO.UserId = User.FindFirstValue( ClaimTypes.NameIdentifier );
			_serviceRepo.AddService( serviceDTO );
			_unitofwork.CommitChanges();
			return Ok();
		}

		[HttpPut( "UpdateService" )]
		[Authorize( Roles = "ServiceProvider" )]
		public async Task<IActionResult> UpdateService( UpdateServiceDTO serviceDTO )
		{

			var result = await _serviceRepo.Update( serviceDTO );
			if ( result == null )
				return BadRequest( result );
			_unitofwork.CommitChanges();
			return Ok( result );
		}

		[HttpDelete( "Delete" )]
		[Authorize( Roles = "ServiceProvider" )]
		public async Task<IActionResult> Delete( string Id )
		{
			var result = await _serviceRepo.Delete( Id );
			if ( result == null )
				return BadRequest( result );
			_unitofwork.CommitChanges();
			return Ok( result );
		}

		//[HttpGet("GetProviders")]
		//public Task<IActionResult> GetProviders()
		//{
		//    return null;
		//}

	}
}
