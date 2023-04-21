using AutoMapper;
using eShopSolution.Api.Models;
using eShopSolution.Api.ViewModel;

namespace eShopSolution.Api.Mapper
{
    public class MapperConfiguration : Profile
    {
        public MapperConfiguration()
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();
        }

    }
}
