using AutoMapper;
using SupermarketExcercise.Domain.Models;
using SupermarketExcercise.Resources;


namespace SupermarketExcercise.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}
