using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maternal.Domain.Entities
{
    public class User: IdentityUser
    {
public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
