﻿using ApplicationLayer.IRepos;
using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureLayer.Repos
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
