using CMSSERVICE.APPLICATION.Persistence.Clients.Commands;
using CMSSERVICE.APPLICATION.Persistence.Clients.Queries;
using CMSSERVICE.DOMAIN.Contracts.Requests;
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

    [HttpPost("CreateClient", Name = "Create Client")]
    [ProducesResponseType(typeof(ClientResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HasPermission("Admin")]
    public async Task<IActionResult> CreateRole(
    [FromBody] ClientRequest request,
    CancellationToken cancellationToken)
    {
        var command = new RegisterClientCommand(request);

        Result<ClientResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("AllClients", Name = "All Clients")]
    [ProducesResponseType(typeof(AllClientResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllClients(CancellationToken cancellationToken)
    {
        var command = new GetAllClientQuery();

        Result<AllClientResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("ClientById", Name = "Client By Id")]
    [ProducesResponseType(typeof(ClientResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetClientById(int id, CancellationToken cancellationToken)
    {
        var command = new GetClientByIdQuery(id);

        Result<ClientResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [AllowAnonymous]
    [HttpGet("ClientByName", Name = "Client By Name")]
    [ProducesResponseType(typeof(ClientResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetClientByName(string name, CancellationToken cancellationToken)
    {
        var command = new GetClientByNameQuery(name);

        Result<ClientResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }
}
