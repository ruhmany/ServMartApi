using Domain_Layer.DTOs.RequestDTOS;
using Domain_Layer.Models;

namespace ApplicationLayer.IRepos
{
    public interface IRequestRepo
    {
        Task<Request> AddRequest( RequestDTO requestDTO );
        List<Request> GetRequestList();
        //Task<RequestDTO> GetReqModel();
        Task<Request> UPDate(RequestUpdateDTO requestDTO);
        Task<IEnumerable<RequestShowDTO>> GetAllRequests();
        Request Delete(string id);
        Task<Request> GitbyId(string id);
        List<Request> filterReq(string id, decimal Price, decimal? minPrice, decimal? maxPrice);



    }
}
