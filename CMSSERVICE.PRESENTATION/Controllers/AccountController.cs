using CMSSERVICE.APPLICATION.Persistence.Accounts;
using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses;
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

        Result<string> tokenResult = await Sender.Send(command, cancellationToken);

        if (tokenResult.IsFailure)
        {
            return HandleFailure(tokenResult);
        }

        var response = new LoginResponse
        {
            LoginStatus = true,
            ApiKey = tokenResult.Value
        };

        return Ok(response);
    }
}
