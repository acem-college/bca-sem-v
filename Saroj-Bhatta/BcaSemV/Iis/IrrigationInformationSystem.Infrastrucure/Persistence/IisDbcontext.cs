using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using IrrigationInformationSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using IrrigationInformationSystem.Application.Interfaces;

namespace IrrigationInformationSystem.Infrastrucure.Persistence
{
    public class IisDbContext : IdentityDbContext<User>, 
        IIisDbContext
    {
        public IisDbContext(DbContextOptions<IisDbContext> options) : base(options){ }

    }
 
}
