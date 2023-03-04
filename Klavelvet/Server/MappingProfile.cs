using AutoMapper;
using Klavelvet.Shared.Data_Transfer_Objects.Category;
using Klavelvet.Shared.Data_Transfer_Objects.Products;

namespace Klavelvet.Server
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>();

            CreateMap<Category, CategoryDto>();
        }
        
    }
}
