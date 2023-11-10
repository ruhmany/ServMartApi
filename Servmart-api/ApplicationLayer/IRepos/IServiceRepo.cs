using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.ServiceDTOs;
using Domain_Layer.Models;

namespace Infrastructure_Layer.IRepos
{
	public interface IServiceRepo : IBaseRepo<Service>
	{
		Task<Service> AddService( ServiceDTO serviceDTO );
		Task<Service> GetByID( string ID );
		Task<IEnumerable<ServiceShowTDO>> GetAll( int page, int pageSize );
		Task<Service> Update( UpdateServiceDTO serviceDTO );
		Task<Service> Delete( string ID );
		Task<IEnumerable<Service>> GetUserServices( string userId );
		Task<int> GetTotalRequestItems();
		Task<IEnumerable<ServiceUser>> GetServicesProviders( int page, int pageSize );
	}
}
