using Application_Layer.Interfaces;
using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.RequestDTOS;
using Domain_Layer.Models;
using InfrastructureLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureLayer.Repos
{
	public class RequsestRepo : BaseRepos<Request>, IRequestRepo
	{
		private readonly AppDbContext _appDbContext;
		private readonly IPhotoService _photoService;
		private readonly IVideoService _videoService;

		public RequsestRepo( AppDbContext appContext, IPhotoService photoService, IVideoService videoService ) : base( appContext )
		{
			_appDbContext = appContext;
			_photoService = photoService;
			_videoService = videoService;
		}

		public async Task<Request> AddRequest( RequestDTO requestDTO )
		{
			var request = new Request()
			{
				UserID = requestDTO.ClientId,
				Title = requestDTO.Title,
				Category = requestDTO.Category,
				Details = requestDTO.Details,
				ExpectedSalary = requestDTO.ExpectedSalary,
				EndDate = requestDTO.EndDate,
				GovernorateId = requestDTO.GovernorateId,
				CityId = requestDTO.CityId,
				Address = requestDTO.Address,
				StartDate = DateTime.Now,
				IsDirect = requestDTO.IsDirect,
				RateValue = 0,
				RateMassage = string.Empty
			};

			if ( requestDTO.IsDirect && !string.IsNullOrEmpty( requestDTO.ProviderID ) )
			{
				request.RequestOffer = new List<RequestOffer>()
				{
					new RequestOffer()
					{
						ProviderID = requestDTO.ProviderID,
						Details = string.Empty,
						ExpectSalary = default,
						EndDate = default
					}
				};
			}

			request.RequestMedia = new List<RequestMedia>();
			foreach ( var item in requestDTO.Images )
			{
				var imageResualt = await _photoService.AddPhotoAsync( item );
				request.RequestMedia.Add( new RequestMedia() { MediaUrl = imageResualt.Url.ToString(), RequestID = request.ID } );
			}

			var videoResualt = await _videoService.AddVideoAsync( requestDTO.Video );
			request.RequestMedia.Add( new RequestMedia() { MediaUrl = videoResualt.Url.ToString(), RequestID = request.ID } );

			var result = await _appDbContext.Request.AddAsync( request );

			return request;
		}

		public Request Delete( string id )
		{
			var request = _appDbContext.Request.FirstOrDefault( x => x.ID.ToString() == id );
			if ( request != null )
			{
				_appDbContext.Request.Remove( request );
			}
			return request;
		}

		public List<Request> FilterRequest( string UserId, decimal Price, decimal? minPrice, decimal? maxPrice )
		{
			IQueryable<Request> query = _appDbContext.Request;
			query = query.Where( r => r.UserID == UserId );
			query = query.Where( R => R.ExpectedSalary == Price );
			if ( minPrice.HasValue )
			{
				query = query.Where( r => r.ExpectedSalary >= minPrice.Value );
			}
			if ( maxPrice.HasValue )
			{
				query = query.Where( R => R.ExpectedSalary <= maxPrice.Value );
			}
			return query.ToList();
		}

		public async Task<IEnumerable<RequestShowDTO>> GetAllRequests( int page, int pageSize )
		{
			var query = _appDbContext.Request.Select( x => x.toShowRequestDTO() );
			if ( page > 0 && pageSize > 0 )
			{
				int recordsToSkip = ( page - 1 ) * pageSize;
				query = query.Skip( recordsToSkip ).Take( pageSize );
			}
			var result = await query.ToListAsync();
			return result;
		}

		public async Task<Request> GetById( string id )
		{
			return await _appDbContext.Request.FirstOrDefaultAsync( R => R.UserID == id );
		}

		public async Task<int> GetTotalRequestItems()
		{
			return await _appDbContext.Request.CountAsync();
		}

		public async Task<Request> Update( RequestUpdateDTO requestDTO )
		{
			var req = await _appDbContext.Request.FirstOrDefaultAsync( r => r.ID == requestDTO.ID );
			if ( req != null )
			{
				req.Title = requestDTO.Titles;
				req.StartDate = requestDTO.StartDate;
				req.EndDate = requestDTO.EndDate;
				req.Status = requestDTO.Status;
				req.RateMassage = requestDTO.RateMassage;
				req.UserID = requestDTO.ClientId;
				req.Details = requestDTO.Details;


				_appDbContext.Request.Update( req );
			}
			return req;
		}
	}
}
