using ChildNutrition.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ChildNutrition.Infrastructure.Persistence
{
    public class ChildNutritionDbContext : IdentityDbContext<User>
    {
        public ChildNutritionDbContext(DbContextOptions<ChildNutritionDbContext> options) : base(options) { }
    }
    
}
