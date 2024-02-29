using Microsoft.AspNetCore.Mvc;

namespace mentalWeb.Controller
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}
