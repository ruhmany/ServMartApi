﻿using Domain_Layer.DTOs.RequestDTOS;
using Domain_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.IRepos
{
    public interface IRequestRepo
    {
        Task<Request> AddRequest(RequestDTO requestDTO);
        List<Request> GetRequestList();
        //Task<RequestDTO> GetReqModel();
        Task<Request> UPDate(RequestUpdateDTO requestDTO);
        Task<IEnumerable<Request>> GetAllRequests();
        Request Delete(Guid id);
        Task<Request> GitbyId(Guid id);
        List<Request> filterReq(Guid id, decimal Price, decimal? minPrice, decimal? maxPrice);


       
    }
}
