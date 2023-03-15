using AutoMapper;
using Klavelvet.Shared.Data_Transfer_Objects.Category;
using Klavelvet.Shared.Data_Transfer_Objects.Products;
using Klavelvet.Shared.Data_Transfer_Objects.ProductType;
using Klavelvet.Shared.Data_Transfer_Objects.ProductVariant;

namespace Klavelvet.Server
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>();

            CreateMap<Category, CategoryDto>();

            CreateMap<ProductVariant, ProductVariantDto>();

            CreateMap<ProductType, ProductTypeDto>();
        }
        
    }
}
