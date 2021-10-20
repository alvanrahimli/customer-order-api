using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerOrderApi.Application;
using CustomerOrderApi.Infrastructure.Data;
using CustomerOrderApi.Infrastructure.UnitOfWork.Abstract;
using CustomerOrderApi.Infrastructure.UnitOfWork.Concrete;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CustomerOrderApi.Api
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(_configuration.GetConnectionString("Default"));
            });
            
            services.AddMediatR(typeof(ApplicationLayerClass).Assembly);

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}