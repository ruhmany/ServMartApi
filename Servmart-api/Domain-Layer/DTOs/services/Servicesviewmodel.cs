using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.DTOs.services
{
    public class Servicesviewmodel
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public float Rate { get; set; }
        public decimal ExpectedSalary { get; set; }
        public string filepath { get; set; }
        public FileContentResult file { get; set; }
        public string CategoryName { get; set; }
        public string ProviderID { get; set; }

    }
}
