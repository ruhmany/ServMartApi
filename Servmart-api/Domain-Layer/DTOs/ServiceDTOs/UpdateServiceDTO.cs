using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.DTOs.ServiceDTOs
{
    public class UpdateServiceDTO
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string CategoryID { get; set; }
        public string Describtion { get; set; }
        public IFormFile ServicePic { get; set; }
    }
}
