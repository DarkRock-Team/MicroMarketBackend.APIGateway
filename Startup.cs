using Microsoft.OpenApi.Models;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace MicroMarketBackend.APIGateway
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }
        
        private const string ApiGatewayName = "MicroMarketApiGateway";
        private const string ApiGatewayVersion = "v1";
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOcelot();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(ApiGatewayVersion, new OpenApiInfo { Title = ApiGatewayName, Version = ApiGatewayVersion });
            });
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint($"/swagger/{ApiGatewayVersion}/swagger.json", $"{ApiGatewayName} {ApiGatewayVersion}"));
            }

            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            
            app.UseOcelot().Wait();
        }
    }
}