using Application_Layer.Helpers;
using Domain_Layer.DTOs;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
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
        public UserRepo(AppDbContext appContext, UserManager<User> userManager) : base(appContext)
        {
            _appContext = appContext;
            _usermanager = userManager;

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
            var roles = await _usermanager.GetRolesAsync(user);
            authmodel.Role = roles.ToString();
            return authmodel;
        }

        public async Task<AuthModel> RegisterAsync(RegisterModel userDTO)
        {
            if (await _usermanager.FindByEmailAsync(userDTO.Email) is not null)
                return new AuthModel { Message = "This Email Is Already Registerd" };
            if (await _usermanager.FindByNameAsync(userDTO.Username) is not null)
                return new AuthModel { Message = "This Username Is Already Registerd" };
            var user = new User
            {
                UserName = userDTO.Username,
                Email = userDTO.Email,
                FName = userDTO.FName,
                LName = userDTO.LName,
                SSN = userDTO.SSN,
                Address = userDTO.Address,
                ProfilePic = userDTO.ProfilePic,
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
            return new AuthModel
            {
                IsAuthenticated = true,
                Token = new JwtSecurityTokenHandler().WriteToken(tokens),
                Role = userDTO.Role,
                UserName = user.UserName,
                ExpiresOn = tokens.ValidTo
            };
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
            var symkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JWT.Key));
            var signingkey = new SigningCredentials(symkey, SecurityAlgorithms.HmacSha256);
            var jwttoken = new JwtSecurityToken(
                issuer: JWT.Issuer,
                audience: JWT.Audience,
                claims: claims,
                expires: DateTime.Now.AddDays(JWT.DurationInDays),
                signingCredentials: signingkey);
            return jwttoken;
        }
    }
}
