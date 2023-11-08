using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.RequestOfferDTOs;
using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureLayer.Repos
{
    public class RequestOfferRepo : BaseRepos<RequestOffer>, IRequestOfferRepo
    {
        private readonly AppDbContext _appDbContext;
        public RequestOfferRepo(AppDbContext appContext, AppDbContext appDbContext) : base(appContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<RequestOffer>> GetAll()
        {
            return await _appDbContext.RequestOffer.ToListAsync();
        }

        public async Task<RequestOffer> Update(UpdateRequestOfferDTO updateRequestOfferDTO)
        {
            var requestoffer = await _appDbContext.RequestOffer.FirstOrDefaultAsync(x => x.ID.ToString() ==  updateRequestOfferDTO.ID);
            if(requestoffer != null)
            {
                requestoffer.ExpectSalary = updateRequestOfferDTO.ExpectedSalary;
                _appDbContext.RequestOffer.Update(requestoffer);
            }
            return requestoffer;
        }
   
    }
}
