﻿using AutoMapper;
using Domain_Layer.Models;
using Sermart_Api.Helpers;

namespace Sermart_Api.Mapper
{
    public class productProfile:Profile
    {
        public productProfile()
        {
            CreateMap<Product, ProductViewModel>()
                 .ForMember(item => item.ProductName, opt => opt.MapFrom(item => item.ProductName))
                  .ForMember(item => item.Description, opt => opt.MapFrom(item => item.Description))
                   .ForMember(item => item.UnitPrice, opt => opt.MapFrom(item => item.UnitPrice))
                    .ForMember(item => item.Stoke, opt => opt.MapFrom(item => item.Stoke))
                     .ForMember(item => item.CategoryID, opt => opt.MapFrom(item => item.CategoryID))
                      .ForMember(item => item.ProviderId, opt => opt.MapFrom(item => item.ProviderId))
                .ForMember(item => item.PicsURL, opt => opt.MapFrom(item => item.ProductMedias.Select(p=>p.MeadiUrl).ToList()))
                

                .ReverseMap();
            
        }
    }
}
