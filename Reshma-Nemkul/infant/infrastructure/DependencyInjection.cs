using Infant.Application.Interfaces;
using Infant.Domain.Entities;
using Infant.Infrastructure.persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infant.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<InfantDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Infant"));
            });
            services.AddScoped<IInfantDbContext>(options => options.GetService<InfantDbContext>());

            //for identity
            services.AddIdentityCore<User>()
                .AddEntityFrameworkStores<InfantDbContext>()
                .AddDefaultTokenProviders();

            //adding authentication and authorization
            services.AddAuthentication(IdentityConstants.ApplicationScheme)
                .AddApplicationCookie();
            services.AddAuthorization();
        }
    }
}
