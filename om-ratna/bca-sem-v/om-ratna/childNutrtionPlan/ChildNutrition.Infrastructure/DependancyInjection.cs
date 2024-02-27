using ChildNutrition.Application.Interfaces;
using ChildNutrition.Domain.Entities;
using ChildNutrition.Infrastructure.Persistence;
using ChildNutrition.Infrastructure.UserService;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ChildNutrition.Infrastructure
{
    public static class DependancyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ChildNutritionDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ChildNutrition"));
            });
            services.AddScoped<IChildNutritionDbContext>(provider => provider.GetService<ChildNutritionDbContext>());

            //for identity
            services.AddIdentityCore<User>()
                .AddEntityFrameworkStores<ChildNutritionDbContext>()
                .AddApiEndpoints();

            //adding authentication and authorization
            services.AddAuthentication(IdentityConstants.ApplicationScheme)
                .AddApplicationCookie();
            services.AddAuthorization();

            services.AddScoped <IIdentityService, IdentityService>();
        }
    }
}
