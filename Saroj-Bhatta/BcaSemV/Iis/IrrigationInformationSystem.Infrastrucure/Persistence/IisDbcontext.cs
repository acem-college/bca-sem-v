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

namespace IrrigationInformationSystem.Infrastrucure.Persistence
{
    public class IisDbcontext : IdentityDbContext<Users> 
    {
        public IisDbcontext(DbContextOptions<IisDbcontext> options) : base(options){ }

    }
 
}
