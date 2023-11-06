using Domain_Layer.Models;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sermart_Api.Helpers
{
    public class ProductViewModel
    {
      
       
        [Required(ErrorMessage = "Please, Provide a valid Product Name")]
        [StringLength(50, ErrorMessage = "Must be more 5 letter", MinimumLength = 5)]
        public string ProductName { get; set; }
        [Required, StringLength(300, MinimumLength = 10)]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "Please, Provide a valid Product Price")]
        public decimal UnitPrice { get; set; }
        [Required]
        public int Stoke { get; set; }
        //[Required(ErrorMessage = "Please, Provide atleast one image")]
        //public IFormFileCollection ProductMedias { get; set; }
        //public List<string> ImagesURL { get; set; } = new List<string>();
        [Display(Name = "Choose Product Category")]
        public Guid CategoryID { get; set; }
        public string? ProviderId { get; set; } = string.Empty;


    }
}
