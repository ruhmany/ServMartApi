using Microsoft.AspNetCore.Http;

namespace Domain_Layer.DTOs.RequestDTOS
{
    public class RequestDTO
    {

        public Guid ClientId { get; set; }
        public string ProviderID { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public decimal ExpectedSalary { get; set; }
        public int Status { get; set; } = 0;
        public ICollection<IFormFile> picUrl { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string RateMassage { get; set; } = null;
        public float RateValue { get; set; } = 0;
        public bool IsDirect { get; set; } = false;


    }
}
