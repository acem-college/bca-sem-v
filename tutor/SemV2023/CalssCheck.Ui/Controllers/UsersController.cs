using ClassCheck.Ui.Application.Models.User;
using ClassCheck.Ui.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClassCheck.Ui.Controllers
{
    public class UsersController : Controller
    {
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var userService = new UserService();
            var users = await userService.ListAsync(cancellationToken);
            return View(users);
        }
    }
}
