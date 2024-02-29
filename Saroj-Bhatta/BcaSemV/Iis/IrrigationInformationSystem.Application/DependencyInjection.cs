using IrrigationInformationSystem.Application.Interfaces;
using IrrigationInformationSystem.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IrrigationInformationSystem.Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services,
            IConfiguration configuration)
        {

            services.AddScoped<IAccountService,AccountService>();
            services.AddScoped<ICommentService,CommentService>();
        }
    }
}
