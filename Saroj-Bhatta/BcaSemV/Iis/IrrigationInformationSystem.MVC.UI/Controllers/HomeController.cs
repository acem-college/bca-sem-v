using IrrigationInformationSystem.Application.Interfaces;
using IrrigationInformationSystem.Application.Models.Comment;
using IrrigationInformationSystem.Application.Services;
using IrrigationInformationSystem.MVC.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IrrigationInformationSystem.MVC.UI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICommentService _commentService;
        public HomeController(ILogger<HomeController> logger,ICommentService commentService)
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
        public async Task<IActionResult>ContactUs(CreateCommentVM comment ,CancellationToken cancellationToken)
        {
            var response = await _commentService.CreateAsync(comment, cancellationToken);
            if (response>0)
            {
                return RedirectToAction("index");
            }
            return View(comment);
        }

    }
}
   