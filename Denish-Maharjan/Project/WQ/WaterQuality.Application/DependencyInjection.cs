using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterQuality.Application.Interface;
using WaterQuality.Application.Services;

namespace WaterQuality.Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services, IConfiguration configuration ) 
        {
            services.AddScoped<IAccountService, AccountService>();     
            services.AddScoped<IReportService, ReportService>();
        }
    }
}
