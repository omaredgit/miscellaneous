using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using miscellaneous.Controllers;
using miscellaneous.Models;
using miscellaneous.Services.UserService;
using miscellaneous.testApi.Fixtures;
using Moq;

namespace miscellaneous.testApi.Controllers
{
    public class TestUserController
    {
        [Fact]
        public async Task Get_OnSuccess_ReturnsStatusCode200()
        {
            //Arrange
            var mockService = new Mock<IUserService>();
            mockService.Setup(service => service.GetAll()).ReturnsAsync(UserFixture.GetAllUsers());
            var sut = new UserController(mockService.Object);

            //Act
            var result = (OkObjectResult)await sut.Get();

            //Assert
            result.StatusCode.Should().Be(200);

        }

        [Fact]
        public async Task Get_OnSuccess_InvocationIUserServiceExactlyOnce()
        {
            //Arrange
            var mockService = new Mock<IUserService>();
            mockService.Setup(service => service.GetAll()).ReturnsAsync(UserFixture.GetAllUsers());
            var sut = new UserController(mockService.Object);

            //Act
            var result = await sut.Get();

            //Assert
            mockService.Verify(
                service => service.GetAll(),
                Times.Once());

        }


        [Fact]
        public async Task Get_OnSuccess_InvocationIUserServiceGetListOfUSers()
        {
            //Arrange
            var mockService = new Mock<IUserService>();
            mockService.Setup(service => service.GetAll()).ReturnsAsync(UserFixture.GetAllUsers());
            var sut = new UserController(mockService.Object);

            //Act
            var result = await sut.Get();

            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objectResult = (OkObjectResult)result;
            objectResult.Value.Should().BeOfType<List<User>>();

        }


        [Fact]
        public async Task Get_OnNoUserFound_returns404()
        {
            //Arrange
            var mockService = new Mock<IUserService>();
            mockService.Setup(service => service.GetAll()).ReturnsAsync(new List<User>());
            var sut = new UserController(mockService.Object);

            //Act
            var result = await sut.Get();

            //Assert
            result.Should().BeOfType<NotFoundResult>();
            var objectResult = (NotFoundResult)result;
            objectResult.StatusCode.Should().Be(404);
        }

    }
}
