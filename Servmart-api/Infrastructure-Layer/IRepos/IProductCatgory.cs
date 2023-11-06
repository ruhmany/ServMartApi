using Domain_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.IRepos
{
    public interface IProductCatgory
    {
        Task Add(ProductCategory entity);
        Task<IEnumerable<ProductCategory>> GetAllProduct();
        Task<int> getCatgoryCount();
    }
}
