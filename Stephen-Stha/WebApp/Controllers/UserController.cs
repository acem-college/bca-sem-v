using LifeOnLand.Application.Models.User;
using LifeOnLand.Service;
using Microsoft.AspNetCore.Mvc;

namespace LifeOnLand.Controllers
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


        //[Route("new")] // [HttpGet("new")]
        [HttpGet]
        public IActionResult Create()
        {
            var user = new SaveUserVM();
            user.Id = Guid.NewGuid();
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SaveUserVM saveUserVM, CancellationToken cancellationToken)
        {
            var userService = new UserService();
            var userVM = await userService.CreateAsync(saveUserVM, cancellationToken);
            var list = await userService.ListAsync(cancellationToken);
            list.Add(userVM);
            return View("index", list);
        }
    }
}