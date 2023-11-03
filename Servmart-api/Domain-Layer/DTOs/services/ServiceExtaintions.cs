using Domain_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;

namespace Domain_Layer.DTOs.services
{
    public static  class ServiceExtaintions
    {
        

        public static Servicesviewmodel ToVeiwModel(this Service services)
        {

            return new Servicesviewmodel
            {
                ID = services.ID,
                Title = services.Title,
                ExpectedSalary = services.ExpectedSalary,
                Discription = services.Discription,
                CategoryName = services.ServiceCategory.Name,
                ProviderID = services.ProviderID,
                Rate = services.Rate,
                filepath = services.FilePath 

            };
        }


    }
}
