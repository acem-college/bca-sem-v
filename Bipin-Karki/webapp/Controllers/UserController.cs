using Microsoft.AspNetCore.Mvc;
using webapp.Application.Model.User;
using webapp.Application.Service;

namespace webapp.Controllers
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
        public async Task<IActionResult> Create()
        {
            var user = new SaveUserVM();
            user.Id = Guid.NewGuid();
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> Create(SaveUserVM saveUserVM, CancellationToken cancellationToken)
        {
            var userService = new UserService();
            var userVM =await userService.CreateAsync(saveUserVM, cancellationToken);
            var list = await userService.ListAsync(cancellationToken);
            list.Add(userVM);

            return View("index",list);
        }
    }
}
