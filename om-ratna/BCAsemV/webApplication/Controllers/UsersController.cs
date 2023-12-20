using Microsoft.AspNetCore.Mvc;
using webApplication.Application.Model.User;
using webApplication.Application.Services;

namespace webApplication.Controllers
{
    public class UsersController : Controller
    {
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var userService = new UserService();
            var users = await userService.ListAsync(cancellationToken);
            return View(users);
        }
        public IActionResult Create()
        {
            var user=new SaveUserVM();
            return View(user);
        }
    }
}
