using Autofac;
using JWT_POC.Autofac;
using JWT_POC.Registration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace JWT_POC
{
    /// <summary>StartUP class </summary>
    public class Startup
    {
        /// <summary>Start Up Class</summary>

        /// <summary></summary>
        public IConfiguration Configuration { get; }

        /// <summary> Constructor </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureServices();
            services.AddOptions();
            services.RegisterJwt(Configuration);
        }

        /// <summary></summary>
        /// <param name="builder"></param>
        public void ConfigureContainer(ContainerBuilder builder )
        {
            builder.RegisterModule(new DependencyRegister());
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Configure();
        }
    }
}

