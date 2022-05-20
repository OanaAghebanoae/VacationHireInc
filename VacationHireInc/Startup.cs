using Microsoft.EntityFrameworkCore;
using VacationHireInc.Data;

namespace VacationHireInc.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging();
            services.AddControllers();
            services.AddCors();
            services.AddMemoryCache();
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "VacationHireInc API", Version = "v1" });
            });
            services.AddHttpClient();
            services.AddHttpContextAccessor();
            //services.AddApplicationServices();
            //services.AddApplicationRepositories();
            services.AddDbContext<VacationHireIncContext>(x => x.UseSqlServer(Configuration.GetConnectionString("Main")));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHttpContextAccessor accessor)
        {
            app.UseCors();

            if (!env.IsDevelopment())
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Vacation Hire Inc API v1"));
        }
    }
}
