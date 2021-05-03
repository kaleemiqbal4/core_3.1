using Autofac;
using JWT_POC.Business.Concrete;
using JWT_POC.Business.Contract;
using JWT_POC.Middleware.Concrete;
using JWT_POC.Middleware.Contract;

namespace JWT_POC.Autofac
{
    /// <summary>Autofac</summary>
    public static class Autofac
    {
        /// <summary>Register Dependency</summary>
        /// <param name="builder"></param>
        public static void ResolveDependency(this ContainerBuilder builder)
        {
            builder.RegisterType<UserBusiness>().As<IUserBusiness>();
            builder.RegisterType<Jwt>().As<IJwt>();
        }
    }
}
