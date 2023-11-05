﻿using Application_Layer.Interfaces;
using Domain_Layer.DTOs.
    s;
using Domain_Layer.DTOs.UserDTOs;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Repos
{
    public class Acountsotting : BaseRepos<User>, IAcountSitting
    {

        private readonly AppDbContext _appContext;
        private readonly UserManager<User> _usermanager;
        private readonly RoleManager<IdentityRole> _rolemanager;
        private readonly IConfiguration _config;
        private readonly IPhotoService _photoservice;
        private readonly IUnitOfWork _unitofwork;
        public Acountsotting(AppDbContext appContext, UserManager<User> userManager,
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

        public Task<User> ChageEmail(ChangeEmailDTO dTO)
        {               
        }

        public Task<User> ChangePassword(ChangePasswordDTO changePasswordDTO)
        {           
        }

        public async Task<User> UpdateRole(UserRoleDTO roleDTO)
        {
           foreach (var role in roleDTO.Roles)
            {


            }

        }

        public async Task<User> UpdateUserinfo(UserUpdateDTO userUpdateDTO)
        {
            
       
            if (await _usermanager.FindByEmailAsync(userUpdateDTO.Email) is null || await _usermanager.FindByNameAsync(userUpdateDTO.Username) is null)
             return null;
            var user = await _usermanager.FindByEmailAsync(userUpdateDTO.Email);
            var result = await _photoservice.AddPhotoAsync(userUpdateDTO.ProfilePic);
            user.Email = userUpdateDTO.Email;
            user.Address = userUpdateDTO.Address;
            user.UserName = userUpdateDTO.Username;
            user.FName = userUpdateDTO.FName;
            user.LName = userUpdateDTO.LName;
            user.ProfilePic = result.Url.ToString();
            await _usermanager.UpdateAsync(user);
            _unitofwork.CommitChanges();
            return user;
        

        }
    }
}
