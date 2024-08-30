using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace MVCBasic01
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Use this method to regester services that work with dependancie injection
            // dbcontext åæÇ Çáí íßÑíÊ ÇáÇæÈÌíÊ áãÇ ÇÍÊÇÌ ÇæÈÌíßÊ ãä Çá  CLR  ÇääÇ äÎáí Çá  
            //  åæÇ Çáí íßÑíÊ ÇáÇæÈÌíÊ æíÍÞäå ÈÇáÏÇÊÇ CLR ÝÇ áãÇ ÊíÌí Êßáã Çí ÊÇÈá ãÍÊÇÌ ÇæÈÌíßÊ ÝÇ Çá 
            //  åæÇ Çáí íßÑíÊ ÇáÇæÈÌíÊ áÇÍÙ ãÔ åíÑßíÊ æÇÍÏ ÌÏíÏ åíÓÊÎÏã äÝÓ ÇáÞÏíã CLR ÝÇ áãÇ ÇÌí Çßáã Çí ÊÇÈá ÊÇäí ãÍÊÇÌ ÇæÈÌíßÊ ÝÇ Çá 
            // one object for two table 

            // register mvc built in services to the container
            // did't support view

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure : some middelware
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // middelware (pipeline)
            // check if the route (ãÓÇÑ) that send to her is found or not
            // if found see which route is match
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // default route
                //MapGet take route name , response of route
                //browser take only get , you can't call MapPost
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                endpoints.MapGet("/hamada", async context =>
                {
                    await context.Response.WriteAsync("Hello Hamada!");
                });
                // MVC Route we make it using MapControllerRoute
                // MapControllerRoute inside it use things depend on dependancy injection
                // So we must add service in ConfigureServices that this method need (add controller)
                endpoints.MapControllerRoute(
                    name : "default", // route name
                    pattern: "{controller=Movie}/{action=Index}/{id:int?}/{name:alpha?}" //pattern of route (url path)
                                                           //URL/SEGMENT/{SEGMENT}/x{SEGMENT}
                                                           //    static  variable  mixed
                    // order of pattern is important controller-->action-->id?
                    // if id is requerd you must write it
                    //defaults : new { controller = "Movie" , action = "GetMovie"  }
                    //constraints : new {id = new IntRouteConstraint()}
                    );
            });
        }
    }
}
