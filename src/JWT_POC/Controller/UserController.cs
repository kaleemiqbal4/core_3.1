using JWT_POC.Business.Concrete;
using JWT_POC.Middleware.Concrete;
using JWT_POC.Models.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace JWT_POC.Controller
{
    /// <summary>User Controller</summary>
    [Route("api/v1/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserBusiness _userBusiness;
        private readonly IJwt _jwt;

        /// <summary>Constructor of User Controller</summary>
        /// <param name="userBusiness"></param>
        /// <param name="jwt"></param>
        /// <param name="logger"></param>
        public UserController(IUserBusiness userBusiness, IJwt jwt, ILogger<UserController> logger)
        {
            _userBusiness = userBusiness;
            _jwt = jwt;
            _logger = logger;
        }

        /// <summary>Get All User</summary>
        /// <returns></returns>
        [HttpGet("employees/{id}/{userName}")]
        [Authorize]
        public IActionResult GetUser()
        {
            var re = Request;
            var headers = re.Headers;
            _logger.LogDebug("Get All User By Id Called");
            var token = _userBusiness.GetToken();
            _logger.LogInformation("User Token is = " , token);
            return Ok(new { authToken = token });
        }

       /// <summary></summary>
       /// <param name="user"></param>
       /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(UserModel user)
        {
            _logger.LogDebug("Get All User By Id Called");
            var token = _jwt.GenerateJSONWebToken(user);
            _logger.LogInformation("User Token is = ", token);
            return Ok(new { authToken = token });
        }
    }
}
