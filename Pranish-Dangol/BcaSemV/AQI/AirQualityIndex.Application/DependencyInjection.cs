using AirQualityIndex.Application.Interfaces;
using AirQualityIndex.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirQualityIndex.Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAccountService, AccountsService>();
            services.AddScoped<ICommentService, CommentService>();

        }
    }
}
