using Domain_Layer.Models;

namespace ApplicationLayer.IRepos
{
    public interface IProduct
    {
        Task Add(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        Task<IEnumerable<Product>> GetAllProduct();
        Task<Product> GetProductByid(Guid id);
    }
}
