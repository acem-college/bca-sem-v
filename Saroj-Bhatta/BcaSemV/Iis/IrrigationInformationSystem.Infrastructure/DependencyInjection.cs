using IrrigationInformationSystem.Application.Interfaces;
using IrrigationInformationSystem.Domain.Entities;
using IrrigationInformationSystem.Infrastructure.Persistence;
using IrrigationInformationSystem.Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            services.AddAuthentication(IdentityConstants.ApplicationScheme)
            .AddIdentityCookies();
            services.AddAuthorization();
            services.AddScoped<IIdentityService ,IdentityService>();
        }
       
    }
}
