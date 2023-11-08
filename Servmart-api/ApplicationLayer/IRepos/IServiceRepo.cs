using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.ServiceDTOs;
using Domain_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.IRepos
{
    public interface IServiceRepo : IBaseRepo<Service>
    {
        Task<Service> AddService(ServiceDTO serviceDTO, string providerID);
        Task<Service> GetByID(string ID);
        Task<IEnumerable<Service>> GetAll();
        Task<Service> Update(UpdateServiceDTO serviceDTO);
        Task<Service> Delete(string ID);
    }
}
