using Domain_Layer.Models;

namespace Domain_Layer.DTOs.RequestDTOS
{
	public static class RequestExtensions
	{
		public static RequestShowDTO toShowRequestDTO( this Request request )
		{
			return new RequestShowDTO()
			{
				ClientId = request.UserID,
				Title = request.Title,
				Details = request.Details,
				Category = request.Category,
				CityId = request.CityId,
				GovernorateId = request.GovernorateId,
				Address = request.Address,
				EndDate = request.EndDate,
				ExpectedSalary = request.ExpectedSalary,
				Images = request.RequestMedia.Where( x => x.MediaUrl.Contains( ".mp4" ) == false ).Select( x => x.MediaUrl ).ToList(),
				Video = request.RequestMedia.Where( x => x.MediaUrl.Contains( ".mp4" ) ).Select( x => x.MediaUrl ).FirstOrDefault()
			};
		}
	}
}
