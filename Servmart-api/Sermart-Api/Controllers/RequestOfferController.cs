using Application_Layer.Helpers;
using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.RequestOfferDTOs;
using Domain_Layer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;

namespace Sermart_Api.Controllers
{
	[Route( "api/[controller]" )]
	[ApiController]
	public class RequestOfferController : ControllerBase
	{
		private readonly IRequestOfferRepo _reqOfferRepo;
		private readonly IUnitOfWork _unitOfWork;

		private readonly IHubContext<NotificationHub> _hubContext;

		public RequestOfferController( IRequestOfferRepo repo, IUnitOfWork unitOfWork, IHubContext<NotificationHub> hubContext )
		{
			_reqOfferRepo = repo;
			_unitOfWork = unitOfWork;
			_hubContext = hubContext;
		}

		[HttpGet( "GetAll" )]
		public async Task<IActionResult> GetAll( string providerId, int page, int pageSize )
		{
			var result = await _reqOfferRepo.GetAll( providerId, page, pageSize );
			return Ok( result );
		}

		[HttpGet( "GetProviderOffersByStatus" )]
		public async Task<IActionResult> GetAllByStatus( int status, int page, int pageSize )
		{
			var providerId = User.FindFirstValue( ClaimTypes.NameIdentifier );
			var result = await _reqOfferRepo.GetProviderOffersByStatus( providerId, status, page, pageSize );
			return Ok( result );
		}

		[HttpGet( "ProviderOffersByStatusCount" )]
		public async Task<IActionResult> ProviderOffersByStatusCount( int status )
		{
			var providerId = User.FindFirstValue( ClaimTypes.NameIdentifier );
			var result = await _reqOfferRepo.GetProviderOffersByStatusCount( providerId, status );
			return Ok( result );
		}

		[HttpPost( "CreateOffer" )]
		public async Task<IActionResult> CreateOffer( [FromBody] AddRequestOfferDTO offerDTO )
		{
			var providerId = User.FindFirstValue( ClaimTypes.NameIdentifier );
			offerDTO.ProviderId = providerId;

			if ( !ModelState.IsValid )
			{
				return BadRequest( "Data is not accureid" );
			}

			var result = await _reqOfferRepo.AddAsync( offerDTO );
			_unitOfWork.CommitChanges();

			if ( result == null )
			{
				return BadRequest( "Failed to create offer" );
			}

			await _hubContext.Clients.User( offerDTO.ProviderId ).SendAsync( "SendNotificationToUser", "offer added" );

			return Ok( result );
		}

		[HttpPut( "update" )]
		public async Task<IActionResult> Update( UpdateRequestOfferDTO updateRequestOfferDTO )
		{
			var result = await _reqOfferRepo.Update( updateRequestOfferDTO );
			_unitOfWork.CommitChanges();
			if ( result == null )
			{
				return BadRequest( "Failed to update this request" );
			}
			return Ok( result );
		}

		[HttpGet( "GetUserRequestOffers" )]
		public async Task<IActionResult> GetRequestOffers( string requestId, int page, int pageSize )
		{
			var result = await _reqOfferRepo.GetUserRequestOffers( requestId, page, pageSize );
			return Ok( result );
		}

		[HttpGet( "UserRequestOffersCount" )]
		public async Task<IActionResult> UserRequestOffersCount( string requestId )
		{
			var result = await _reqOfferRepo.GetUserRequestOffersCount( requestId );
			return Ok( result );
		}


	}
}
