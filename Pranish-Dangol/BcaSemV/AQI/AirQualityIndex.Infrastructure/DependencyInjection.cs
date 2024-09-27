using AirQualityIndex.Application.Interfaces;
using AirQualityIndex.Domain.Entities;
using AirQualityIndex.Infrastructure.Persistence;
using AirQualityIndex.Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/accounts/login";
                })
                .AddIdentityCookies();
            services.AddAuthorization();
            services.AddScoped<IIdentityService, IdentityService>();
        }
    }
}
