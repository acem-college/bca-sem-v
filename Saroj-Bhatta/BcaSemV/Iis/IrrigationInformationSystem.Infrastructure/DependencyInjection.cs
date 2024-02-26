﻿using IrrigationInformationSystem.Application.Interfaces;
using IrrigationInformationSystem.Domain.Entities;
using IrrigationInformationSystem.Infrastructure.Persistence;
using IrrigationInformationSystem.Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IrrigationInformationSystem.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<IisDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Iis"));
            });
            services.AddScoped<IIisDbContext>(provider => provider.GetService<IisDbContext>());

            //for identity
            services.AddIdentityCore<User>()
                .AddEntityFrameworkStores<IisDbContext>()
                .AddDefaultTokenProviders();

            //for authenticaiton
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
