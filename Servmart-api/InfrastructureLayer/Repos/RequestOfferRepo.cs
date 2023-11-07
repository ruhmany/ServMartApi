using ApplicationLayer.IRepos;
using Domain_Layer.Models;

namespace InfrastructureLayer.Repos
{
    public class RequestOfferRepo : BaseRepos<RequestOffer>, IRequestOfferRepo
    {
        public RequestOfferRepo(AppDbContext appContext) : base(appContext)
        {
        }
    }
}
