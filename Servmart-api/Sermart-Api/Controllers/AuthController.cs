using Domain_Layer.DTOs.UserDTOs;
using ApplicationLayer.IRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sermart_Api.Controllers
{
	[Route( "api/[controller]" )]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IAuthRepo _authRepo;

		public AuthController( IAuthRepo authRepo )
		{
			_authRepo = authRepo;
		}

		[HttpPost( "register" )]
		public async Task<IActionResult> Register( [FromBody] RegisterModel model )
		{
			if ( !ModelState.IsValid )
			{
				return BadRequest( "Model state is not valid" );
			}
			var result = await _authRepo.RegisterAsync( model );
			if ( !result.IsAuthenticated )
				return BadRequest( "error while registering" + result.Message );
			return Ok( new { result.Token, result.ExpiresOn, result.Role, result.UserName, result.ProfilePic, result.Email, result.FName, result.LName, result.UserID } );
		}


		[HttpPost( "login" )]
		public async Task<IActionResult> Login( [FromBody] UserLoginDTO model )
		{
			if ( !ModelState.IsValid )
			{
				return BadRequest( ModelState );
			}
			var result = await _authRepo.LoginAsync( model );
			if ( !result.IsAuthenticated )
				return BadRequest( result.Message );
			return Ok( new { result.Token, result.ExpiresOn, result.Role, result.UserName, result.ProfilePic, result.Email, result.FName, result.LName, result.UserID } );
		}
	}
}
