using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.DTOs
{
    public class ServicesDTO
    {
        public Guid ID { get; set; }
 
        public string Title { get; set; }
        public string Discription { get; set; }
        public float Rate { get; set; }
        public decimal ExpectedSalary { get; set; }
        public IFormFile file { get; set; } 

        public Guid CategoryID { get; set; }
        public string ProviderID { get; set; }
    }
}
