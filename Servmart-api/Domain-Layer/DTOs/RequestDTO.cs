using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.DTOs
{
    public class RequestDTO
    {
        
        public Guid ClientId { get; set; }
        public string  Details { get; set; }
        public decimal Price { get; set; }
        public int Status { get; set; }= 0;
        public string picUrl { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string RateMassage { get; set; }



    }
}
