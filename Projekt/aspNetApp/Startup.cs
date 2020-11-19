using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspNetApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApplication9.Models;

namespace aspNetApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddTransient<IProductRepository, EFProductRepository>();
            //FakeProductRepository
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Configuration["Data:SportStoreProducts:ConnectionString"]));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDeveloperExceptionPage(); // informacje szczegó³owe o b³êdach
            app.UseStatusCodePages(); // Wyœwietla strony ze statusem b³êdu
            app.UseStaticFiles(); // obs³uga treœci statycznych css, images, js
            app.UseRouting();
            app.UseEndpoints(routes =>
            {

                routes.MapControllerRoute(
                 name: "default",
                 pattern: "{controller=Product}/{action=List}/{id?}");

                routes.MapControllerRoute(
                   name: null,
                   pattern: "Produkt/{category}",
                   defaults: new
                   {
                       controller = "Product",
                       action = "List",
                   });

                routes.MapControllerRoute(
                   name: null,
                   pattern: "Admin",
                   defaults: new
                   {
                       controller = "Admin",
                       action = "Index",
                   });

            });

            
            SeedData.EnsurePopulated(app);
        }
    }
}
