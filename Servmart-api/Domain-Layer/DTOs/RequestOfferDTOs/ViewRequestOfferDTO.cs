using Domain_Layer.DTOs.RequestDTOS;

namespace Domain_Layer.DTOs.RequestOfferDTOs
{
	public class ViewRequestOfferDTO
	{
		public string ID { get; set; }
		public RequestShowDTO Request { get; set; }
		public string Details { get; set; }
		public decimal ExpectSalary { get; set; }
		public int Duration { get; set; }
		public int Status { get; set; }
		public DateTime CreatedAt { get; set; }
	}
}
