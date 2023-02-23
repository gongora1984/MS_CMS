﻿using CMSSERVICE.APPLICATION.Persistence.Accounts.Commands.LoginCommands;
using CMSSERVICE.APPLICATION.Persistence.Accounts.Commands.RegistrationCommands;
using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.Authentication;
using CMSSERVICE.PRESENTATION.Abstractions;
using Microsoft.AspNetCore.Authorization;

namespace CMSSERVICE.PRESENTATION.Controllers;

[Authorize(AuthenticationSchemes = "ApiKey")]
////[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},ApiKey")]
[Route("api/Account")]
public sealed class AccountController : ApiController
{
    public AccountController(ISender sender)
        : base(sender)
    {
    }

    [AllowAnonymous]
    [HttpPost("login")]
    public async Task<IActionResult> Login(
        [FromBody] LoginRequest request,
        CancellationToken cancellationToken)
    {
        var command = new LoginCommand(request.email, request.password);

        Result<LoginResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        var response = new LoginResponse
        {
            LoginStatus = true,
            ApiKey = result.Value.ApiKey,
            UserInformation = result.Value.UserInformation
        };

        return Ok(response);
    }

    [AllowAnonymous]
    [HttpPost("registerclient")]
    public async Task<IActionResult> RegisterClientUser(
        [FromBody] UserRequest request,
        CancellationToken cancellationToken)
    {
        var command = new RegisterClientUserCommand(request);

        Result<LoginResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        var response = new LoginResponse
        {
            LoginStatus = true,
            ApiKey = result.Value.ApiKey,
            UserInformation = result.Value.UserInformation
        };

        return Ok(response);
    }

    [AllowAnonymous]
    [HttpPost("registerlp")]
    public async Task<IActionResult> RegisterLawPracticeUser(
        [FromBody] UserRequest request,
        CancellationToken cancellationToken)
    {
        var command = new RegisterLPUserCommand(request);

        Result<LoginResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        var response = new LoginResponse
        {
            LoginStatus = true,
            ApiKey = result.Value.ApiKey,
            UserInformation = result.Value.UserInformation
        };

        return Ok(response);
    }

    [AllowAnonymous]
    [HttpPost("registerlc")]
    public async Task<IActionResult> RegisterLocalCounselUser(
        [FromBody] UserRequest request,
        CancellationToken cancellationToken)
    {
        var command = new RegisterLCUserCommand(request);

        Result<LoginResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        var response = new LoginResponse
        {
            LoginStatus = true,
            ApiKey = result.Value.ApiKey,
            UserInformation = result.Value.UserInformation
        };

        return Ok(response);
    }
}
