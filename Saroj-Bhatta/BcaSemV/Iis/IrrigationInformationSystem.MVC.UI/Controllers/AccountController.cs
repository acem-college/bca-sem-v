using IrrigationInformationSystem.Application.Interfaces;
using IrrigationInformationSystem.Application.Models.Account;
using IrrigationInformationSystem.Application.Services;
using IrrigationInformationSystem.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
            return View();
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = "/")
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
        public async Task<IActionResult>Login(LogInVM login,CancellationToken cancellationToken)
        {
            var result= await _accountService.LogInAsync(login,cancellationToken);
            return Redirect("/");
        }
    }
}
