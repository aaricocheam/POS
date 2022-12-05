using AutoMapper;
using POS.Application.Dtos.Provider.Response;
using POS.Domain.Entities;
using POS.Infrastructure.Commons.Bases.Response;
using POS.Utilities.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Application.Mappers
{
    public class ProviderMappingsProfile : Profile
    {
        public ProviderMappingsProfile()
        {
            CreateMap<Provider, ProviderResponseDto>()
                .ForMember(x => x.ProviderId, x => x.MapFrom(y => y.Id))
                .ForMember(x => x.DocumentType, x => x.MapFrom(y => y.DocumentType.Abbreviation))
                .ForMember(x => x.StateProvider, x => x.MapFrom(y => y.State.Equals((int)StateType.Active) ? "Activo" : "Inactivo"))
                .ReverseMap();

            CreateMap<BaseEntityResponse<Provider>, BaseEntityResponse<ProviderResponseDto>>()
                .ReverseMap();
        }
    }
}
