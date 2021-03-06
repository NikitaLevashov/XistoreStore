using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using XistoreStore.Models;

namespace XistoreStore
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public IConfiguration Configuration { get; set; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<AplicationDbContext>(options => options.UseSqlServer
            //(Configuration["Data:XistoreStoreProducts:ConnectionString"]));
            services.AddDbContext<AplicationDbContext>();
            services.AddMvc();
            services.AddTransient<IProductRepository, EFProductRepository>();
            services.AddTransient<IOrderRepository, EFOrderRepository>();
            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
                app.UseStaticFiles();

                var cultureInfo = new CultureInfo("ru-RU");
                cultureInfo.NumberFormat.CurrencySymbol = "BYN";
                CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
                CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
            }

            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Product}/{action=List}/{id?}");
            });
            //app.UseMvc(routes => {

            //     routes.MapRoute(
            //        name: null,
            //        template: "{category}/Page{productPage:int}",
            //        defaults: new { controller = "Product", action = "List" }
            //    );

            //    routes.MapRoute(
            //        name: null,
            //        template: "Page{productPage:int}",
            //        defaults: new { controller = "Product", action = "List", productPage = 1 }
            //    );

            //    routes.MapRoute(
            //        name: null,
            //        template: "{category}",
            //        defaults: new { controller = "Product", action = "List", productPage = 1 }
            //    );

            //    routes.MapRoute(
            //        name: null,
            //        template: "",
            //        defaults: new { controller = "Product", action = "List", productPage = 1 });

            //    routes.MapRoute(name: null, template: "{controller}/{action}/{id?}");
            //    });

            //SeedData.EnsurePopulated(app);

        }
    }
}
