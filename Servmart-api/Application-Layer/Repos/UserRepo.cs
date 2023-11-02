using Application_Layer.Interfaces;
using Domain_Layer.DTOs.UserDTOs;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Application_Layer.Repos
{
    public class UserRepo : BaseRepos<User>, IUserRepo
    {
        private readonly AppDbContext _appContext;
        private readonly UserManager<User> _usermanager;        
        private readonly IConfiguration _config;
        private readonly IPhotoService _photoservice;
        private readonly IUnitOfWork _unitofwork;
        public UserRepo(AppDbContext appContext, UserManager<User> userManager, IConfiguration config, 
            IPhotoService photoservice, IUnitOfWork unitofwork) : base(appContext)
        {
            _appContext = appContext;
            _usermanager = userManager;
            _config = config;
            _photoservice = photoservice;
            _unitofwork = unitofwork;
        }

        public async Task<User> ChageEmail(ChangeEmailDTO dTO)
        {
            var user = await _usermanager.FindByEmailAsync(dTO.OldEmail);
            if(user != null)
            {

            }
            return user;                
        }

        public async Task<User> ChangePassword(ChangePasswordDTO changePasswordDTO)
        {
            var user = await _usermanager.FindByEmailAsync(changePasswordDTO.Email);
            if (user is null)
                return null;
            await _usermanager.ChangePasswordAsync(user, changePasswordDTO.OldPassword, changePasswordDTO.NewPassword);
            _unitofwork.CommitChanges();
            return user;

        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _appContext.Users.ToListAsync();
        }

        public async Task<User> GetUser(string userId)
           => await _appContext.Users.FirstOrDefaultAsync(y => y.Id==userId);

        public async Task<User> UpdateUser(UserUpdateDTO userDTO)
        {
            if (await _usermanager.FindByEmailAsync(userDTO.Email) is null || await _usermanager.FindByNameAsync(userDTO.Username) is null)
             return null;
            var user = await _usermanager.FindByEmailAsync(userDTO.Email);
            var result = await _photoservice.AddPhotoAsync(userDTO.ProfilePic);
            user.Email = userDTO.Email;
            user.Address = userDTO.Address;
            user.UserName = userDTO.Username;
            user.FName = userDTO.FName;
            user.LName = userDTO.LName;
            user.ProfilePic = result.Url.ToString();
            await _usermanager.UpdateAsync(user);
            _unitofwork.CommitChanges();
            return user;
        }


    }
}
