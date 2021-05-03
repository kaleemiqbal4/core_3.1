using JWT_POC.Business.Concrete;
using JWT_POC.Controller;
using JWT_POC.Middleware.Concrete;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace Test.Controller
{
    /// <summary>UserTest Controller Class</summary>
    public class UserTestController
    {
        private readonly UserController _subject;
        private readonly Mock<IUserBusiness> _mockUserBusiness;
        private readonly Mock<IJwt> _mockJwt;
        private readonly Mock<ILogger<UserController>> _logger;
        public UserTestController()
        {
            _mockUserBusiness = new Mock<IUserBusiness>();
            _mockJwt = new Mock<IJwt>();
            _logger = new Mock<ILogger<UserController>>();
            _subject = new UserController(_mockUserBusiness.Object, _mockJwt.Object, _logger.Object);
        }

        [Fact]
        public void GetUser()
        {
            // Arrange
            string token = "abcdef";
            _mockUserBusiness.Setup(b => b.GetToken()).Returns(token);

            // Act
            var result = _subject.GetUser();

            // Assert
            _mockUserBusiness.Verify();
            Assert.NotNull(result);
        }
    }
}
