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
        private readonly ICommentService _commentService;
      

        public HomeController(ILogger<HomeController> logger, ICommentService commentService)
        {
            _logger = logger;
           _commentService = commentService;
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
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ContactUs(CreateCommentVm comment, CancellationToken cancellationToken)
        {
            var response = await _commentService.CreateAsync(comment, cancellationToken);
            if (response > 0)
            {
                return RedirectToAction("index");
            }
            return View(comment);
        }





    }
}
