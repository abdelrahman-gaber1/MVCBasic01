using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Use this method to regester services that work with dependancie injection
            // dbcontext ��� ��� ����� �������� ��� ����� ������� �� ��  CLR  ���� ���� ��  
            //  ��� ��� ����� �������� ������ ������� CLR �� ��� ���� ���� �� ���� ����� ������� �� �� 
            //  ��� ��� ����� �������� ���� �� ������ ���� ���� ������� ��� ������ CLR �� ��� ��� ���� �� ���� ���� ����� ������� �� �� 
            // one object for two table 

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
            // check if the route (����) that send to her is found or not
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // default route
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
