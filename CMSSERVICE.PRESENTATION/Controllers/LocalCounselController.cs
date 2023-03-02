using CMSSERVICE.APPLICATION.Persistence.LocalCounsels.Commands;
using CMSSERVICE.APPLICATION.Persistence.LocalCounsels.Queries;
using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.LocalCounsels;
using CMSSERVICE.INFRASTRUCTURE.Authentication;
using CMSSERVICE.PRESENTATION.Abstractions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace CMSSERVICE.PRESENTATION.Controllers;

[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},ApiKey")]
[Route("api/LocalCounsel")]
public sealed class LocalCounselController : ApiController
{
    public LocalCounselController(ISender sender)
        : base(sender)
    {
    }

    [HttpPost("CreateLocalCounsel", Name = "Create Local Counsel")]
    [ProducesResponseType(typeof(LocalCounselResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HasPermission("Admin")]
    public async Task<IActionResult> CreateLocalCounsel(
    [FromBody] LocalCounselRequest request,
    CancellationToken cancellationToken)
    {
        var command = new RegisterLocalCounselCommand(request);

        Result<LocalCounselResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("AllLocalCounsel", Name = "All Local Counsel")]
    [ProducesResponseType(typeof(AllLocalCounselResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllLocalCounsel(CancellationToken cancellationToken)
    {
        var command = new GetAllLocalCounselQuery();

        Result<AllLocalCounselResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("LocalCounselById", Name = "Local Counsel By Id")]
    [ProducesResponseType(typeof(LocalCounselResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetLocalCounselById(int id, CancellationToken cancellationToken)
    {
        var command = new GetLocalCounselByIdQuery(id);

        Result<LocalCounselResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [AllowAnonymous]
    [HttpGet("LocalCounselByName", Name = "Local Counsel By Name")]
    [ProducesResponseType(typeof(LocalCounselResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetLocalCounselByName(string name, CancellationToken cancellationToken)
    {
        var command = new GetLocalCounselByNameQuery(name);

        Result<LocalCounselResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }
}
