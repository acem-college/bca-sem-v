using Cloth_Bank.Domain.Entities;
using Cloth_Bank.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloth_Bank.Infrastructure
{
    //Scope = every request ma a new instance is created
    //Transit = simlar to scope but yesma 2 ota object with same name xa vanya it is treated as new object
    //singletone le euta obj banauxa entire cucle ma either there will be many or one req
    public static class DependencyInjection
    {
        public static void AddInfrastruture(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Cloth_BankDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Cloth_Bank"));
            });
            services.AddScoped<Cloth_BankDbContext>(provider => provider.GetService<Cloth_BankDbContext>());

            //For Identity
            services.AddIdentityCore<User>()
            .AddEntityFrameworkStores<Cloth_BankDbContext>()
            .AddApiEndpoints();

            //adding authentication & authorization
            services.AddAuthentication(IdentityConstants.ApplicationScheme)
                .AddIdentityCookies();
            services.AddAuthorization();


            //Adding Authentication
            //services.AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticationScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultChallengeScheme = JwtBearerDefults.AuthenticationsScheme;
            //    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            //});
        }  
        
    }
}
