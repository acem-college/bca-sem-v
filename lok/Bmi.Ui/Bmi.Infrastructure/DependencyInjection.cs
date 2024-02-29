using Bmi.Domain.Entities;
using Bmi.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bmi.Infrastructure
{
	//it is used to register the  services of  infrastructure..
	//scope =every request ma naya instance banauxa
	//transcent ma  chai one request one object nai hunxa  tara dui ota same name xa bhaney 2 ota naya obj hunxa
	//singletone  ley chai euta obj  banauxa entire cycle ma either there will be many or one request

	public static class DependencyInjection
	{
		public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<BmiDbContext>(options =>
			{
				options.UseSqlServer(configuration.GetConnectionString("Bmi"));

			});
			services.AddScoped<BmiDbContext>(provider => provider.GetService<BmiDbContext>());

			//for Identity
			services.AddIdentityCore<User>()
				.AddEntityFrameworkStores<BmiDbContext>()
				.AddApiEndpoints();

			//adding authentication and authorization
			services.AddAuthentication(IdentityConstants.ApplicationScheme)
				.AddApplicationCookie();
			services.AddAuthorization();
		}


	}
}
