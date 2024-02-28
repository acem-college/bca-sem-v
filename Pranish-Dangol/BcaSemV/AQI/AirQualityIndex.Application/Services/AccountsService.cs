﻿using AirQualityIndex.Application.Interfaces;
using AirQualityIndex.Application.Models.Accounts;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AirQualityIndex.Application.Services
{
    public class AccountsService : IAccountService
    {
        private readonly IIdentityService _iIdentityService;
        public AccountsService(IIdentityService identityService)
        {
            _iIdentityService = identityService;
        }
        public async Task<ClaimsPrincipal> LoginAsync(LoginVM login, CancellationToken cancellationToken)
        {
            var result = await _iIdentityService.AuthenticateAsync(login, cancellationToken);
            return result;
        }

        public async Task<bool> SignUpAsync(SignUpVM signup, CancellationToken cancellationToken)
        {
            await _iIdentityService.UserSignUpAsync(signup, cancellationToken);
            return true;
        }

    }
}
