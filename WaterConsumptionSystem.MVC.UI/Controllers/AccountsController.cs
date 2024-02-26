using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
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
                var result = await _accountService.LoginAsync(Login, cancellationToken);
                return Redirect("/");
            }
        

    }
}
