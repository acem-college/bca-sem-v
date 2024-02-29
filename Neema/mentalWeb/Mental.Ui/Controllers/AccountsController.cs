using Mental.Application.Interfaces;
using Mental.Application.Models.Accounts;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace Mental.Ui.Controllers
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
            try
            {
                var result = await _accountService.SignUpAsync(signUp, cancellationToken);
                if (result)
                    return RedirectToAction("login");
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
            try
            {
                var result = await _accountService.LoginAsync(login, cancellationToken);
                var authProps = new AuthenticationProperties { IsPersistent = false, IssuedUtc = DateTimeOffset.UtcNow, ExpiresUtc=DateTimeOffset.UtcNow.
                    AddHours(2)};
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, result, authProps);
                return Redirect("/");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
            }
            return View(login);
        }

        [HttpGet]
        public async Task<IActionResult> LogOut(CancellationToken cancellationToken)
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");

        }
    }
}
