using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterConsumptionSystem.Application.Interfaces;
using WaterConsumptionSystem.Domain.Entities;
using WaterConsumptionSystem.Infrastructure.Persistence;
using WaterConsumptionSystem.Infrastructure.Services;

namespace WaterConsumptionSystem.Infrastructure
{
    public  static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services,
    IConfiguration configuration)
        {
            services.AddDbContext<WcsDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Wcs"));
            });
            services.AddScoped<IwcsDbContext>(provider => provider.GetService<WcsDbContext>());

            //for identity
            services.AddIdentityCore<User>()
                .AddEntityFrameworkStores<WcsDbContext>()
                .AddDefaultTokenProviders();

            //for authenticaiton
            services.AddAuthentication(IdentityConstants.ApplicationScheme)
            .AddIdentityCookies();
            services.AddAuthorization();
            services.AddScoped<IIdentityService, IdentityService>();
        }
        
    }
}

