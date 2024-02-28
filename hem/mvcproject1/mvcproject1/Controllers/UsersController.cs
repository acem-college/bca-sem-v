﻿using Microsoft.AspNetCore.Mvc;
using mvcproject1.Application.Model.User;
using mvcproject1.Application.Service;

namespace mvcproject1.Controllers
{
    public class UsersController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            ViewBag.Title = "Users - ACEM";
            var userService = new UserService();
            var users = await userService.ListAsync(cancellationToken);
            return View(users);
        }
        [HttpGet]
        public async Task<IActionResult> Detail(Guid id, CancellationToken cancellationToken)
        {
            var userService = new UserService();
            var response = await userService.GetAsync(id, cancellationToken);
            return View(response);
        }

        [HttpGet]
        [ActionName("Create")]
        public IActionResult Create()
        {
            var user = new SaveUserVM();
            user.Id = Guid.NewGuid();
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> Create(SaveUserVM saveUserVM, CancellationToken cancellationToken)
        {
            var userService = new UserService();
            await userService.CreateAsync(saveUserVM, cancellationToken);
           
            return RedirectToAction("index");
        }
    }

}
