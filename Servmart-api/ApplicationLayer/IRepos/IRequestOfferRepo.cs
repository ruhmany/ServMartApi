using Domain_Layer.DTOs.RequestOfferDTOs;
using Domain_Layer.Models;

namespace ApplicationLayer.IRepos
{
    public interface IRequestOfferRepo : IBaseRepo<RequestOffer>
    {
        Task<IEnumerable<RequestOffer>> GetAll();
        Task<RequestOffer> Update(UpdateRequestOfferDTO updateRequestOfferDTO);
    }
}
