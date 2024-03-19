using ChildNutrition.Application.Interfaces;
using ChildNutrition.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ChildNutrition.Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ICommentService, CommentServices>();
        }
    }
}
