using AutoMapper;
using InMemoryCrud.Domain.Core.Model;

namespace InMemoryCrud.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ComputadoresDataModel, ComputadoresModel>().ReverseMap();
        }
    }
}