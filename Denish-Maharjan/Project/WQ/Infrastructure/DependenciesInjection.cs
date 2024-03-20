using Infrastructure.Persistence;
using Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterQuality.Application.Interface;
using WaterQuality.Domain.Entities;

namespace Infrastructure
{
    public static class DependenciesInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WaterQualityDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("WQ"));
            });
            services.AddScoped<IWQDbContext>(provider => provider.GetService<IWQDbContext>());
            //For identity
            services.AddIdentityCore<User>()
                .AddEntityFrameworkStores<WaterQualityDbContext>()
                .AddDefaultTokenProviders();

            //adding authentication andauth
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
               .AddCookie(options =>
               {
                   options.LoginPath = "/account/login";
               })
               .AddIdentityCookies();
            
            services.AddAuthorization();
            services.AddScoped<IIdentityService, IdentityService>();    




            
        }
    }
}
