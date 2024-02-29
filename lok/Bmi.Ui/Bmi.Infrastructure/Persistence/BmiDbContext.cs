using Bmi.Application.Interface;
using Bmi.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bmi.Infrastructure.Persistence
{
	public class BmiDbContext : IdentityDbContext<User>, IBmiDbContext
	{
		public BmiDbContext(DbContextOptions<BmiDbContext> options) : base(options) { }
	}
}
