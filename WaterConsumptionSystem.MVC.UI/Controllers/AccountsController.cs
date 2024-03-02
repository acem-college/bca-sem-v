using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using WaterConsumptionSystem.Application.Interfaces;
using WaterConsumptionSystem.Application.Models.Accounts;
using WaterConsumptionSystem.Application.Services;

namespace WaterConsumptionSystem.MVC.UI.Controllers
{
    public class AccountsController : Controller
    {
        private readonly IAccountsServices _accountService;

        public AccountsController(IAccountsServices accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpVM SignUp, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _accountService.SignUpAsync(SignUp, cancellationToken);
                if (result)
                    return RedirectToAction("Login");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
            }
            return View(SignUp);
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = "/")

        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
        public async Task<IActionResult> Login(LoginVM Login, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _accountService.LoginAsync(Login, cancellationToken);
                var authProps = new AuthenticationProperties { IsPersistent = false, IssuedUtc = DateTimeOffset.UtcNow };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, result, authProps);

                return Redirect("/");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;

            }
            return View(Login);
        }
        [HttpGet]
        public async Task<IActionResult>LogOut(CancellationToken cancellationToken)
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}

    
