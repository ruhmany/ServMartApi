using Domain_Layer.Models;

namespace Infrastructure_Layer.IRepos
{
	public interface IRequestServiceCategory
	{
		Task AddCategory( ServiceCategory entity );
		Task<ServiceCategory> GetCategoryById(string id);
		Task<IEnumerable<ServiceCategory>> GetAllCategories();
	}
}
