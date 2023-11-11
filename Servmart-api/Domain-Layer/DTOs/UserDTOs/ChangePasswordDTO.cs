
namespace Domain_Layer.DTOs.UserDTOs
{
    public class ChangePasswordDTO
    {
        public string userID { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
