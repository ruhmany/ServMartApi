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
    public class ProductCatgoryRepo : IProductCatgory
    {
        private readonly AppDbContext _dbContext;

        public ProductCatgoryRepo(AppDbContext dbContext) {
            _dbContext = dbContext;
        }
        public async Task Add(ProductCategory entity)
        {
            await _dbContext.ProductCategorie.AddAsync(entity);
        }

        public async Task<IEnumerable<ProductCategory>> GetAllProduct()
        {
            return await _dbContext.ProductCategorie.ToListAsync();
        }
        public async Task <int> getCatgoryCount()
        {
            return await _dbContext.ProductCategorie.CountAsync();
        }
    }
}
