using Domain_Layer.DTOs.UserDTOs;
using Domain_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.IRepos
{
    public  interface IAcountSitting
    {
        Task<User> UpdateUserinfo(UserUpdateDTO userUpdateDTO);
        Task <User> UpdateRole(UserRoleDTO roleDTO);
        Task<User> ChangePassword(ChangePasswordDTO changePasswordDTO);
        Task<User> ChageEmail(ChangeEmailDTO dTO);

    }
}
