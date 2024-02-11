using IrrigationInformationSystem.Application.Interfaces;
using IrrigationInformationSystem.Domain.Entities;
using IrrigationInformationSystem.Infrastrucure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrrigationInformationSystem.Infrastructure
{
   public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration) {
            services.AddDbContext<IisDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Iis"));
            });
            services.AddScoped<IIisDbContext>(provider => provider.GetService<IisDbContext>());
          
            //for identity
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<IisDbContext>()
                .AddDefaultTokenProviders();
        }
    }
   
}
