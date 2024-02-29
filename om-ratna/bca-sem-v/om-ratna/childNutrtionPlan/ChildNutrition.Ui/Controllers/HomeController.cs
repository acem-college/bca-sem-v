using ChildNutrition.Application.Interfaces;
using ChildNutrition.Application.Models.Comments;
using ChildNutrition.Ui.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ChildNutrition.Ui.Controllers
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

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> ContactUs(CreateCommentVM command, CancellationToken cancellationToken)
        {
            var response = await _commentService.CreateAsync(command, cancellationToken);
            if (response > 0)
                return RedirectToAction("ContactUs");

            return View(command);
        }
    }
}
