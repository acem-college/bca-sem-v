using System.Diagnostics;
using Bmi.Application.Interface;
using Bmi.Application.Models.Comment;
using Bmi.Application.Services;
using Bmi.Ui.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bmi.Ui.Controllers
{
	//[Authorize]
	[Authorize(Roles ="Admin")]
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ICommentServices _commentServices;

		public HomeController(ILogger<HomeController> logger,ICommentServices commentServices)
		{
			_logger = logger;
			_commentServices= commentServices;
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
		public IActionResult AboutUs()
		{
			return View();
		}
		[HttpPost]
		[AllowAnonymous]
        public async Task<IActionResult> AboutUs(CreateCommentVM comment, CancellationToken cancellationToken)
        {
            var response = await _commentServices.CreateAsync(comment,cancellationToken);
            if (response > 0)
                RedirectToAction("/index");

            return View(comment);

        }

    }
}
