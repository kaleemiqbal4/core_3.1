using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace JWT_POC.Middleware
{
    /// <summary></summary>
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;

        /// <summary></summary>
        /// <param name="next"></param>
        /// <param name="configuration"></param>
        public JwtMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;
        }
    }
}
