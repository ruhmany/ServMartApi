using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.DTOs.ServiceDTOs
{
    public class ServiceDTO
    {
        public string UserId { get; set; }
        public string Title { get; set; }
        public string CategoryID { get; set; }
        public string Description { get; set; }
        public ICollection<IFormFile> ServicePic { get; set; }
    }
}
