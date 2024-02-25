﻿using IrrigationInformationSystem.Application.Interfaces;
using IrrigationInformationSystem.Application.Models.Account;
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

        public async Task<IActionResult> Login(LogInVM login, CancellationToken cancellationToken)
        {
            var result = await _accountService.LogInAsync(login, cancellationToken);
            return Redirect("/");
        }
    }
}
