using Domain_Layer.DTOs;
using Domain_Layer.DTOs.services;
using Domain_Layer.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.IRepos
{
    public interface IServiceRepo
    {
        public List<Servicesviewmodel> GetAllServices();
        Servicesviewmodel GetItemById(Guid id);
        void AddNewItem(ServicesDTO ServicesDTO, string filepath);
        
        void UpdateItem(Guid id, ServicesDTO ServicesDTO, string filepath);
        
        void RemoveItem(Guid id);
        public PaginationViewModel<List<Servicesviewmodel>> Search(
            Guid? ID,
            String? Name = null,
            String? CategoryName = null,
           
            int ExpectedSalary = 0,
            String OrderBy = "date",
            bool IsAscending = false,
            int PageSize = 6,
            int PageIndex = 1
            );

    }
}
