using Infrastructure.Persistence;
using Infrastructure.Services;
using Mental.Application.Interfaces;
using Mental.Domain.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MentalDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Mental"));
            });
            services.AddScoped<IMentalDbContext>(provider => provider.GetService<MentalDbContext>());

            //For Identity
            services.AddIdentityCore<User>()
                .AddEntityFrameworkStores<MentalDbContext>()
                .AddApiEndpoints();


            //adding authentication & authorization
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/accounts/Login";
                })
                .AddIdentityCookies();
            services.AddAuthorization();

            services.AddScoped<IIdentityService, IdentityService>();
        }

    }
}
