using Microsoft.AspNetCore.Mvc;
using WebApp.Application.Models.User;
using WebApp.Application.Services;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var userService = new UserService();
            var users = await userService.ListAsync(cancellationToken);
            
            return View(users);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var user = new SaveUser();
            user.Id = Guid.NewGuid();
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SaveUser saveUser, CancellationToken cancellationToken)
        {
            var userService = new UserService();
            var userVM = await userService.CreateAsync(saveUser, cancellationToken);
            var list = await userService.ListAsync(cancellationToken);
            list.Add(userVM);

            return View("index",list);
            /*return View(null);*/
            
        }
    }
}
