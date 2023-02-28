using CMSSERVICE.APPLICATION.Persistence.LawPractices.Commands;
using CMSSERVICE.APPLICATION.Persistence.LawPractices.Queries;
using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.LawPratices;
using CMSSERVICE.INFRASTRUCTURE.Authentication;
using CMSSERVICE.PRESENTATION.Abstractions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace CMSSERVICE.PRESENTATION.Controllers;

[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},ApiKey")]
[Route("api/LawPractice")]
public sealed class LawPracticeController : ApiController
{
    public LawPracticeController(ISender sender)
        : base(sender)
    {
    }

    [HttpPost("CreateLawPractice", Name = "Create Law Practice")]
    [ProducesResponseType(typeof(LawPracticeResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HasPermission("Admin")]
    public async Task<IActionResult> CreateLawPractice(
    [FromBody] LawPracticeRequest request,
    CancellationToken cancellationToken)
    {
        var command = new RegisterLawPracticeCommand(request);

        Result<LawPracticeResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("AllLawPractice", Name = "All Law Practice")]
    [ProducesResponseType(typeof(AllLawPracticeResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllLawPractice(CancellationToken cancellationToken)
    {
        var command = new GetAllLawPracticeQuery();

        Result<AllLawPracticeResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("LawPracticeById/{id:int}", Name = "Law Practice By Id")]
    [ProducesResponseType(typeof(LawPracticeResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetLawPracticeById(int id, CancellationToken cancellationToken)
    {
        var command = new GetLawPracticeByIdQuery(id);

        Result<LawPracticeResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [AllowAnonymous]
    [HttpGet("LawPracticeByName/{name}", Name = "Law Practice By Name")]
    [ProducesResponseType(typeof(LawPracticeResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetLawPracticeByName(string name, CancellationToken cancellationToken)
    {
        var command = new GetLawPracticeByNameQuery(name);

        Result<LawPracticeResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }
}
