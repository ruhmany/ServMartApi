using Domain_Layer.DTOs.UserDTOs;
using Domain_Layer.Models;

namespace ApplicationLayer.IRepos
{
    public interface IUserRepo :IBaseRepo<User>
    {
        Task<User> UpdateUser(UserUpdateDTO user);
        Task<User> ChangePassword(ChangePasswordDTO changePasswordDTO);
        Task<User> ChageEmail(ChangeEmailDTO dTO);
        Task<IEnumerable<User>> GetAllUsers();
        Task<AuthModel> ChangRole(UserRoleDTO userRoleDTO);
        Task<IEnumerable<User>> GetAllUser();
        Task<IEnumerable<User>> GetAllvendor();
        Task<User> Delete(string ID);

        Task<IEnumerable<User>> GetAllservicesprov();

    }
}
