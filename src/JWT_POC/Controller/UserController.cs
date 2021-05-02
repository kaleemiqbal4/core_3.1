using JWT_POC.Business.Concrete;
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

        /// <summary>Constructor of User Controller</summary>
        /// <param name="userBusiness"></param>
        /// <param name="logger"></param>
        public UserController(IUserBusiness userBusiness, ILogger<UserController> logger)
        {
            _userBusiness = userBusiness;
            _logger = logger;
        }

        /// <summary>Get All User</summary>
        /// <returns></returns>

        [HttpGet]
        public IActionResult GetUser()
        {
            _logger.LogDebug("Get All User By Id Called");
            var token = _userBusiness.GetToken();
            _logger.LogInformation("User Token is = " , token);
            return Ok("User List Returned " + token);
        }
    }
}
