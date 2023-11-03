using Abp.Linq.Expressions;
using Domain_Layer.DTOs;
using Domain_Layer.DTOs.services;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Repos
{
    public class ServiceRepo : BaseRepos<Service>,IServiceRepo
    {
        private readonly AppDbContext _appContext;
        public ServiceRepo(AppDbContext appContext) :base(appContext)
        {
            _appContext = appContext;

        }
        public PaginationViewModel<List<Servicesviewmodel>> Search(
            Guid? ID,
            String? Name = null,
            String? CategoryName = null,
         
            int ExpectedSalary = 0,
            String OrderBy = "ExpectedSalary",
            bool IsAscending = false,
            int PageSize = 6,
            int PageIndex = 1
            ) {
            var filter = PredicateBuilder.New<Service>();
            var oldFilter = filter;

          

            if (!string.IsNullOrEmpty(Name))
            {
                filter = filter.Or(i => i.Title.ToLower().Contains(Name.ToLower()));
            }
            if (!string.IsNullOrEmpty(CategoryName))
            {
                filter = filter.Or(i => i.ServiceCategory.Name.ToLower().Contains(CategoryName.ToLower()));
            }
            
            if (ExpectedSalary != 0)
            {
                filter = filter.And(i => i.ExpectedSalary <= ExpectedSalary);
            }
           
            if (ID!=Guid.Empty)
            {
                filter = filter.Or(i=>i.ID==ID);
            }

            if (oldFilter == filter)
            {
                filter = null;
            }

            var result=base.Get(filter, OrderBy, IsAscending, PageSize, PageIndex);
            return new PaginationViewModel<List<Servicesviewmodel>>()
            {
                PageIndex = PageIndex,
                PageSize = PageSize,
                Count=base.GetAll().Count(),
                Data = result.Select(i => i.ToVeiwModel()).ToList()

            };
        }
        public List<Servicesviewmodel> GetAllServices()
        {
            try  {
                    return GetList().Select(i => i.ToVeiwModel()).ToList();
                }
                catch (Exception ex)
            {
                // Log the exception for troubleshooting

                // Log the exception for debugging purposes
                Console.WriteLine($"Error: {ex.Message}");

                // Rethrow the exception to propagate it to the calling code
                throw;
            }
        }
     
        public Servicesviewmodel GetItemById(Guid id)

        {

            return GetAllServices().Where(i => i.ID == id).FirstOrDefault();

        }

        public void AddNewItem(ServicesDTO ServicesDTO,string filepath)
        {
            try
            {


                // Now you can save the file path along with other properties
                var newservice = new Service
                {
                    Title = ServicesDTO.Title,
                    Discription = ServicesDTO.Discription,
                    Rate = ServicesDTO.Rate,
                    ExpectedSalary = ServicesDTO.ExpectedSalary,
                    CategoryID = ServicesDTO.CategoryID,
                    ProviderID = "11111111-1111-1111-1111-118111111111",
                    FilePath = filepath
                };

                    _appContext.Service.Add(newservice);
                    _appContext.SaveChanges();
                
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                Console.WriteLine($"Error: {ex.Message}");

                // Rethrow the exception to propagate it to the calling code
                throw;
            }
        }

        public void UpdateItem(Guid id, ServicesDTO ServicesDTO,string filepath)
        {
            Service oldservice = _appContext.Service.FirstOrDefault(service => service.ID == id);

            oldservice.Title = ServicesDTO.Title;
            oldservice.Discription = ServicesDTO.Discription;
            oldservice.Rate = ServicesDTO.Rate;
            oldservice.ExpectedSalary = ServicesDTO.ExpectedSalary;
            oldservice.CategoryID = ServicesDTO.CategoryID;
            oldservice.FilePath = filepath;
            _appContext.Service.Update(oldservice);
            _appContext.SaveChanges();
        }
        public void RemoveItem(Guid id)
        {
            Service oldservice = _appContext.Service.FirstOrDefault(service => service.ID == id);
            _appContext.Service.Remove(oldservice);
            _appContext.SaveChanges();
        }

    }
}
