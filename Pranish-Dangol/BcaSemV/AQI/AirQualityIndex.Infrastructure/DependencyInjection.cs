using AirQualityIndex.Application.Interfaces;
using AirQualityIndex.Domain.Entities;
using AirQualityIndex.Infrastructure.Persistence;
using AirQualityIndex.Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirQualityIndex.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<AqiDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Aqi"));
            });
            services.AddScoped<IAqiDbContext>(provider => provider.GetService<AqiDbContext>());

            //for identity
            services.AddIdentityCore<User>()
                .AddEntityFrameworkStores<AqiDbContext>()
                .AddApiEndpoints();

            //adding authentication and authorization
            services.AddAuthentication(IdentityConstants.ApplicationScheme)
                .AddIdentityCookies();
            services.AddAuthorization();
            services.AddScoped<IIdentityService, IdentityService>();
        }
    }
}
