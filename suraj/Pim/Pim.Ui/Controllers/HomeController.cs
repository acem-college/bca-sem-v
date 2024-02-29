using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pim.Application.Interfaces;
using Pim.Application.Models.Comment;
using Pim.Application.Services;
using Pim.Ui.Models;
using System.Diagnostics;

namespace Pim.Ui.Controllers
{


    // [Authorize]
    [Authorize(Roles ="Admin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
		private readonly ICommentServices _commentService;

		public HomeController(ILogger<HomeController> logger, ICommentServices commentService)
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
