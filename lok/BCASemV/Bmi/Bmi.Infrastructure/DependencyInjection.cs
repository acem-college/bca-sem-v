using Bmi.Application;
using Bmi.Application.Interface;
using Bmi.Domain.Entities;
using Bmi.Infrastructure.Persistence;
using Bmi.Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bmi.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BmiDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Bmi"));

            });
            services.AddScoped<IBmiDbContext>(provider => provider.GetService<BmiDbContext>());

            //for Identity
            services.AddIdentityCore<User>()
                .AddEntityFrameworkStores<BmiDbContext>()
                .AddApiEndpoints();

            services.AddScoped<IIdentityServices, IdentityServices>();

            //adding authentication and authorization
            services.AddAuthentication(IdentityConstants.ApplicationScheme)
                .AddCookie(optoins =>
                {
                    optoins.LoginPath = "/account/login";
                })
            .AddIdentityCookies();
            services.AddAuthorization();

            services.AddScoped<IIdentityServices, IdentityServices>();
        }


    }
}
