using AutoMapper;
using GEOTEC.Dto;
using GEOTEC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GEOTEC.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Color, ColorDto>();
            CreateMap<Producto, ProductoDto>()
            .ForMember(dest =>
                dest.Nombre_Color,
                opt => opt.MapFrom(src => src.Color.Nombre))
            .ForMember(dest =>
                dest.Nombre_Marca,
                opt => opt.MapFrom(src => src.Marca.Nombre))
            .ForMember(dest =>
                dest.Nombre_Talle,
                opt => opt.MapFrom(src => src.Talle.Nombre))
            .ReverseMap();
            CreateMap<Marca, MarcaDto>();
            CreateMap<Talle, TalleDto>();
        }
    }
}
