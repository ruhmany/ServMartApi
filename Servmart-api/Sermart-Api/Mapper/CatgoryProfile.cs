using AutoMapper;
using Domain_Layer.DTOs;
using Domain_Layer.Models;

namespace Sermart_Api.Mapper
{
    public class CatgoryProfile:Profile
    {
        public CatgoryProfile()
        {
            CreateMap<ProductCatgoryViewModel, ProductCategory>().ReverseMap();
        }
    }
}
