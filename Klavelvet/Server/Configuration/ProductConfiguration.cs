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
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum corset 1",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.",
                    ImageURL = "https://upload.wikimedia.org/wikipedia/commons/0/01/Corset1878taille46_300gram.png",
                    Price = 49.99M,
                    CategoryId = 1
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum corset 2",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.",
                    ImageURL = "/images/products/71vhl6wsxcl._ac_ul400_.jpg",
                    Price = 69.99M,
                    CategoryId = 1
                },
                 new Product
                 {
                     Id = Guid.NewGuid(),
                     Title = "Lorem ipsum corset 3",
                     Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.",
                     ImageURL = "/images/products/61+xvxreiyl._ac_ul1001_.jpg",
                     Price = 49.99M,
                     CategoryId = 1
                 },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum corset 4",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.",
                    ImageURL = "/images/products/no-photo-placeholder.png",
                    Price = 69.99M,
                    CategoryId = 1
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum lingerie 1",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.",
                    ImageURL = "/images/products/no-photo-placeholder.png",
                    Price = 19.99M,
                    CategoryId = 2
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum lingerie 2",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.",
                    ImageURL = "/images/products/no-photo-placeholder.png",
                    Price = 29.99M,
                    CategoryId = 2
                },               
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum lingerie 3",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.",
                    ImageURL = "/images/products/no-photo-placeholder.png",
                    Price = 19.99M,
                    CategoryId = 2
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum lingerie 4",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.",
                    ImageURL = "/images/products/no-photo-placeholder.png",
                    Price = 29.99M,
                    CategoryId = 2
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum bracelet 1",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.",
                    ImageURL = "/images/products/accesories/bracelet_1.png",
                    Price = 49.99M,
                    CategoryId = 3
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum bracelet 2",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.",
                    ImageURL = "/images/products/no-photo-placeholder.png",
                    Price = 69.99M,
                    CategoryId = 3
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum bracelet 3",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.",
                    ImageURL = "/images/products/no-photo-placeholder.png",
                    Price = 19.99M,
                    CategoryId = 3
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum bracelet 4",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.",
                    ImageURL = "/images/products/no-photo-placeholder.png",
                    Price = 29.99M,
                    CategoryId = 3
                }
                );
        }
    }
}
