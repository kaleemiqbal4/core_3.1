using JWT_POC.Registration;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace JWT_POC
{
    /// <summary>Service Dependencies Extension Static Class</summary>
    public static class ServiceDependencies
    {
        /// <summary></summary>
        /// <param name="services"></param>
        /// <returns>Service container</returns>
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddSwagger();
            services.AddControllers();
            services.AddRouting();
            services.AddCors();
            return services;
        }

        /// <summary></summary>
        /// <param name="app"></param>
        public static void Configure(this IApplicationBuilder app)
        {
            app.UseRouting();
            Cors(app);
            UseEndpoints(app);
            app.SwaggerPipeLine();
        }

        private static void UseEndpoints(IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private static void Cors(IApplicationBuilder app)
        {
            // global cors policy
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
        }
    }
}
