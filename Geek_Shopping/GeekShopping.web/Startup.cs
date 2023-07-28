using GeekShopping.web.Services;
using GeekShopping.web.Services.IServices;
using Microsoft.Extensions.DependencyInjection;

namespace GeekShopping.web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient<IProductService, ProductService>(c => c.BaseAddress = new Uri(Configuration["Services:ProductApi"]));
            services.AddControllers();

        }
        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
