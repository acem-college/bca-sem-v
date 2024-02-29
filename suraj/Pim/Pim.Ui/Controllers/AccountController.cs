using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using Pim.Application.Interfaces;
using Pim.Application.Models.Accounts;

namespace Pim.Ui.Controllers
{
    public class AccountController : Controller
    {

        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpVm signUp, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _accountService.SignUpAsync(signUp, cancellationToken);
                if (result)
                    return RedirectToAction("login");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMesssage = ex.Message;
            }
            return View(signUp);
        }
		[HttpGet]
		public IActionResult logIn(string returnUrl = "/")
		{
			ViewData["ReturnUrl"] = returnUrl;
			return View();


		}
		[HttpPost]
		public async Task<IActionResult> logIn(LogInVm login, CancellationToken cancellationtoken)
		{
			try
			{
				var result = await _accountService.LogInAsync(login, cancellationtoken);
				var authProps = new AuthenticationProperties { IsPersistent = false, IssuedUtc = DateTimeOffset.UtcNow };
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
		public async Task<IActionResult> Logout(CancellationToken cancellationToken)
		{
			await HttpContext.SignOutAsync();
			return Redirect("/");
		}


	}
}

    
	
