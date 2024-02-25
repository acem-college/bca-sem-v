using IrrigationInformationSystem.Application.Interfaces;
using IrrigationInformationSystem.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrrigationInformationSystem.Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services,
            IConfiguration configuration)
        {

            services.AddScoped<IAccountService,AccountService>();
        }
    }
}
