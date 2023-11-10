using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.UserDTOs;
using Domain_Layer.Models;
using InfrastructureLayer.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureLayer.Repos
{
    public class UserRepo : BaseRepos<User>, IUserRepo
    {
        private readonly AppDbContext _appContext;
        private readonly UserManager<User> _usermanager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPhotoService _photoservice;
        public UserRepo(AppDbContext appContext, UserManager<User> userManager,
            IPhotoService photoservice, IUnitOfWork unitofwork) : base(appContext)
        {
            _appContext = appContext;
            _usermanager = userManager;
            _photoservice = photoservice;
        }

        public async Task<User> ChageEmail(ChangeEmailDTO dTO)
        {
            var user = await _usermanager.FindByEmailAsync(dTO.OldEmail);
            if (user == null)
            {
                return null;

            }
            user.Email = dTO.NewEmail;
            var updateEmail = await _usermanager.UpdateAsync(user);
            return user;


        }

        public async Task<User> ChangePassword(ChangePasswordDTO changePasswordDTO)
        {
            var user = await _usermanager.FindByEmailAsync(changePasswordDTO.Email);
            if (user is null)
                return null;
            await _usermanager.ChangePasswordAsync(user, changePasswordDTO.OldPassword, changePasswordDTO.NewPassword);
            return user;

        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _appContext.Users.ToListAsync();
        }

        public async Task<User> GetUser(string userId)
           => await _appContext.Users.FirstOrDefaultAsync(y => y.Id == userId);

        public async Task<AuthModel> ChangRole(UserRoleDTO userRoleDTO)
        {
            var user = await _appContext.Users.FirstOrDefaultAsync(y => y.Id == userRoleDTO.UserId);

            foreach (var Role in userRoleDTO.Roles)
            {
                await _usermanager.AddToRoleAsync(user, Role);

            }
            return new AuthModel
            {
                Role = userRoleDTO.Roles
            };
        }

        public async Task<User> UpdateUser(UserUpdateDTO userDTO)
        {
            var user = await _usermanager.FindByEmailAsync(userDTO.Email);
            var result = await _photoservice.AddPhotoAsync(userDTO.ProfilePic);
            user.Address = userDTO.Address;
            user.UserName = userDTO.Username;
            user.FName = userDTO.FName;
            user.LName = userDTO.LName;
            user.ProfilePic = result.Url.ToString();
            await _usermanager.UpdateAsync(user);
            return user;
        }

        public async Task<IEnumerable<User>> GetAllUser()
        {
            var Users = new List<User>();

            foreach (var user in await _appContext.Users.ToListAsync())
            {
                var roles = await GetRolesAsync(user);

                if (roles.Contains("Customer"))
                {
                    Users.Add(user);
                }
            }

            return Users;
        }

        public async Task<IEnumerable<User>> GetAllservicesprov()
        {
            var Users = new List<User>();

            foreach (var user in await _appContext.Users.ToListAsync())
            {
                var roles = await GetRolesAsync(user);

                if (roles.Contains("ServiceProvider"))
                {
                    Users.Add(user);
                }
            }

            return Users;
        }

        public async Task<IEnumerable<User>> GetAllvendor()
        {
            var Users = new List<User>();

            foreach (var user in await _appContext.Users.ToListAsync())
            {
                var roles = await GetRolesAsync(user);

                if (roles.Contains("Vendor"))
                {
                    Users.Add(user);
                }
            }

            return Users;
        }

        private async Task<IList<string>> GetRolesAsync(User user)
        {
            return await _usermanager.GetRolesAsync(user);
        }
        public async Task<User> Delete(string ID)
        {
            var User = await _appContext.Users.Include(u => u.Cart).FirstOrDefaultAsync(x => x.Id == ID);
            if (User != null)
                _appContext.Cart.RemoveRange(User.Cart);
            _appContext.Users.Remove(User);
            _appContext.SaveChanges();

            return User;
        }

    }

}

