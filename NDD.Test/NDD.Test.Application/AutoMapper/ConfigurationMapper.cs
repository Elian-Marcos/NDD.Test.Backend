using AutoMapper;
using NDD.Test.Application.Commands.Responses;
using NDD.Test.Application.Queries.Responses;
using NDD.Test.Domain.Entities;

namespace NDD.Test.Application.AutoMapper
{
    public class ConfigurationMapper : Profile
    {
        public ConfigurationMapper()
        {
            CreateMap<Client, FindClientResponse>().ReverseMap();
            CreateMap<Client, CreateClientResponse>().ReverseMap();
            CreateMap<Client, UpdateClientResponse>().ReverseMap();
        }
    }
}
