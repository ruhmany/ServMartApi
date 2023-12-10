using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.DTOs.RateDTOs
{
    public class RateProductDTO
    {
        public float Rate { get; set; }
        public string Description { get; set; }
        public Guid ProductId { get; set; }
        public string CustomerID { get; set; }
    }
}
