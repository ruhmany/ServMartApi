﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.DTOs
{
    public class UserUpdateDTO
    {
        public string Username { get; set; }
        public string ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string SSN { get; set; }
        public string PhoneNo { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public IFormFile ProfilePic { get; set; }
    }
}
