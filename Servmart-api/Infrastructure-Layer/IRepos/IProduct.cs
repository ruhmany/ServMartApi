using Domain_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.IRepos
{
    public interface IProduct
    {
        Task Add(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        Task<IEnumerable<Product>> GetAllProduct();
        Task<IEnumerable<Product>> GetUserProduct(string id);
        Task<Product> GetProductByid(Guid id);
    }
}
