using Domain_Layer.DTOs.UserDTOs;
using Domain_Layer.Models;

namespace Infrastructure_Layer.IRepos
{
    public interface IAuthRepo : IBaseRepo<User>
    {
        Task<AuthModel> RegisterAsync(RegisterModel userDTO);
        Task<AuthModel> LoginAsync(UserLoginDTO loginDTO);
    }
}
