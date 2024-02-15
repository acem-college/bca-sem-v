using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloth_Bank.Application.Interfaces
{
    public interface ICloth_BankDbContext
    {
        Task<int>savevChangeAsync(CancellationToken cancellationToken);
    }
}
