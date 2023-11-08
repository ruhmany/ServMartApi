using Microsoft.AspNetCore.Identity;

namespace Domain_Layer.Models
{
	public class User : IdentityUser
	{
		//public virtual Guid ID { get; set; }
		public string FName { get; set; }
		public string LName { get; set; }
		public string SSN { get; set; }
		//public virtual string PhoneNo { get; set; }
		public string? Address { get; set; }
		public bool Gender { get; set; }
		//public virtual string Username { get; set; }
		//public virtual string Email { get; set; }pro
		//public virtual byte[] PasswordHash { get; set; }
		//public virtual byte[] PasswordSalt { get; set; }
		public string ProfilePic { get; set; }
        public int CartID { get; set; }
        public virtual Shop Shop { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual ICollection<Service> Services { get; set; }
		public virtual ICollection<RequestOffer> RequestOffer { get; set; }
		public virtual ICollection<Request> Request { get; set; }
		public virtual ICollection<Chat> Chats { get; set; }
		public virtual ICollection<Product> Products { get; set; }
	}
}
