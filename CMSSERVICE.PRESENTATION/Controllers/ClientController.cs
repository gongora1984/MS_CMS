using CMSSERVICE.DOMAIN.Contracts.Responses.Clients;
using CMSSERVICE.INFRASTRUCTURE.Authentication;
using CMSSERVICE.PRESENTATION.Abstractions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace CMSSERVICE.PRESENTATION.Controllers;

[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},ApiKey")]
[Route("api/Client")]
public sealed class ClientController : ApiController
{
    public ClientController(ISender sender)
        : base(sender)
    {
    }

    [AllowAnonymous]
    [HttpGet("AllClients", Name = "All Clients")]
    [ProducesResponseType(typeof(AllClientResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HasPermission("GetAllClients")]
    public async Task<IActionResult> GetAllClients(CancellationToken cancellationToken)
    {
        ////var command = new GetAllCompaniesQuery();

        ////Result<AllCompaniesResponse> result = await Sender.Send(command, cancellationToken);

        ////return Ok(result.Value);
        await Task.FromResult(new AllClientResponse());
        return Ok("all clients");
    }
}
