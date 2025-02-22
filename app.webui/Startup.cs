using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using app.business.Abstract;
using app.business.Concrete;
using app.data.Abstract;
using app.data.Concrete.EfCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace app.webui
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //mvc
            // IProductRepository çağırırsam efcore olanı gelsin. mysql falanda yapabilirim. dependency injection
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();

            services.AddScoped<IProductRepository, EfCoreProductRepository>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddControllersWithViews(); // controller kullanacağımızı belirttik.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles(); // wwwroot

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "node_modules")), // node_modules açılıyor.
                RequestPath = "/modules"        // dışarıdan bu şekilde çağıracağız.        
            });

            if (env.IsDevelopment())
            {
                SeedDatabase.Seed(); //uygulama geliştirme aşamasında test verilerini yolla.
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // localhost:5000
            // localhost:5000/home
            // localhost:5000/home/index

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "products", //sadece isim. önemli değil. pattern önemli
                  pattern: "products/{category?}",
                  defaults: new { controller = "Shop", action = "list" }
              );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"  // id olmayabilir ? // varsayılan olarak Home/Index'e gidiyor.

                );
            });
        }
    }
}
