using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KaraokeDisplay.Data;
using Microsoft.AspNetCore.Mvc;
using KaraokeDisplay.Models;

namespace KaraokeDisplay
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
            //var myMaxModelBindingCollectionSize = Convert.ToInt32(
            //  Configuration["MyMaxModelBindingCollectionSize"] ?? "2000");


            //services.Configure<MvcOptions>(options =>
              //     options.MaxModelBindingCollectionSize = myMaxModelBindingCollectionSize);

            services.AddControllersWithViews();

            services.AddDbContext<KaraokeDisplayContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("KaraokeDisplayContext")));

            services.AddDbContext<RequestContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("RequestContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                //initialize data seeds
                using var serviceScope = app.ApplicationServices
                                            .GetRequiredService<IServiceScopeFactory>()
                                            .CreateScope();

                var service = serviceScope.ServiceProvider;

                SeedKaraoke.Initialize(service);
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Karaoke}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "Request",
                    pattern: "{controller=Request}/{action=Index}/{id?}");

            });
        }
    }
}
