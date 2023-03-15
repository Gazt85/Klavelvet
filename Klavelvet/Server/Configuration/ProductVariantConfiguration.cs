using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Klavelvet.Server.Configuration
{
    public class ProductVariantConfiguration : IEntityTypeConfiguration<ProductVariant>
    {
        public void Configure(EntityTypeBuilder<ProductVariant> builder)
        {
            builder.HasData(
                new ProductVariant
                {
                    ProductId = new Guid("FEC703B8-D206-408F-ADE9-0B0C338EA98B"),
                    ProductTypeId = 2,
                    Price = 49.99M,
                    OriginalPrice = 59.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("FEC703B8-D206-408F-ADE9-0B0C338EA98B"),
                    ProductTypeId = 3,
                    Price = 49.99M,
                    OriginalPrice = 59.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("FEC703B8-D206-408F-ADE9-0B0C338EA98B"),
                    ProductTypeId = 4,
                    Price = 49.99M,
                    OriginalPrice = 59.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("FEC703B8-D206-408F-ADE9-0B0C338EA98B"),
                    ProductTypeId = 5,
                    Price = 9.99M,
                    OriginalPrice = 59.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("FEC703B8-D206-408F-ADE9-0B0C338EA98B"),
                    ProductTypeId = 6,
                    Price = 49.99M,
                    OriginalPrice = 59.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("7D5A1144-D392-49D5-BE2E-D926F553901F"),
                    ProductTypeId = 2,
                    Price = 59.99M,
                    OriginalPrice = 59.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("7D5A1144-D392-49D5-BE2E-D926F553901F"),
                    ProductTypeId = 4,
                    Price = 79.99M,
                    OriginalPrice = 59.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("7D5A1144-D392-49D5-BE2E-D926F553901F"),
                    ProductTypeId = 5,
                    Price = 59.99M,
                    OriginalPrice = 59.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("7D5A1144-D392-49D5-BE2E-D926F553901F"),
                    ProductTypeId = 6,
                    Price = 59.99M,
                    OriginalPrice = 59.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("5CC1A1E7-8F22-42CD-B62E-22DDB1554772"),
                    ProductTypeId = 1,
                    Price = 49.99M,
                    OriginalPrice = 59.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("D9433EBC-3715-4157-8EDC-25E3502527E2"),
                    ProductTypeId = 2,
                    Price = 49.99M,
                    OriginalPrice = 59.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("D9433EBC-3715-4157-8EDC-25E3502527E2"),
                    ProductTypeId = 3,
                    Price = 49.99M,
                    OriginalPrice = 59.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("D9433EBC-3715-4157-8EDC-25E3502527E2"),
                    ProductTypeId = 4,
                    Price = 49.99M,
                    OriginalPrice = 59.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("D9433EBC-3715-4157-8EDC-25E3502527E2"),
                    ProductTypeId = 5,
                    Price = 49.99M,
                    OriginalPrice = 59.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("843B31FA-E860-4CA9-9B74-42CFF6AC4BC7"),
                    ProductTypeId = 1,
                    Price = 29.99M,
                    OriginalPrice = 29.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("6A063E94-37A5-4019-BE3D-664DD453AFA9"),
                    ProductTypeId = 3,
                    Price = 29.99M,
                    OriginalPrice = 49.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("6A063E94-37A5-4019-BE3D-664DD453AFA9"),
                    ProductTypeId = 4,
                    Price = 29.99M,
                    OriginalPrice = 49.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("6A063E94-37A5-4019-BE3D-664DD453AFA9"),
                    ProductTypeId = 5,
                    Price = 29.99M,
                    OriginalPrice = 49.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("3B9B19A7-3D59-499C-8D1B-94FA1B1CF8A8"),
                    ProductTypeId = 1,
                    Price = 29.99M,
                    OriginalPrice = 39.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("640F3165-8940-4768-82C9-9629873CB1A9"),
                    ProductTypeId = 1,
                    Price = 29.99M,
                    OriginalPrice = 39.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("9FD60B55-AB68-46BB-A683-9DCF766C5612"),
                    ProductTypeId = 2,
                    Price = 69.99M,
                    OriginalPrice = 69.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("9FD60B55-AB68-46BB-A683-9DCF766C5612"),
                    ProductTypeId = 3,
                    Price = 69.99M,
                    OriginalPrice = 69.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("9FD60B55-AB68-46BB-A683-9DCF766C5612"),
                    ProductTypeId = 4,
                    Price = 69.99M,
                    OriginalPrice = 69.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("9FD60B55-AB68-46BB-A683-9DCF766C5612"),
                    ProductTypeId = 5,
                    Price = 69.99M,
                    OriginalPrice = 79.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("9FD60B55-AB68-46BB-A683-9DCF766C5612"),
                    ProductTypeId = 6,
                    Price = 69.99M,
                    OriginalPrice = 79.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("DF5B6339-E65B-488F-B837-B7434445CE54"),
                    ProductTypeId = 3,
                    Price = 69.99M,
                    OriginalPrice = 79.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("DF5B6339-E65B-488F-B837-B7434445CE54"),
                    ProductTypeId = 6,
                    Price = 79.99M,
                    OriginalPrice = 79.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("A1DA89C8-9D11-4808-AEC3-E25A3117D29C"),
                    ProductTypeId = 3,
                    Price = 79.99M,
                    OriginalPrice = 79.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("A1DA89C8-9D11-4808-AEC3-E25A3117D29C"),
                    ProductTypeId = 4,
                    Price = 89.99M,
                    OriginalPrice = 79.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("A1DA89C8-9D11-4808-AEC3-E25A3117D29C"),
                    ProductTypeId = 5,
                    Price = 89.99M,
                    OriginalPrice = 79.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("A1DA89C8-9D11-4808-AEC3-E25A3117D29C"),
                    ProductTypeId = 6,
                    Price = 69.99M,
                    OriginalPrice = 79.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("A1DA89C8-9D11-4808-AEC3-E25A3117D29C"),
                    ProductTypeId = 7,
                    Price = 79.99M,
                    OriginalPrice = 79.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("9A9F0ACA-829A-49BA-834F-FB7C67BB3F14"),
                    ProductTypeId = 2,
                    Price = 49.99M,
                    OriginalPrice = 79.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("9A9F0ACA-829A-49BA-834F-FB7C67BB3F14"),
                    ProductTypeId = 3,
                    Price = 49.99M,
                    OriginalPrice = 79.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("9A9F0ACA-829A-49BA-834F-FB7C67BB3F14"),
                    ProductTypeId = 4,
                    Price = 49.99M,
                    OriginalPrice = 79.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("9A9F0ACA-829A-49BA-834F-FB7C67BB3F14"),
                    ProductTypeId = 5,
                    Price = 49.99M,
                    OriginalPrice = 79.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("9A9F0ACA-829A-49BA-834F-FB7C67BB3F14"),
                    ProductTypeId = 6,
                    Price = 49.99M,
                    OriginalPrice = 79.99M,
                },
                new ProductVariant
                {
                    ProductId = new Guid("9A9F0ACA-829A-49BA-834F-FB7C67BB3F14"),
                    ProductTypeId = 7,
                    Price = 49.99M,
                    OriginalPrice = 79.99M,
                }
                );
        }
    }
}
