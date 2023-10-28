using Application_Layer.Interfaces;
using Domain_Layer.DTOs;
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
        private readonly RoleManager<IdentityRole> _rolemanager;
        private readonly IConfiguration _config;
        private readonly IPhotoService _photoservice;
        private readonly IUnitOfWork _unitofwork;
        public UserRepo(AppDbContext appContext, UserManager<User> userManager,
            RoleManager<IdentityRole> rolemanager, IConfiguration config, 
            IPhotoService photoservice, IUnitOfWork unitofwork) : base(appContext)
        {
            _appContext = appContext;
            _usermanager = userManager;
            _rolemanager = rolemanager;
            _config = config;
            _photoservice = photoservice;
            _unitofwork = unitofwork;
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

        public async Task<User> GetUser(string userId)
           => await _appContext.Users.FirstOrDefaultAsync(y => y.Id==userId);

        public async Task<AuthModel> LoginAsync(UserLoginDTO loginDTO)
        {
            var authmodel = new AuthModel();

            var user = await _usermanager.FindByEmailAsync(loginDTO.Email);
            if(user == null || !await _usermanager.CheckPasswordAsync(user, loginDTO.Password))
            {
                authmodel.Message = "Email or Password is incorrect";
                return authmodel;
            }

            var token = await CreateToken(user);
            authmodel.IsAuthenticated = true;
            authmodel.Token = new JwtSecurityTokenHandler().WriteToken(token);
            authmodel.UserName = user.UserName;
            authmodel.Email = user.Email;
            authmodel.ExpiresOn = token.ValidTo;
            var roles = await _usermanager.GetRolesAsync(user);
            authmodel.Role = roles.ToString();
            return authmodel;
        }

        public async Task<AuthModel> RegisterAsync(RegisterModel userDTO)
        {
            if (await _usermanager.FindByEmailAsync(userDTO.Email) != null)
                return new AuthModel { Message = "This Email Is Already Registerd" };
            if (await _usermanager.FindByNameAsync(userDTO.Username) != null)
                return new AuthModel { Message = "This Username Is Already Registerd" };
            if(!await _rolemanager.RoleExistsAsync(userDTO.Role))
            {
                return new AuthModel { Message = "there is no role with this name" };
            }
            var user = new User
            {
                UserName = userDTO.Username,
                Email = userDTO.Email,
                FName = userDTO.FName,
                LName = userDTO.LName,
                SSN = userDTO.SSN,
                Address = "Hello world",
                PhoneNumber = userDTO.phoneNumber
            };
            var result = await _usermanager.CreateAsync(user, userDTO.Password);
            if (!result.Succeeded)
            {
                var erorr = string.Empty;
                foreach (var err in result.Errors)
                {
                    erorr += $"{err.Description},";
                }
                return new AuthModel { Message = erorr };
            }
            await _usermanager.AddToRoleAsync(user, userDTO.Role);
            var tokens = await CreateToken(user);
            _unitofwork.CommitChanges();
            return new AuthModel
            {
                IsAuthenticated = true,
                Token = new JwtSecurityTokenHandler().WriteToken(tokens),
                Role = userDTO.Role,
                UserName = user.UserName,
                ExpiresOn = tokens.ValidTo
            };
        }

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

        private async Task<JwtSecurityToken> CreateToken(User user)
        {
            var userclaims = await _usermanager.GetClaimsAsync(user);
            var roles = await _usermanager.GetRolesAsync(user);
            var roleclaim = new List<Claim>();
            foreach (var role in roles)
            {
                roleclaim.Add(new Claim("roles",role));
            }
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("UserID", user.Id)
            }
            .Union(userclaims)
            .Union(roleclaim);
            var symkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:Key"]));
            var signingkey = new SigningCredentials(symkey, SecurityAlgorithms.HmacSha256);
            var jwttoken = new JwtSecurityToken(
                issuer: _config["JWT:Issuer"],
                audience: _config["JWT:Audience"],
                claims: claims,
                expires: DateTime.Now.AddDays(double.Parse(_config["JWT:DurationInDays"])),
                signingCredentials: signingkey);
            return jwttoken;
        }
    }
}
