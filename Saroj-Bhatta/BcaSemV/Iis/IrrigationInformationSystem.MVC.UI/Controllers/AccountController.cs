using IrrigationInformationSystem.Application.Interfaces;
using IrrigationInformationSystem.Application.Models.Account;
<<<<<<< HEAD
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
=======
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
>>>>>>> a87f4f70fe29f9fc5fba85573f185ee3917da05f
using Microsoft.AspNetCore.Mvc;

namespace IrrigationInformationSystem.MVC.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
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
<<<<<<< HEAD
        [HttpPost]
        public async Task<IActionResult>Login(LogInVM login,CancellationToken cancellationToken)
=======

        [HttpPost]
        public async Task<IActionResult> Login(LogInVM login, CancellationToken cancellationToken)
>>>>>>> a87f4f70fe29f9fc5fba85573f185ee3917da05f
        {
            try
            {
                var result = await _accountService.LogInAsync(login, cancellationToken);
                var authProps = new AuthenticationProperties { IsPersistent = false, IssuedUtc = DateTimeOffset.UtcNow, ExpiresUtc = DateTimeOffset.UtcNow.AddHours(2) };
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
