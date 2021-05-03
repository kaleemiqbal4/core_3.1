using Autofac;
using JWT_POC.Business.Concrete;
using JWT_POC.Business.Contract;

namespace JWT_POC.Autofac
{
    /// <summary>Resolve Dependency</summary>
    public class DependencyRegister: Module
    {
        /// <summary></summary>
        /// <param name="builder"></param>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserBusiness>().As<IUserBusiness>();
        }
    }
}
