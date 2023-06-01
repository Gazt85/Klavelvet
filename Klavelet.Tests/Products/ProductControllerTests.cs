using AutoMapper;
using Contracts;
using Klavelvet.Client.Shared;
using Klavelvet.Server.Controllers;
using Klavelvet.Server.Repository;
using Klavelvet.Server.Repository.RepositoryManager;
using Klavelvet.Shared.Data_Transfer_Objects.Products;
using Klavelvet.Shared.Models;
using Klavelvet.Shared.RequestFeatures;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavelet.Tests.Products
{
    [TestFixture]
    public class ProductControllerTests
    {
        private ProductController _productController;
        private Mock<IRepositoryManager> _repositoryManagerMock;
        private Mock<IMapper> _mapperMock;
        private Mock<ILoggerService> _loggerServiceMock;

        [SetUp]
        public void Setup()
        {
            _repositoryManagerMock = new Mock<IRepositoryManager>();
            _mapperMock = new Mock<IMapper>();
            _loggerServiceMock = new Mock<ILoggerService>();

            _productController = new ProductController(
                _repositoryManagerMock.Object,
                _mapperMock.Object,
                _loggerServiceMock.Object
            );
        }



        [Test]
        public async Task GetProducts_WithExistingProducts_ReturnsOkResult()
        {
            // Arrange
            var productParameters = new ProductParameters();
            var productsList = new List<Product>
            {
                new Product { Id = Guid.NewGuid(), Title = "Product 1" },
                new Product { Id = Guid.NewGuid(), Title = "Product 2" }
            };

            var products = new PagedList<Product>(productsList, productsList.Count,
                productParameters.PageNumber, productParameters.PageSize);

            var expectedProductsDto = new List<ProductDto>
            {
                new ProductDto { Id = Guid.NewGuid(), Title = "Product 1" },
                new ProductDto { Id = Guid.NewGuid(), Title = "Product 2" }
            };

            _repositoryManagerMock.Setup(r => r.Product.GetProductsAsync(productParameters, false))
                .ReturnsAsync(products);

            _mapperMock.Setup(m => m.Map<IEnumerable<ProductDto>>(products))
                .Returns(expectedProductsDto);

            // Act
            var result = await _productController.GetProducts(productParameters);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);
            var okResult = result.Result as OkObjectResult;
            Assert.IsAssignableFrom<List<ProductDto>>(okResult.Value);
            var productsDto = okResult.Value as List<ProductDto>;

            CollectionAssert.AreEqual(expectedProductsDto, productsDto.ToList());
        }

        [Test]
        public async Task GetProducts_WithNoProducts_ReturnsNotFoundResult()
        {
            // Arrange
            var productParameters = new ProductParameters();
            PagedList<Product> products = null;

            _repositoryManagerMock.Setup(r => r.Product.GetProductsAsync(productParameters, false))
                .ReturnsAsync(products);

            // Act
            var result = await _productController.GetProducts(productParameters);

            // Assert
            Assert.IsInstanceOf<NotFoundResult>(result.Result);
        }

        [Test]
        public async Task GetProductsByCategory_WithExistingCategoryAndProducts_ReturnsOkResult()
        {
            // Arrange
            var productParameters = new ProductParameters();
            var categoryUrl = "category-url";
            var category = new Category { Id = 1, Name = "Category 1" };
            var productsList = new List<Product>
            {
                new Product { Id = Guid.NewGuid(), Title = "Product 1" },
                new Product { Id = Guid.NewGuid(), Title = "Product 2" }
            };

            var products = new PagedList<Product>(productsList, productsList.Count,
                productParameters.PageNumber, productParameters.PageSize);

            var expectedProductsDto = new List<ProductDto>
            {
                new ProductDto { Id = Guid.NewGuid(), Title = "Product 1" },
                new ProductDto { Id = Guid.NewGuid(), Title = "Product 2" }
            };

            _repositoryManagerMock.Setup(r => r.Category.GetCategoryByUrl(categoryUrl, false))
                .ReturnsAsync(category);

            _repositoryManagerMock.Setup(r => r.Product.GetProductsByCategoryAsync(productParameters, categoryUrl, false))
                .ReturnsAsync(products);

            _mapperMock.Setup(m => m.Map<IEnumerable<ProductDto>>(products))
                .Returns(expectedProductsDto);

            // Act
            var result = await _productController.GetProductsByCategory(productParameters, categoryUrl);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);
            var okResult = result.Result as OkObjectResult;
            Assert.IsAssignableFrom<List<ProductDto>>(okResult.Value);
            var productsDto = okResult.Value as List<ProductDto>;

            CollectionAssert.AreEqual(expectedProductsDto, productsDto);
        }

        [Test]
        public async Task GetProductsByCategory_WithNonExistingCategory_ReturnsNotFoundResult()
        {
            // Arrange
            var productParameters = new ProductParameters();
            var categoryUrl = "non-existing-category";

            _repositoryManagerMock.Setup(r => r.Category.GetCategoryByUrl(categoryUrl, false))
                .ReturnsAsync((Category)null);

            // Act
            var result = await _productController.GetProductsByCategory(productParameters, categoryUrl);

            // Assert
            Assert.IsInstanceOf<NotFoundResult>(result.Result);
        }

        [Test]
        public async Task GetProductsByCategory_WithNoProducts_ReturnsNotFoundResult()
        {
            // Arrange
            var productParameters = new ProductParameters();
            var categoryUrl = "category-url";
            var category = new Category { Id = 1, Name = "Category 1" };
            PagedList<Product> products = null;

            _repositoryManagerMock.Setup(r => r.Category.GetCategoryByUrl(categoryUrl, false))
                .ReturnsAsync(category);

            _repositoryManagerMock.Setup(r => r.Product.GetProductsByCategoryAsync(productParameters, categoryUrl, false))
            .ReturnsAsync(products);

            // Act
            var result = await _productController.GetProductsByCategory(productParameters, categoryUrl);

            // Assert
            Assert.IsInstanceOf<NotFoundResult>(result.Result);

        }

        [Test]
        public async Task GetFeaturedProducts_WithFeaturedProducts_ReturnsOkResult()
        {
            // Arrange
            var productParameters = new ProductParameters();
            var productsList = new List<Product>
            {
                new Product { Id = Guid.NewGuid(), Title = "Product 1" },
                new Product { Id = Guid.NewGuid(), Title = "Product 2" }
            };
            var featuredProducts = new PagedList<Product>(productsList, productsList.Count,
                productParameters.PageNumber, productParameters.PageSize);

            var expectedProductsDto = new List<ProductDto>
            {
                new ProductDto { Id = Guid.NewGuid(), Title = "Product 1" },
                new ProductDto { Id = Guid.NewGuid(), Title = "Product 2" }
            };

            _repositoryManagerMock.Setup(r => r.Product.GetFeaturedProductsAsync(productParameters, false))
                .ReturnsAsync(featuredProducts);

            _mapperMock.Setup(m => m.Map<IEnumerable<ProductDto>>(featuredProducts))
                .Returns(expectedProductsDto);

            // Act
            var result = await _productController.GetFeaturedProducts(productParameters);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);
            var okResult = result.Result as OkObjectResult;
            Assert.IsAssignableFrom<List<ProductDto>>(okResult.Value);
            var productsDto = okResult.Value as List<ProductDto>;

            CollectionAssert.AreEqual(expectedProductsDto, productsDto);
        }

        [Test]
        public async Task GetFeaturedProducts_WithNoFeaturedProducts_ReturnsNotFoundResult()
        {
            // Arrange
            var productParameters = new ProductParameters();
            PagedList<Product> featuredProducts = null;

            _repositoryManagerMock.Setup(r => r.Product.GetFeaturedProductsAsync(productParameters, false))
                .ReturnsAsync(featuredProducts);

            // Act
            var result = await _productController.GetFeaturedProducts(productParameters);

            // Assert
            Assert.IsInstanceOf<NotFoundResult>(result.Result);
        }

        [Test]
        public async Task SearchProducts_WithMatchingProducts_ReturnsOkResult()
        {
            // Arrange
            var productParameters = new ProductParameters();
            var searchText = "example";
            var productsList = new List<Product>
            {
                new Product { Id = Guid.NewGuid(), Title = "Example Product 1" },
                new Product { Id = Guid.NewGuid(), Title = "Example Product 2" }
            };

            var products = new PagedList<Product>(productsList, productsList.Count,
                productParameters.PageNumber, productParameters.PageSize);

            var expectedProductsDto = new List<ProductDto>
            {
                new ProductDto { Id = Guid.NewGuid(), Title = "Example Product 1" },
                new ProductDto { Id = Guid.NewGuid(), Title = "Example Product 2" }
            };

            _repositoryManagerMock.Setup(r => r.Product.SearchProducts(productParameters, searchText, false))
                .ReturnsAsync(products);

            _mapperMock.Setup(m => m.Map<IEnumerable<ProductDto>>(products))
                .Returns(expectedProductsDto);

            // Act
            var result = await _productController.SearchProducts(productParameters, searchText);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);
            var okResult = result.Result as OkObjectResult;
            Assert.IsAssignableFrom<List<ProductDto>>(okResult.Value);
            var productsDto = okResult.Value as List<ProductDto>;

            CollectionAssert.AreEqual(expectedProductsDto, productsDto);
        }

        [Test]
        public async Task SearchProducts_WithNoMatchingProducts_ReturnsNotFoundResult()
        {
            // Arrange
            var productParameters = new ProductParameters();
            var searchText = "example";
            PagedList<Product> products = null;

            _repositoryManagerMock.Setup(r => r.Product.SearchProducts(productParameters, searchText, false))
                .ReturnsAsync(products);

            // Act
            var result = await _productController.SearchProducts(productParameters, searchText);

            // Assert
            Assert.IsInstanceOf<NotFoundResult>(result.Result);
        }

        [Test]
        public async Task SearchProductsWithSuggestions_WithMatchingSuggestions_ReturnsOkResult()
        {
            // Arrange
            var productParameters = new ProductParameters();
            var searchText = "example";
            var productsList = new List<Product>
            {
                new Product { Id = Guid.NewGuid(), Title = "Example Product 1" },
                new Product { Id = Guid.NewGuid(), Title = "Example Product 2" }
            };

            var suggestions = new List<string>
            {
                "Example Product 1",
                "Example Product 2"
            };
           
            _repositoryManagerMock.Setup(r => r.Product.SearchProductsWithSuggestions(searchText, false))
                .ReturnsAsync(suggestions);

            // Act
            var result = await _productController.SearchProductsWithSuggestions(searchText);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);
            var okResult = result.Result as OkObjectResult;
            Assert.IsAssignableFrom<List<string>>(okResult.Value);
            var suggestionsDto = okResult.Value as List<string>;
            CollectionAssert.AreEqual(suggestions, suggestionsDto);
        }

        [Test]
        public async Task GetProduct_WithExistingProductId_ReturnsOkResult()
        {
            // Arrange
            var productId = new Guid("6a063e94-37a5-4019-be3d-664dd453afa9");
            var product = new Product { Id = productId, Title = "Example Product" };
            var expectedProductDto = new ProductDto { Id = productId, Title = "Example Product" };

            _repositoryManagerMock.Setup(r => r.Product.GetProductAsync(productId, false))
                .ReturnsAsync(product);

            _mapperMock.Setup(m => m.Map<ProductDto>(product))
                .Returns(expectedProductDto);

            // Act
            var result = await _productController.GetProduct(productId);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);
            var okResult = result.Result as OkObjectResult;
            Assert.IsAssignableFrom<ProductDto>(okResult.Value);
            var productDto = okResult.Value as ProductDto;

            Assert.AreEqual(expectedProductDto, productDto);
        }

        [Test]
        public async Task GetProduct_WithNonExistingProductId_ReturnsNotFoundResult()
        {
            // Arrange
            var productId = Guid.NewGuid();
            Product product = null;

            _repositoryManagerMock.Setup(r => r.Product.GetProductAsync(productId, false))
                .ReturnsAsync(product);

            // Act
            var result = await _productController.GetProduct(productId);

            // Assert
            Assert.IsInstanceOf<NotFoundResult>(result.Result);
        }
    }
}
