using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pim.Application.Interfaces;
using Pim.Domain.Entities;
using Pim.Infrastructure.Persistence;
using Pim.Infrastructure.Services;
using System.Reflection;


namespace Pim.Infrastructure
{
    //it is used to register the  services of  infrastructure..
    //scope =every request ma naya instance banauxa
    //transcent ma  chai one request one object nai hunxa  tara dui ota same name xa bhaney 2 ota naya obj hunxa
    //singletone  ley chai euta obj  banauxa entire cycle ma either there will be many or one request

    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PIMDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Pim"));

            });
            services.AddScoped<IPimDbContext>(provider => provider.GetService<PIMDbContext>());

            //for Identity
            services.AddIdentityCore<User>()
                .AddEntityFrameworkStores<PIMDbContext>()
                .AddDefaultTokenProviders();



            //adding authentication and authorization
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(optoins =>
                {
                    optoins.LoginPath = "/account/login";
                })
            .AddIdentityCookies();
            services.AddAuthorization();

            services.AddScoped<IIdentityservice, IdentityService>();
        


		}


    }
}
