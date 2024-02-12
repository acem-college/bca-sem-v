using IrrigationInformationSystem.Application.Interfaces;
using IrrigationInformationSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrrigationInformationSystem.Infrastructure.Persistence
{
    public class IisDbContext :IdentityDbContext<User>, 
        IIisDbContext
    {
        public IisDbContext(DbContextOptions<IisDbContext> options) : base(options) { }
    }
}
