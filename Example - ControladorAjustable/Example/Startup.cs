using Example.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Example
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
            services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ConexionSQL")));
//            services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("ConexionSQL")));
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddScoped<IAmigoAlmacen, SqlAmigoRepositorio>();
           // services.AddSingleton<IAmigoAlmacen, MockAmigoRepositorio>();
            //services.AddSingleton<IAmigoAlmacen, SqlAmigoRepositorio>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger <Startup> logger)
        {

            app.UseStaticFiles();
//            app.UseMvcWithDefaultRoute();
            app.UseMvc(routes => { routes.MapRoute("default", "{controller=Home}/{action=Index}/Id"); });


 /*           app.Run(async context =>
           {
               //await context.Response.WriteAsync("Hello, World!");
               await context.Response.WriteAsync("El ambiente es: "+env.EnvironmentName);
           });*/
        }

        private RequestDelegate async(object context)
        {
            throw new NotImplementedException();
        }
    }
}