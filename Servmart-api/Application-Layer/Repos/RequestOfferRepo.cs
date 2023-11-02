using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Repos
{
    public class RequestOfferRepo : BaseRepos<RequestOffer>, IRequestOfferRepo
    {
        public RequestOfferRepo(AppDbContext appContext) : base(appContext)
        {
        }
    }
}
