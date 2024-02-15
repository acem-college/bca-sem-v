using Garbagemanagement.Application.Interfaces;
using GarbageManagement.Domain.Entities;
using GarbageManagement.Infrastructure.Persistance;
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

namespace GarbageManagement.Infrastructure
{
    //it is used to register the  services of  infrastructure..
    //scope =every request ma naya instance banauxa
    //transcent ma  chai one request one object nai hunxa  tara dui ota same name xa bhaney 2 ota naya obj hunxa
    //singletone  ley chai euta obj  banauxa entire cycle ma either there will be many or one request

    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GarbageManagementDbContext>(options =>
            {


                options.UseSqlServer(configuration.GetConnectionString("GarbageManagement"));

            });
            services.AddScoped<GarbageManagementDbContext>(provider => provider.GetService<GarbageManagementDbContext>());
            //for Identity
            services.AddIdentityCore<User>()
                .AddEntityFrameworkStores<GarbageManagementDbContext>().AddApiEndpoints();


                /*.AddDefaultTokenProviders();*/
            //Adding Authentication
            //services.AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticateScheme = JwtBearerDefaults.Authenticationscheme;
            //    options.DefaultChallengeScheme = JwtBearerDefaults.Authenticationscheme;
            //    options.DefaultScheme = JwtBearerDefaults.Authenticationscheme;
            //});
            services.AddAuthentication(IdentityConstants.ApplicationScheme).AddIdentityCookies();
            services.AddAuthorization();

        }

   
    }
}
