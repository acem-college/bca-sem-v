using Microsoft.AspNetCore.Mvc;

namespace MaternalHealthMonitoring.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        // POST version of Login to handle user credentials
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Authentication logic here

            return View();
        }
    }
}
