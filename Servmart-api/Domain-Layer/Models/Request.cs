using Microsoft.AspNetCore.Http;

namespace Domain_Layer.Models
{
	public class Request
	{
		public Guid ID { get; set; }
		public Guid CleintID { get; set; }
		public string Title { get; set; }
		public string Category { get; set; }
		public string Details { get; set; }
		public decimal ExpectedSalary { get; set; }
		public int Status { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public float RateValue { get; set; }
		public string RateMassage { get; set; }
		public bool IsDirect { get; set; }
		public int GovernorateId { get; set; }
		public int CityId { get; set; }
		public string Address { get; set; }

		public virtual User User { get; set; }
		public virtual RequestMedia VideoMedia { get; set; }
		public virtual ICollection<RequestMedia> ImagesMedia { get; set; }
		public virtual ICollection<RequestOffer> RequestOffer { get; set; }
		public virtual Governorate Governorate { get; set; }
		public virtual City City { get; set; }

	}
}
