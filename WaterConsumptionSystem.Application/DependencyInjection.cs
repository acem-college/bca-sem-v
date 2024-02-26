using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WaterConsumptionSystem.Application.Interfaces;
using WaterConsumptionSystem.Application.Services;

namespace WaterConsumptionSystem.Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAccountsServices,AccountService>();
        }

    }
}
