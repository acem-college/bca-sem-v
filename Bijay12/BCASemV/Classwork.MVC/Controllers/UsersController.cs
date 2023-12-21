using Classwork.MVC.Application.Model.User;
using Classwork.MVC.Application.Service;
using Microsoft.AspNetCore.Mvc;

namespace Classwork.MVC.Controllers
{
    public class UsersController : Controller
    {
        public async Task< IActionResult> Index(CancellationToken cancellationToken)
        {
            var userService = new UserService();
            var users = await userService.ListAsync(cancellationToken);
            /*var users = new List<ListUserVM>();*/
            return View(users);
        }
        /*public async Task<IActionResult> Create()*/
        [HttpGet]
        public IActionResult Create()
        {
            var user = new SaveUserVM();
            user.id = Guid.NewGuid();
            return View(user);
        }
        public async Task<IActionResult>Create(SaveUserVM saveUserVM, CancellationToken cancellationToken)
        {
            var userService = new UserService();
            var  userVM = await userService.CreateAsync(saveUserVM, cancellationToken);   
            var  list = await userService.ListAsync(cancellationToken);
            list.Add(userVM);
            return View ("index", list);
            /*return View(null);*/
            
        }

    }
}
