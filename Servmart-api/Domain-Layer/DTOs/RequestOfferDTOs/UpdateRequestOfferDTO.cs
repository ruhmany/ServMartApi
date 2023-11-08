using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.DTOs.RequestOfferDTOs
{
    public class UpdateRequestOfferDTO
    {
        public string ID { get; set; }
        public decimal ExpectedSalary { get; set; }
    }
}
