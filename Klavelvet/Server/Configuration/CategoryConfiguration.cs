using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Klavelvet.Server.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Corsets",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    Url = "corsets"
                },
                 new Category
                 {
                     Id = 2,
                     Name = "Lingerie",
                     Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                     Url = "lingerie"
                 },
                  new Category
                  {
                      Id = 3,
                      Name = "Accesories",
                      Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                      Url = "accesories"
                  }
                );
        }
    }
}
