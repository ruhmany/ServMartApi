using ApplicationLayer.Enums;
using Domain_Layer.DTOs.RequestOfferDTOs;
using Domain_Layer.Models;

namespace ApplicationLayer.IRepos
{
	public interface IRequestOfferRepo : IBaseRepo<RequestOffer>
	{
		Task<IEnumerable<RequestOffer>> GetAll( string providerId, int page, int pageSize );
		Task<IEnumerable<ViewRequestOfferDTO>> GetAllByStatus( string providerId, OfferStatus Status, int page, int pageSize );
		Task<RequestOffer> AddAsync( AddRequestOfferDTO offer );
		Task<RequestOffer> GetOfferById( string offerId );
		Task<RequestOffer> Update( UpdateRequestOfferDTO updateRequestOfferDTO );
	}
}
