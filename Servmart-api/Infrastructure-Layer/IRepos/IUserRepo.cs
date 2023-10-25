using Domain_Layer.DTOs;
using Domain_Layer.Models;

namespace Infrastructure_Layer.IRepos
{
    public interface IUserRepo :IBaseRepo<User>
    {
        Task<AuthModel> RegisterAsync(RegisterModel userDTO);
        Task<AuthModel> LoginAsync(UserLoginDTO loginDTO);
    }
}
