﻿using AutoMapper;
using POS.Application.Dtos.request;
using POS.Application.Dtos.response;
using POS.Domain.Entities;
using POS.Infrastructure.Commons.Bases.response;
using POS.Utilities.Static;

namespace POS.Application.Mappers
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category, CategoryResponseDto>()
                .ForMember(x => x.StateCategory, x => x.MapFrom(y => y.State.Equals((int)StateTypes.Active) ? "Activo" : "Inactivo"))
                .ReverseMap();
            CreateMap<BaseEntityResponse<Category>, BaseEntityResponse<CategoryResponseDto>>()
                .ReverseMap();
            CreateMap<CategoryRequestDto, Category>();
            CreateMap<Category, CategorySelectResponseDto>()
                .ReverseMap();
        }
    }
}