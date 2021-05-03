using Autofac;

namespace JWT_POC.Autofac
{
    /// <summary>Resolve Dependency</summary>
    public class DependencyRegister: Module
    {
        /// <summary></summary>
        /// <param name="builder"></param>
        protected override void Load(ContainerBuilder builder)
        {
            builder.ResolveDependency();
        }
    }
}
