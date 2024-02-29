using Mental.Application.Interfaces;
using Mental.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mental.Application
{
    public static  class DependencyInjections
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ICommentService, CommentService>();

        }
    }
}
