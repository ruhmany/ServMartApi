using Domain_Layer.DTOs.RateDTOs;
using Domain_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.IRepos
{
    public interface IRateRepo
    {
        Task<ServiceRate> RateService(RateServiceDTO rateServiceDTO);
        Task<ProductRate> RateProduct(RateProductDTO rateProductDTO);

    }
}
