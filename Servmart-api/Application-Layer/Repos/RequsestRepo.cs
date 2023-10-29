using Application_Layer.Interfaces;
using Domain_Layer.DTOs;
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
    public class RequsestRepo : BaseRepos<Request>, IRequestRepo
    { 
        private readonly AppDbContext _appDbContext;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPhotoService _photoService;

        public RequsestRepo(AppDbContext appContext, IUnitOfWork unitOfWork, IPhotoService photoService) : base(appContext)
        {
            _appDbContext = appContext;
            _unitOfWork = unitOfWork;
            _photoService = photoService;
        }

        public async Task<Request> AddRequest(RequestDTO requestDTO)
        {
            var request = new Request()
            {
                CleintID = requestDTO.ClientId,
                ID = Guid.NewGuid(),
                Details = requestDTO.Details,
                RateMassage = requestDTO.RateMassage,
                StartDate = requestDTO.StartDate,
                EndDate = requestDTO.EndDate,
                ExpectSalary=requestDTO.Price,
                State=requestDTO.Status
            };
            await _appDbContext.Request.AddAsync(request);
             _unitOfWork.CommitChanges();

            return null;
        }

        public Request Delete(Guid id)
        {
            var request= _appDbContext.Request.FirstOrDefault(x => x.ID == id);
            if (request != null)
            {
                 _appDbContext.Request.Remove(request);
            }
            return request;


           
        }

        public List<Request> filterReq(Guid id, decimal Price, decimal? minPrice, decimal? maxPrice)
        {
            throw new NotImplementedException();
        }

        public List<Request> GetRequestList()
        {
            return _appDbContext.Request.ToList();
        }

        public async Task<Request> GitbyId(Guid id)
        {
            return await _appDbContext.Request.FirstOrDefaultAsync(R => R.CleintID == id );
          
        }

        public async Task<Request> UPDate(RequestUpdateDTO requestDTO)
        {
            var req = await _appDbContext.Request.FirstOrDefaultAsync(r => r.ID == requestDTO.ID);
            if (req != null)
            {
                req.StartDate = requestDTO.StartDate;
                req.EndDate = requestDTO.EndDate;
                req.State = requestDTO.Status;
                req.RateMassage = requestDTO.RateMassage;
                req.CleintID = requestDTO.ClientId;
                req.Details= requestDTO.Details;


                _appDbContext.Request.Update(req);
                _unitOfWork.CommitChanges();
            }
            return req;
            //var request = new Request()
            //{
            //    CleintID = requestDTO.ClientId,
            //    ID = Guid.NewGuid(),
            //    Details = requestDTO.Details,
            //    RateMassage = requestDTO.RateMassage,
            //    StartDate = requestDTO.StartDate,
            //    EndDate = requestDTO.EndDate,
            //    ExpectSalary = requestDTO.Price,
            //    State = requestDTO.Status


            //};
        }

       

        Task<RequestDTO> IRequestRepo.GetReqModel()
        {
            throw new NotImplementedException();
        }
    }
}
