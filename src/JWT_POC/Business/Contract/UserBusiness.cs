using JWT_POC.Business.Concrete;
using System;

namespace JWT_POC.Business.Contract
{
    /// <summary>User Business</summary>
    public class UserBusiness: IUserBusiness
    {
        /// <summary>Constructor </summary>
        public UserBusiness()
        {

        }

        /// <summary>Genrate Token and return</summary>
        /// <returns>Token</returns>
        public string GetToken()
        {
            return String.Empty;
        }
    }
}
