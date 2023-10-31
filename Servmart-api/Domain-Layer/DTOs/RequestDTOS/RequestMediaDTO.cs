using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.DTOs.RequestDTOS
{
    public class RequestMediaDTO
    {
        public Guid ID { get; set; }
        public IFormFile MeadiUrl { get; set; }
        public Guid RequestID { get; set; }  
    }
}
