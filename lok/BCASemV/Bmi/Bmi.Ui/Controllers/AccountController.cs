using System.Threading;
using Bmi.Application.Interface;
using Bmi.Application.Models.Accounts;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Bmi.Ui.Controllers
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
        public async Task<IActionResult> SignUp(SignUpVM signup, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _accountService.SignUpAsync(signup, cancellationToken);
                if (result)
                    return RedirectToAction("Login");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
            }
            return View(signup);
        }
        [HttpPost]
        public async Task<IActionResult> Login (LoginVM login, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _accountService.LoginAsync(login, cancellationToken);
                var authProps = new AuthenticationProperties { IsPersistent = false, IssuedUtc = DateTimeOffset.UtcNow };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, result, authProps);
               return Redirect("/");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage=ex.Message;
                
            }
            return View("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }
}
