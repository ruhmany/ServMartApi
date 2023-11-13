using ApplicationLayer.Enums;
using ApplicationLayer.IRepos;
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

		public async Task<IEnumerable<ViewRequestOfferDTO>> GetAllByStatus( string providerId, OfferStatus status, int page, int pageSize )
		{
			var query = _appDbContext.RequestOffer.Where( o => o.ProviderID == providerId && o.Status == ( (int)status ) && o.IsDirect == false );
			if ( page > 0 && pageSize > 0 )
			{
				int recordsToSkip = ( page - 1 ) * pageSize;
				query = query.Skip( recordsToSkip ).Take( pageSize );
			}
			return await query.Select( o => o.ToViewModel() ).ToListAsync();
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

	}
}
