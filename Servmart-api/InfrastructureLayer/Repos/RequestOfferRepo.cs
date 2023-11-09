using Domain_Layer.Models;
using ApplicationLayer.IRepos;
using Microsoft.EntityFrameworkCore;
using Domain_Layer.DTOs.RequestOfferDTOs;

namespace InfrastructureLayer.Repos
{
    public class RequestOfferRepo : BaseRepos<RequestOffer>, IRequestOfferRepo
    {
        private readonly AppDbContext _dbContext;
        public RequestOfferRepo(AppDbContext appContext, AppDbContext dbContext) : base(appContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<RequestOffer>> GetAll()
        {
            return await _dbContext.RequestOffer.ToListAsync<RequestOffer>();
        }

        public async Task<RequestOffer> Update(RequestOfferUpdateDTO offer)
        {
            var requestoffer = await _dbContext.RequestOffer.FirstOrDefaultAsync<RequestOffer>(r => r.ID.ToString() == offer.ID );
            if( requestoffer == null )
            {
                return requestoffer;
            }
            requestoffer.ExpectSalary = offer.ExpectSalary;
            _dbContext.RequestOffer.Update(requestoffer);
            return requestoffer;
        }
    }
}
