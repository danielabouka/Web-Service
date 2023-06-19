using Microsoft.EntityFrameworkCore;
using WebService.DataAccess;

namespace WebService
{
    public class Startup
    {

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<PostgreSqlContext>(options
                => options.UseNpgsql(Configuration["PostgreSqlConnectionString"]));
            services.AddScoped<IDataAccessProvider, DataAccessProvider>();
        }

        //This method gets called by the runtime.
        //Use this method to configure the HTTP request pipeline

        public void Configure (IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }

    }
}
