using AutoMapper;
using Contracts;
using Klavelvet.Server.Controllers;
using Klavelvet.Server.Repository.RepositoryManager;
using Klavelvet.Shared.Data_Transfer_Objects.Category;
using Klavelvet.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Klavelet.Tests.Categories
{
    [TestFixture]
    public class CategoryControllerTests
    {
        private CategoryController _categoryController;
        private Mock<IRepositoryManager> _repositoryManagerMock;
        private Mock<IMapper> _mapperMock;
        private Mock<ILoggerService> _loggerServiceMock;

        [SetUp]
        public void Setup()
        {
            _repositoryManagerMock = new Mock<IRepositoryManager>();
            _mapperMock = new Mock<IMapper>();
            _loggerServiceMock = new Mock<ILoggerService>();

            _categoryController = new CategoryController(
                _repositoryManagerMock.Object,
                _mapperMock.Object,
                _loggerServiceMock.Object
            );
        }

        [Test]
        public async Task GetCategories_WhenThereAreCategoriesInTheDatabase_ShouldReturnAListOfCategories()
        {
            // Arrange
            var repositoryManager = new Mock<IRepositoryManager>();
            var mapper = new Mock<IMapper>();
            var loggerService = new Mock<ILoggerService>();

            var category1 = new Category
            {
                Id = 1,
                Name = "Category 1"
            };

            var category2 = new Category
            {
                Id = 2,
                Name = "Category 2"
            };

            var categories = new List<Category>
        {
            category1,
            category2
        };

            repositoryManager
                .Setup(x => x.Category.GetCategoriesAsync(false))
                .Returns(Task.FromResult(categories));

            mapper
                .Setup(x => x.Map<IEnumerable<CategoryDto>>(categories))
                .Returns(new List<CategoryDto>
                {
                new CategoryDto
                {
                    Id = category1.Id,
                    Name = category1.Name
                },
                new CategoryDto
                {
                    Id = category2.Id,
                    Name = category2.Name
                }
                });

            var controller = new CategoryController(repositoryManager.Object, mapper.Object, loggerService.Object);

            // Act
            var result = await controller.GetCategories();

            // Assert
            var okResult = result.Result as OkObjectResult;
            var categoriesDto = okResult.Value as List<CategoryDto>;
            Assert.That(categoriesDto, Is.Not.Null);
            Assert.That(categoriesDto.Count, Is.EqualTo(2));
            Assert.Multiple(() =>
            {
                Assert.That(categoriesDto[0].Id, Is.EqualTo(category1.Id));
                Assert.That(categoriesDto[0].Name, Is.EqualTo(category1.Name));
            });
            Assert.Multiple(() =>
            {
                Assert.That(categoriesDto[1].Id, Is.EqualTo(category2.Id));
                Assert.That(categoriesDto[1].Name, Is.EqualTo(category2.Name));
            });
        }

        [Test]
        public async Task GetCategories_WithNoCategories_ReturnsNotFoundResult()
        {
            // Arrange
            List<Category> categories = null;

            _repositoryManagerMock.Setup(r => r.Category.GetCategoriesAsync(false))
                .ReturnsAsync(categories);

            // Act
            var result = await _categoryController.GetCategories();

            // Assert
            Assert.That(result.Result, Is.InstanceOf<NotFoundResult>());
        }
      
    }
}
