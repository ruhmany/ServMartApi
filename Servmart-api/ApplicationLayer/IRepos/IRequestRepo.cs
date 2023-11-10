using Domain_Layer.DTOs.RequestDTOS;
using Domain_Layer.Models;

namespace ApplicationLayer.IRepos
{
    public interface IRequestRepo
    {
        Task<Request> AddRequest( RequestDTO requestDTO );
        Task<Request> Update(RequestUpdateDTO requestDTO);
        Task<IEnumerable<RequestShowDTO>> GetAllRequests( int page, int pageSize );
        Request Delete(string id);
        Task<Request> GetById(string id);
        List<Request> FilterRequest( string id, decimal Price, decimal? minPrice, decimal? maxPrice);
        Task<int> GetTotalRequestItems();

    }
}
