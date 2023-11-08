using Domain_Layer.DTOs.ServiceDTOs;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using InfrastructureLayer;
using InfrastructureLayer.Interfaces;
using InfrastructureLayer.Repos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Repos
{
    public class ServiceRepo : BaseRepos<Service>, IServiceRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IPhotoService _photoService;
        public ServiceRepo(AppDbContext appContext, AppDbContext appDbContext, IPhotoService photoService) : base(appContext)
        {
            _appDbContext = appDbContext;
            _photoService = photoService;
        }

        public async Task<Service> GetByID(string ID)
        {
            return await _appDbContext.Service
                    .FirstOrDefaultAsync(x => x.ID.ToString() == ID);
        }

        public async Task<IEnumerable<Service>> GetAll()
        {
            return await _appDbContext.Service.ToListAsync();
        }

        public async Task<Service> Update(UpdateServiceDTO serviceDTO)
        {
            var service = await _appDbContext.Service.FirstOrDefaultAsync(x => x.ID.ToString() == serviceDTO.ID);
            if(service != null)
            {
                service.Discription = serviceDTO.Describtion;
                service.Title = serviceDTO.Name;
                var pic = await _photoService.AddPhotoAsync(serviceDTO.ServicePic);
                service.PicUrl = pic.Url.ToString();
                _appDbContext.Service.Update(service);
            }
            return service;
        }

        public async Task<Service> Delete(string ID)
        {
            var serivce = await _appDbContext.Service.FirstOrDefaultAsync(x => x.ID.ToString() == ID);
            if(serivce != null) 
                _appDbContext.Service.Remove(serivce);
            return serivce;
        }

        public async Task<Service> AddService(ServiceDTO serviceDTO, string providerID)
        {
            var pic = await _photoService.AddPhotoAsync(serviceDTO.ServicePic);
            var serivce = new Service()
            {
                Title = serviceDTO.Name,
                Discription = serviceDTO.Describtion,
                CategoryID = new Guid(serviceDTO.CategoryID),
                Rate = 0,
                ExpectedSalary = 0,
                ProviderID = providerID,
                PicUrl = pic.Url.ToString(),
            };

            await _appDbContext.Service.AddAsync(serivce);
            return serivce;
        }
    }
}
