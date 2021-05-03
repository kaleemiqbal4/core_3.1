using JWT_POC.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWT_POC.Middleware.Concrete
{
    /// <summary>Jwt Contractor</summary>
    public interface IJwt
    {
        /// <summary></summary>
        /// <param name="userInfo"></param>
        /// <returns>String Token</returns>
        string GenerateJSONWebToken(UserModel userInfo);
    }
}
