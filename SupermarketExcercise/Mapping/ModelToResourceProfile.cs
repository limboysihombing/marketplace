using AutoMapper;
using SupermarketExcercise.Domain.Models;
using SupermarketExcercise.Resources;


namespace SupermarketExcercise.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResources>();
        }
    }
}
