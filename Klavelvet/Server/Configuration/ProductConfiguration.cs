using Klavelvet.Shared.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Klavelvet.Server.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = new Guid("A1DA89C8-9D11-4808-AEC3-E25A3117D29C"),
                    Title = "Lorem ipsum corset 1",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.",
                    ImageURL = "https://upload.wikimedia.org/wikipedia/commons/0/01/Corset1878taille46_300gram.png",                    
                    CategoryId = 1,
                    Featured = true
                },
                new Product
                {
                    Id = new Guid("FEC703B8-D206-408F-ADE9-0B0C338EA98B"),
                    Title = "Lorem ipsum corset 2",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.",
                    ImageURL = "/images/products/71vhl6wsxcl._ac_ul400_.jpg",
                    CategoryId = 1
                },
                 new Product
                 {
                     Id = new Guid("7D5A1144-D392-49D5-BE2E-D926F553901F"),
                     Title = "Lorem ipsum corset 3",
                     Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.",
                     ImageURL = "/images/products/61+xvxreiyl._ac_ul1001_.jpg",
                     CategoryId = 1
                 },
                new Product
                {
                    Id = new Guid("6A063E94-37A5-4019-BE3D-664DD453AFA9"),
                    Title = "Lorem ipsum corset 4",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.",
                    ImageURL = "/images/products/no-photo-placeholder.png",
                    CategoryId = 1
                },
                new Product
                {
                    Id = new Guid("9FD60B55-AB68-46BB-A683-9DCF766C5612"),
                    Title = "Lorem ipsum dress 1",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.",
                    ImageURL = "/images/products/dresses/dress_1.jpg",
                    CategoryId = 2,
                    Featured = true
                },
                new Product
                {
                    Id = new Guid("D9433EBC-3715-4157-8EDC-25E3502527E2"),
                    Title = "Lorem ipsum dress 2",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.",
                    ImageURL = "/images/products/dresses/dress_2.jpg",
                    CategoryId = 2
                },               
                new Product
                {
                    Id = new Guid("DF5B6339-E65B-488F-B837-B7434445CE54"),
                    Title = "Lorem ipsum dress 3",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.",
                    ImageURL = "/images/products/dresses/dress_3.jpg",
                    CategoryId = 2
                },
                new Product
                {
                    Id = new Guid("9A9F0ACA-829A-49BA-834F-FB7C67BB3F14"),
                    Title = "Lorem ipsum dress 4",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.",
                    ImageURL = "/images/products/dresses/dress_4.jpg",
                    CategoryId = 2
                },
                new Product
                {
                    Id = new Guid("5CC1A1E7-8F22-42CD-B62E-22DDB1554772"),
                    Title = "Lorem ipsum bracelet 1",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.",
                    ImageURL = "/images/products/accesories/bracelet_1.png",
                    CategoryId = 3,
                    Featured = true
                },
                new Product
                {
                    Id = new Guid("640F3165-8940-4768-82C9-9629873CB1A9"),
                    Title = "Lorem ipsum bracelet 2",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.",
                    ImageURL = "/images/products/no-photo-placeholder.png",
                    CategoryId = 3
                },
                new Product
                {
                    Id = new Guid("843B31FA-E860-4CA9-9B74-42CFF6AC4BC7"),
                    Title = "Lorem ipsum bracelet 3",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.",
                    ImageURL = "/images/products/no-photo-placeholder.png",
                    CategoryId = 3
                },
                new Product
                {
                    Id = new Guid("3B9B19A7-3D59-499C-8D1B-94FA1B1CF8A8"),
                    Title = "Lorem ipsum bracelet 4",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.",
                    ImageURL = "/images/products/no-photo-placeholder.png",
                    CategoryId = 3
                }
                );
        }
    }
}
