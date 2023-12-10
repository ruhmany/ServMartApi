using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.DTOs.RateDTOs
{
    public class RateServiceDTO
    {
        public Guid ServiceID { get; set; }
        public string UserID { get; set; }
        public string Message { get; set; }
        public float NominateToOthers { get; set; }
        public float WorkQuality { get; set; }
        public float RespectDeliveryTime { get; set; }
    }
}
