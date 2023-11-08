using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Repos
{
    public class Products : IProduct
    {
        private readonly AppDbContext _dbContext;

        public Products(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Product entity)
        {
            await _dbContext.Product.AddAsync(entity);
        }

        public   void Delete(Product entity)
        {
            _dbContext.Set<Product>().Remove(entity);
        }

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            return await _dbContext.Product.ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetUserProduct(string id)
        {
            return await _dbContext.Product.Where(x => x.ProviderId == id).ToListAsync();
        }

        public async Task<Product> GetProductByid(Guid id)
        {
          return  await  _dbContext.Product.FindAsync(id);
        }

        public void Update(Product entity)
        {
            _dbContext.Product.Update(entity);
        }
    }
}
