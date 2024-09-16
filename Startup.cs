using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstController
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();   // MVC  // Dependency Injection ...

            // services.AddRazorPages();        
            // services.AddControllers();   // Web API
            // services.AddMvc();           // [Mix 3 Project]
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseStaticFiles();    //Get Static Files (Resources) [CSS - JS - Images] 

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                /*
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });*/
                endpoints.MapGet("/Index", async context =>
                {
                    await context.Response.WriteAsync("Hello Route!");
                });
                endpoints.MapControllerRoute(
                    name: "Pattern1" ,
                    pattern : "{Controller=Home}/{Action=Index}/{Id:int?}");  // Id Is Optional Integer ..
            });
        }
    }
}
