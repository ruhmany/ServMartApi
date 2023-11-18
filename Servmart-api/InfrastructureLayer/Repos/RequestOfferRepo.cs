﻿using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.RequestOfferDTOs;
using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureLayer.Repos
{
	public class RequestOfferRepo : BaseRepos<RequestOffer>, IRequestOfferRepo
	{
		private readonly AppDbContext _appDbContext;

		public RequestOfferRepo( AppDbContext appContext, AppDbContext appDbContext ) : base( appContext )
		{
			_appDbContext = appDbContext;
		}

		public async Task<RequestOffer> AddAsync( AddRequestOfferDTO offer )
		{
			await _appDbContext.RequestOffer.AddAsync( offer.ToModel() );

			return offer.ToModel();
		}

		public async Task<IEnumerable<RequestOffer>> GetAll( string providerId, int page, int pageSize )
		{
			var query = _appDbContext.RequestOffer.Where( o => o.ProviderID == providerId );
			if ( page > 0 && pageSize > 0 )
			{
				int recordsToSkip = ( page - 1 ) * pageSize;
				query = query.Skip( recordsToSkip ).Take( pageSize );
			}
			return await query.ToListAsync();
		}

		public async Task<IEnumerable<ViewRequestOfferDTO>> GetProviderOffersByStatus( string providerId, int status, int page, int pageSize )
		{
			var query = _appDbContext.RequestOffer.Where( o => o.ProviderID == providerId && o.Status == status && o.IsDirect == false );
			if ( page > 0 && pageSize > 0 )
			{
				int recordsToSkip = ( page - 1 ) * pageSize;
				query = query.Skip( recordsToSkip ).Take( pageSize );
			}
			return await query.Select( o => o.ToViewModel() ).ToListAsync();
		}

		public Task<int> GetProviderOffersByStatusCount( string providerId, int status )
		{
			return _appDbContext.RequestOffer.Where( o => o.ProviderID == providerId && o.Status == status && o.IsDirect == false ).CountAsync();
		}

		public async Task<RequestOffer> GetOfferById( string offerId )
		{
			return await _appDbContext.RequestOffer.FindAsync( offerId );
		}

		public async Task<RequestOffer> Update( UpdateRequestOfferDTO updateRequestOfferDTO )
		{
			var requestoffer = await _appDbContext.RequestOffer.FirstOrDefaultAsync( x => x.ID.ToString() == updateRequestOfferDTO.ID );
			if ( requestoffer != null )
			{
				requestoffer.ExpectSalary = updateRequestOfferDTO.ExpectedSalary;
				_appDbContext.RequestOffer.Update( requestoffer );
			}
			return requestoffer;
		}

		public async Task<IEnumerable<ViewRequestOfferDTO>> GetUserRequestOffers( string requestId, int page, int pageSize )
		{
			var query = _appDbContext.RequestOffer.Where( o => o.RequestID == Guid.Parse( requestId ) );
			if ( page > 0 && pageSize > 0 )
			{
				int recordsToSkip = ( page - 1 ) * pageSize;
				query = query.Skip( recordsToSkip ).Take( pageSize );
			}
			return await query.Select( o => o.ToViewModel() ).ToListAsync();
		}

		public Task<int> GetUserRequestOffersCount( string requestId )
		{
			return _appDbContext.RequestOffer.Where( o => o.RequestID == Guid.Parse( requestId ) ).CountAsync();
		}

		public async Task<Request> GetRequest( string requestId )
		{
			return await _appDbContext.Request.FindAsync( Guid.Parse( requestId ) );
		}
	}
}
