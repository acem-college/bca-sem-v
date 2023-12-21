using AirQualityIndex.Mvc.Ui.Application.Models.User;
using AirQualityIndex.Mvc.Ui.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace AirQualityIndex.Mvc.Ui.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public  async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var userService = new UserServices();
            var users = await userService.ListsAsync(cancellationToken); 
            return View(users);
        }
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
            var userService = new UserServices();
            var userVM = await userService.CreateAsync(saveUserVM, cancellationToken);
            var list= await userService.ListsAsync(cancellationToken);
            list.Add(userVM);
            return View("index", list);
        }
    }
}
