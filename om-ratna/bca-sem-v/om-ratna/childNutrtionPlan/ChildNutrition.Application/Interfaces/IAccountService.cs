using ChildNutrition.Application.Models.Accounts;

namespace ChildNutrition.Application.Interfaces
{
    public interface IAccountService
    {
        Task<bool> LogInAsync(LogInVM logIn, CancellationToken cancellationToken);
        Task<bool> SignUpAsync(SignUpVM signUp, CancellationToken cancellationToken);
    }
}
