using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.CartItemDTOs;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using InfrastructureLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Repos
{
    public class CartItemRepo : IcartItemRepo
    {
        private readonly AppDbContext _context;
        public CartItemRepo(AppDbContext dbContext) { _context = dbContext; }

        public async Task<CartItem> Add(string ProducID, string userID)
        {
            var item = new CartItem
            {
                ProductID = new Guid(ProducID),
                Qauntety = 1
            };
            await _context.CartItem.AddAsync(item);
            return item;
        }

        public async Task<CartItem> Delete(int id)
        {
            var item = await _context.CartItem.FirstOrDefaultAsync(item => item.Id == id);
            if (item != null)
                _context.CartItem.Remove(item);
            return item;
        }

        public async Task<IEnumerable<CartItem>> GetAllItems()
        {
            return await _context.CartItem.ToListAsync();
        }

        public async Task<CartItem> Update(CartItemUpdateDTO cartItemUpdateDTO)
        {
            var item = await _context.CartItem.FirstOrDefaultAsync(item => item.Id == cartItemUpdateDTO.CartItemID);
            if (item == null)
                return item;
            item.Qauntety = cartItemUpdateDTO.Quantity;
            _context.CartItem.Update(item);
            return item;
        }

        IEnumerable<CartItem> IBaseRepo<CartItem>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
