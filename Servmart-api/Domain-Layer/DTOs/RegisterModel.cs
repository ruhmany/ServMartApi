using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Runtime.Serialization;

namespace Domain_Layer.Models
{
    public class RegisterModel
    {
        public  string Email { get; set; }
        public string Username { get; set; }
        public  string Password { get; set; }
        public  string FName { get; set; }
        public  string LName { get; set; }
        public  string phoneNumber { get; set; }
        public  string SSN { get; set; }
        public List<string> Role { get; set; }
    }
}
