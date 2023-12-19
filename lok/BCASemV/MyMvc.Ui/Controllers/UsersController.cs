using Microsoft.AspNetCore.Mvc;

namespace MyMvc.Ui.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
