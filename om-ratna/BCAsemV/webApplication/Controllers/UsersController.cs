using Microsoft.AspNetCore.Mvc;
using webApplication.Application.Model.User;
using webApplication.Application.Services;

namespace webApplication.Controllers
{
    public class UsersController : Controller
    {
        public dynamic GetViewBag()
        {
            return ViewBag;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var userService = new UserService();
            var users = await userService.ListAsync(cancellationToken);
            return View(users);
        }
        [HttpGet]
        public async Task<IActionResult> Detail(Guid id, CancellationToken cancellationToken)
        {
            var userService = new UserService();
            var response = await userService.GetAsync(id, cancellationToken);
            return View(response);
        }


        [HttpGet]
        [ActionName("Create")]
        public IActionResult Create()
        {
            var user=new SaveUserVM();
            user.Id = Guid.NewGuid();
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> Create(SaveUserVM saveUserVM, CancellationToken cancellationToken)
        {
            var userService=new UserService();
            await userService.CreateAsync(saveUserVM, cancellationToken);
            return RedirectToAction("index");
        }
        [HttpGet]
        [ActionName("Edit")]
        public async Task<IActionResult> Edit(Guid id, CancellationToken cancellationToken)
        {
            var userService = new UserService();
            var response = await userService.GetAsync(id, cancellationToken);
            return View(response);
        }
        [HttpPost]
        public async Task<IActionResult> Submit(SaveUserVM saveUserVM, CancellationToken cancellationToken)
        {
            var userService = new UserService();
            await userService.CreateAsync(saveUserVM, cancellationToken);
            return RedirectToAction("index");
        }
    }
}
