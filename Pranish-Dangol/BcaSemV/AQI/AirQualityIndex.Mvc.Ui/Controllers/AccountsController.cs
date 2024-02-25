using AirQualityIndex.Application.Interfaces;
using AirQualityIndex.Application.Models.Accounts;
using AirQualityIndex.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace AirQualityIndex.Mvc.Ui.Controllers
{
    public class AccountsController : Controller
    {
        private readonly IAccountService _accountService;
        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpVM signUp, CancellationToken cancellationToken)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = "/")
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
        public async Task<IActionResult> Login(LoginVM login, CancellationToken cancellationToken)
        {
            var result = await _accountService.LoginAsync(login, cancellationToken);
            return Redirect("/");
        }
    }
}
