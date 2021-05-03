using System;

namespace JWT_POC.Models.Request
{
    /// <summary>User Model</summary>
    public class UserModel
    {
        /// <summary>User Name</summary>
        public string UserName {get;set;}

        /// <summary>User Password</summary>
        public string Password { get; set; }

        /// <summary>Email Address</summary>
        public string EmailAddress { get; set; }

        /// <summary></summary>
        public DateTime DateOfJoing { get; set; }
    }
}
