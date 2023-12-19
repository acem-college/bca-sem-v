using Microsoft.AspNetCore.Mvc;
using MyMVCApp.UI.Application.Model;
using MyMVCApp.UI.Application.Model.User;
using MyMVCApp.UI.Application.Services;

namespace MyMVCApp.UI.Controllers
{
    public class UserController : Controller
    {
      
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var UserService = new UserService();
            var users = await UserService.ListsAsync(cancellationToken);
            
            return View(users);
        }
        public IActionResult Create()
        {
            var user = new SaveUserVm();
            return View(user);

        }
    }
}
