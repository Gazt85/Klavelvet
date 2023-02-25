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
                    ImageURL = "https://example.com/image1.jpg",
                    Price = 49.99M
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum corset 2",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.",
                    ImageURL = "https://example.com/image2.jpg",
                    Price = 69.99M
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum lingerie 1",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.",
                    ImageURL = "https://example.com/image3.jpg",
                    Price = 19.99M
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum lingerie 2",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.",
                    ImageURL = "https://example.com/image4.jpg",
                    Price = 29.99M
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum corset 3",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.",
                    ImageURL = "https://example.com/image1.jpg",
                    Price = 49.99M
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum corset 4",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.",
                    ImageURL = "https://example.com/image2.jpg",
                    Price = 69.99M
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum lingerie 3",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.",
                    ImageURL = "https://example.com/image3.jpg",
                    Price = 19.99M
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum lingerie 4",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.",
                    ImageURL = "https://example.com/image4.jpg",
                    Price = 29.99M
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum corset 5",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.",
                    ImageURL = "https://example.com/image1.jpg",
                    Price = 49.99M
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum corset 6",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.",
                    ImageURL = "https://example.com/image2.jpg",
                    Price = 69.99M
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum lingerie 5",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.",
                    ImageURL = "https://example.com/image3.jpg",
                    Price = 19.99M
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum lingerie 6",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.",
                    ImageURL = "https://example.com/image4.jpg",
                    Price = 29.99M
                }
                );
        }
    }
}
