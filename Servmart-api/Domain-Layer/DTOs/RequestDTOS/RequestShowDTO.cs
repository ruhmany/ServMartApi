using Microsoft.AspNetCore.Http;


namespace Domain_Layer.DTOs.RequestDTOS
{
	public class RequestShowDTO
	{
		public string ClientId { get; set; }
		public string Title { get; set; }
		public string Category { get; set; }
		public int GovernorateId { get; set; }
		public int CityId { get; set; }
		public string Address { get; set; }
		public string Details { get; set; }
		public decimal ExpectedSalary { get; set; }
		public IEnumerable<string> Images { get; set; }
		public string Video { get; set; }
		public DateTime EndDate { get; set; }
	}
}
