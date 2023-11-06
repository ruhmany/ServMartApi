using AutoMapper;
using Domain_Layer.DTOs;
using Domain_Layer.Models;
using Sermart_Api.Helpers;

namespace Sermart_Api.Mapper
{
    public class productProfile:Profile
    {
        public productProfile()
        {
            CreateMap<ProductViewModel, Product>().ReverseMap();
            
        }
    }
}
