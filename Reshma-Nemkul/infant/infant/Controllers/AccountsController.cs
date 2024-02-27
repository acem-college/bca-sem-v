using Infant.Application.Interfaces;
using Infant.Application.Models.Account;
using Infant.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Infant.Controllers
{
    public class AccountsController : Controller
    {
        private readonly IAccountServices _accountService;
        public AccountsController(IAccountServices accountService)
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
            try
            {
                var result = await _accountService.SignUpAsync(signUp, cancellationToken);
                if (result)
                    return RedirectToAction("Login");
            }
            catch (Exception ex)
            {
                    ViewBag.ErrorMessage = ex.Message;
            }
            return View(signUp);
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = "/")
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM login, CancellationToken cancellationToken)
        {
            var result = await _accountService.LoginAsync(login, cancellationToken);
            return Redirect("/");

        }
    }
}

