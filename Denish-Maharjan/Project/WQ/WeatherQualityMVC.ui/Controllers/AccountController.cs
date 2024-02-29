using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using WaterQuality.Application.Interface;
using WaterQualityMVC.ui.Controllers.Accounts;

namespace WaterQualityMVC.ui.Controllers
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
        public async Task<IActionResult>SignUp(SignUpVm signUp, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _accountService.SignUpAsync(signUp, cancellationToken);
                if(result)
                    return RedirectToAction("LogIn");
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
        public async Task<IActionResult>login(LogInVm logIn,CancellationToken cancellationToken)
        {
            try
            {

                var result = await _accountService.LogInAsync(logIn, cancellationToken);
                var authProps = new AuthenticationProperties { IsPersistent = false, IssuedUtc = DateTimeOffset.UtcNow, ExpiresUtc = DateTimeOffset.UtcNow.AddHours(2) };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, result, authProps);
                return Redirect("/");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
            }
            return View(logIn);

        }
        [HttpGet]

        public async Task<IActionResult> LogOut(CancellationToken cancellationToken)
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}
