using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Urutransporte.BusinessLogic;
using Urutransporte.BusinessLogic.Interface;
using Urutransporte.DataAccess;
using Urutransporte.DataAccess.Interface;
using Urutransporte.Domain;

namespace Urutransporte.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<DbContext, UrutransporteContext>(o => o.UseSqlServer(
                @"Server=localhost\SQLEXPRESS;Database=UrutransporteBD;Trusted_Connection=True;").UseLazyLoadingProxies());

            services.AddScoped<IBusinessLogic<Transporter>, TransporterLogic>();
            services.AddScoped<IRepository<Transporter>, TransporterRepository>();

            /*string path = Configuration.GetValue("ImportersPath", "");
            services.AddScoped<IFileInspector, FileInspector>(
                sp => {
                    return new FileInspector(path);
                }
            );*/
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
