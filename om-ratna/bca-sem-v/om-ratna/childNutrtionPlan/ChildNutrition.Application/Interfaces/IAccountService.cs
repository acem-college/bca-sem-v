using ChildNutrition.Application.Models.Accounts;
using System.Security.Claims;

namespace ChildNutrition.Application.Interfaces
{
    public interface IAccountService
    {
        Task<ClaimsPrincipal> LogInAsync(LogInVM logIn, CancellationToken cancellationToken);
        Task<bool> SignUpAsync(SignUpVM signUp, CancellationToken cancellationToken);
    }
}
