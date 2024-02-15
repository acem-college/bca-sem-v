using Infrastructure.Persistence;
using Mental.Application.Interfaces;
using Mental.Domain.Entities;
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
            services.AddAuthentication(IdentityConstants.ApplicationScheme)
                .AddIdentityCookies();
            services.AddAuthorization();
        }

    }
}
