using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using InfrastructureLayer;
using InfrastructureLayer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Repos
{
    public class OrderRepo : BaseRepos<Order>, IOrderRepo
    {
        private readonly AppDbContext _appDbContext;
        public OrderRepo(AppDbContext appContext) : base(appContext)
        {
            _appDbContext = appContext;
        }

        public async Task<Order> MakeOrder(Order order)
        {
            await _appDbContext.Order.AddAsync(order);
            return order;
        }
    }
}
