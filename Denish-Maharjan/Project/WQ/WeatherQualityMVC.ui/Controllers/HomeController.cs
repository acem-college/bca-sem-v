using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WaterQuality.Application.Interface;
using WaterQuality.Application.Models.Comment;
using WaterQualityMVC.ui.Controllers.Accounts;
using WaterQualityMVC.ui.Models;

namespace WeatherQualityMVC.ui.Controllers
{
    //[Authorize]
    [Authorize(Roles ="Admin")]
    public class HomeController : Controller
        
    {
       
        private readonly ILogger<HomeController> _logger;
        
      

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
           
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [AllowAnonymous]
        public IActionResult ContactUs()
        { 
            return View(); 
        }   
        





    }
}
