using AutoMapper;
using Contracts;
using Klavelvet.Server.Controllers;
using Klavelvet.Server.Repository.RepositoryManager;
using Klavelvet.Shared.Data_Transfer_Objects.Cart;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Klavelet.Tests.Cart
{
    [TestFixture]
    public class CartControllerTests
    {
        private CartController _cartController;
        private Mock<IRepositoryManager> _repositoryManagerMock;
        private Mock<IMapper> _mapperMock;
        private Mock<ILoggerService> _loggerServiceMock;

        [SetUp]
        public void Setup()
        {
            _repositoryManagerMock = new Mock<IRepositoryManager>();
            _mapperMock = new Mock<IMapper>();
            _loggerServiceMock = new Mock<ILoggerService>();

            _cartController = new CartController(
                _repositoryManagerMock.Object,
                _mapperMock.Object,
                _loggerServiceMock.Object
            );
        }

        [Test]
        public async Task GetCartProducts_WithValidCartItems_ReturnsOkResult()
        {
            // Arrange
            var cartItems = new List<CartItemForCreationDto>
            {
                new CartItemForCreationDto {
                    ProductId = Guid.NewGuid(),
                    ProductTypeId = 3,
                    Quantity = 1                    
                },
                new CartItemForCreationDto
                {
                    ProductId = new Guid(),
                    ProductTypeId = 3,
                    Quantity = 1
                }
            };

            var expectedCartProducts = new List<CartItemDto>
            {
                // Create expected cart products
                new CartItemDto 
                {
                    ProductId = Guid.NewGuid(),
                    ProductTypeId = 3
                },
                new CartItemDto 
                {
                    ProductId = Guid.NewGuid(),
                    ProductTypeId = 3
                }
            };

            _repositoryManagerMock.Setup(r => r.Cart.GetCartProducts(cartItems, false))
                .ReturnsAsync(expectedCartProducts);

            // Act
            var result = await _cartController.GetCartProducts(cartItems);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);
            var okResult = result.Result as OkObjectResult;
            Assert.AreEqual(expectedCartProducts, okResult.Value);
        }

        [Test]
        public async Task GetCartProducts_WithEmptyCartItems_ReturnsNoContentResult()
        {
            // Arrange
            var cartItems = new List<CartItemForCreationDto>();

            // Act
            var result = await _cartController.GetCartProducts(cartItems);

            // Assert
            Assert.IsInstanceOf<NoContentResult>(result.Result);
        }         


    }
}

