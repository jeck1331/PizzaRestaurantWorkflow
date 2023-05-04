using AutoMapper;
using Pizzeria.Models;
using Pizzeria.Models.DTO;
using Pizzeria.Models.Enums;
using Pizzeria.Services;

namespace Pizzeria.Mapping;

public class WorkflowProfile : Profile
{
    public WorkflowProfile()
    {
        CreateMap<Client, ClientDTO>();

        CreateMap<Courier, CourierDTO>()
            .ForMember(src => src.State, o => o.MapFrom(dest => StateConvertor.CourierState(dest.State ?? CourierState.Free)))
            .ReverseMap()
            .ForMember(src => src.ProductId, o => o.Ignore());

        CreateMap<Product, ProductDTO>()
            .ForMember(src => src.State, o => o.MapFrom(dest => StateConvertor.ProductState(dest.ProductState ?? ProductState.Accept)))
            .ForMember(src => src.CleintId, o => o.MapFrom(dest => dest.ClientId))
            .ForMember(src => src.CourierId, o => o.MapFrom(dest => dest.CourierId))
            .ForMember(src => src.ClientName, o => o.MapFrom(dest => dest.Client != null ? dest.Client.Name : null))
            .ForMember(src => src.CourierName, o => o.MapFrom(dest => dest.Courier != null ? dest.Courier.Name : null))
            .ReverseMap()
            .ForMember(src => src.ProductState, o => o.Ignore())
            .ForMember(src => src.ClientId, o => o.Ignore())
            .ForMember(src => src.CourierId, o => o.Ignore());
    }
}