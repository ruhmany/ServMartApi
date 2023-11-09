
using Domain_Layer.DTOs.RequestDTOS;

namespace Domain_Layer.DTOs.AddressDTOs
{
	public class GovernorateDTO
	{
		public string NameAr { get; set; }
		public string NameEn { get; set; }
	}

	public class GovernorateDTO2
	{
		public int Id;
		public string NameAr { get; set; }
		public string NameEn { get; set; }
		public IEnumerable<CityDTO2> CityDTOs { get; set; }
	}
}
