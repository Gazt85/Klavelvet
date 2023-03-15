using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Klavelvet.Server.Configuration
{
    public class ProductTypeConfiguration : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.HasData(
                new ProductType
                {
                    Id= 1,
                    Name = "Unique Size"
                },
                new ProductType
                {
                    Id= 2,
                    Name = "Size XS"
                },
                new ProductType
                {
                    Id= 3,
                    Name = "Size S"
                },
                new ProductType
                {
                    Id= 4,
                    Name = "Size M"
                },
                new ProductType
                {
                    Id= 5,
                    Name = "Size L"
                },
                new ProductType
                {
                    Id= 6,
                    Name = "Size XL"
                },
                new ProductType
                {
                    Id= 7,
                    Name = "Size XXL"
                }
                );
        }
    }
}
