using AutoMapper;
using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Infrastructure.ViewModel;

namespace OnionArchitecture.Infrastructure.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerModel, Customer>()
                .ForMember(dest => dest.Id,
                        opt => opt.MapFrom(src => src.CustomerId))
                .ReverseMap();
        }
    }
}
