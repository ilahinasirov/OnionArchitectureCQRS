using Application.Dto;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Commands;
using Application.ViewModels.ProductViewModels;

namespace Application.Mapping
{
	public class GeneralMappingProfile:Profile
	{
        public GeneralMappingProfile()
        {
            CreateMap<Product,ProductViewDto>();
            CreateMap<Product,CreateProductCommand>();
            CreateMap<Product, GetProductByIdViewModel>();


			// Burada chevirme zamani biz chevirmeni istediyimiz shekilde heyata kechirmek uchun defolt olaraq gelen ferqli metodlardan da istifade ede bilerik 
			//Meselen
			//CreateMap<Product, ProductViewDto>().ReverseMap().ForMember();ve.s
		}
	}
}
