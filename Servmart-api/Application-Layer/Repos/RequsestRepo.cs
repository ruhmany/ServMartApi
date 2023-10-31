using Application_Layer.Interfaces;
using CloudinaryDotNet.Actions;
using Domain_Layer.DTOs.RequestDTOS;
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
                StartDate = DateTime.Now,
                EndDate = requestDTO.EndDate,
                ExpectSalary = requestDTO.Price,
                State = requestDTO.Status
            };

            foreach (var item in requestDTO.picUrl)
            {
                var resualt = await _photoService.AddPhotoAsync(item);
                request.Media.Add(new RequestMedia() { MediaUrl = resualt.Url.ToString(), RequestID=request.ID });
            }

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

        public List<Request> filterReq(Guid Cleinrid, decimal Price, decimal? minPrice, decimal? maxPrice)
        {
            IQueryable<Request> query = _appDbContext.Request;
            query = query.Where(r => r.CleintID ==Cleinrid);
            query =query.Where(R=>R.ExpectSalary == Price);
             if (minPrice.HasValue)
            {
                query = query.Where(r => r.ExpectSalary >= minPrice.Value);

            }
             if (maxPrice.HasValue)
            {
                query= query.Where(R=>R.ExpectSalary <= maxPrice.Value);

            }
             return query.ToList();
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

       

 
    }
}
