﻿using ChildNutrition.Application.Interfaces;
using ChildNutrition.Application.Models.Accounts;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace ChildNutrition.Ui.Controllers
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
        public async Task<IActionResult> SignUp(SignUpVM SignUp, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _accountService.SignUpAsync(SignUp, cancellationToken);
                if (result)
                {
                    return RedirectToAction("login");
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
            }
            return View(SignUp);

        }
        

        [HttpPost]
        public IActionResult Login(string returnUrl ="/")
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LogInVM logIn, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _accountService.LogInAsync(logIn, cancellationToken);
                var authProps = new AuthenticationProperties { IsPersistent = false, IssuedUtc = DateTimeOffset.UtcNow, 
                    ExpiresUtc = DateTimeOffset.UtcNow.AddHours(2) };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, result, authProps);
                return Redirect("/");
            }

            catch (Exception ex)
            {

                ViewBag.ErrorMessage = ex.Message;
            }
            return View(logIn);
        }
        
       /* [HttpGet]
        public async Task<IActionResult> LogOut(LogInVM logIn ,CancellationToken cancellationToken)
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");

        }*/
    }
}
