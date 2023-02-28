using CMSSERVICE.APPLICATION.Persistence.Accounts.Commands.LoginCommands;
using CMSSERVICE.APPLICATION.Persistence.Accounts.Commands.RegistrationCommands;
using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.Authentication;
using CMSSERVICE.INFRASTRUCTURE.Authentication;
using CMSSERVICE.PRESENTATION.Abstractions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace CMSSERVICE.PRESENTATION.Controllers;

////[Authorize(AuthenticationSchemes = "ApiKey")]
[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},ApiKey")]
////[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
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
            AccessToken = result.Value.AccessToken,
            UserInformation = result.Value.UserInformation
        };

        return Ok(response);
    }

    [AllowAnonymous]
    [HttpPost("loginjwt")]
    public async Task<IActionResult> LoginJwt(
        [FromBody] LoginRequest request,
        CancellationToken cancellationToken)
    {
        var command = new LoginCommandJwt(request.email, request.password);

        Result<LoginResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        var response = new LoginResponse
        {
            LoginStatus = true,
            AccessToken = result.Value.AccessToken,
            UserInformation = result.Value.UserInformation
        };

        return Ok(response);
    }

    [HttpPost("registeradmin")]
    [HasPermission("RegisterAdmin")]
    public async Task<IActionResult> RegisterAdminUser(
        [FromBody] UserRequest request,
        CancellationToken cancellationToken)
    {
        var command = new RegisterAdminUserCommand(request);

        Result<RegistrationResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        var response = new RegistrationResponse
        {
            RegistrationStatus = true,
            ////AccessToken = result.Value.AccessToken,
            UserInformation = result.Value.UserInformation
        };

        return Ok(response);
    }

    [HttpPost("registerclient")]
    [HasPermission("RegisterClient")]
    public async Task<IActionResult> RegisterClientUser(
        [FromBody] UserRequest request,
        CancellationToken cancellationToken)
    {
        var command = new RegisterClientUserCommand(request);

        Result<RegistrationResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        var response = new RegistrationResponse
        {
            RegistrationStatus = true,
            ////AccessToken = result.Value.AccessToken,
            UserInformation = result.Value.UserInformation
        };

        return Ok(response);
    }

    [HttpPost("registerlp")]
    [HasPermission("RegisterLawPractice")]
    public async Task<IActionResult> RegisterLawPracticeUser(
        [FromBody] UserRequest request,
        CancellationToken cancellationToken)
    {
        var command = new RegisterLPUserCommand(request);

        Result<RegistrationResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        var response = new RegistrationResponse
        {
            RegistrationStatus = true,
            ////AccessToken = result.Value.AccessToken,
            UserInformation = result.Value.UserInformation
        };

        return Ok(response);
    }

    [HttpPost("registerlc")]
    [HasPermission("RegisterLocalCounsel")]
    public async Task<IActionResult> RegisterLocalCounselUser(
        [FromBody] UserRequest request,
        CancellationToken cancellationToken)
    {
        var command = new RegisterLCUserCommand(request);

        Result<RegistrationResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        var response = new RegistrationResponse
        {
            RegistrationStatus = true,
            ////AccessToken = result.Value.AccessToken,
            UserInformation = result.Value.UserInformation
        };

        return Ok(response);
    }
}
