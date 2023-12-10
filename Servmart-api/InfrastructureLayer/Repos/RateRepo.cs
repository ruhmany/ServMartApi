using Domain_Layer.DTOs.RateDTOs;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using InfrastructureLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Repos
{
    public class RateRepo : IRateRepo
    {
        private readonly AppDbContext _appDbContext;
        public RateRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<ProductRate> RateProduct(RateProductDTO rateProductDTO)
        {
            var rate = new ProductRate
            {
                Rate = rateProductDTO.Rate,
                Description = rateProductDTO.Description,
                ProductId = rateProductDTO.ProductId,
                CustomerID = rateProductDTO.CustomerID,
            };
            var result = await _appDbContext.ProductRate.AddAsync(rate);
            return result.Entity;
        }

        public async Task<ServiceRate> RateService(RateServiceDTO rateServiceDTO)
        {
            var rate = new ServiceRate
            {
                ServiceID = rateServiceDTO.ServiceID,
                UserID = rateServiceDTO.UserID,
                Message = rateServiceDTO.Message,
                NominateToOthers = rateServiceDTO.NominateToOthers,
                WorkQuality = rateServiceDTO.WorkQuality,
                RespectDeliveryTime = rateServiceDTO.RespectDeliveryTime,
            };
            var result = await _appDbContext.ServiceRate.AddAsync(rate);
            return result.Entity;

        }
    }
}
