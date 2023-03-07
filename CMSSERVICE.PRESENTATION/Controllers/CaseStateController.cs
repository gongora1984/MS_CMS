using CMSSERVICE.APPLICATION.Persistence.CaseStates.Commands;
using CMSSERVICE.APPLICATION.Persistence.CaseStates.Queries;

namespace CMSSERVICE.PRESENTATION.Controllers;

[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},ApiKey")]
[Route("api/CaseState")]
public sealed class CaseStateController : ApiController
{
    public CaseStateController(ISender sender)
        : base(sender)
    {
    }

    #region CASE STATE METHODS

    [HttpPost("CreateCaseState", Name = "Create Case State")]
    [ProducesResponseType(typeof(CaseStateResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HasPermission("Admin")]
    public async Task<IActionResult> CreateCaseState(
    [FromBody] CaseStateRequest request,
    CancellationToken cancellationToken)
    {
        var command = new RegisterCaseStateCommand(request);

        Result<CaseStateResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("AllCaseState", Name = "All Case State")]
    [ProducesResponseType(typeof(AllCaseStateResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllCaseState(CancellationToken cancellationToken)
    {
        var command = new GetAllCaseStateQuery();

        Result<AllCaseStateResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("CaseStateById", Name = "Case State By Id")]
    [ProducesResponseType(typeof(CaseStateResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetCaseStateById(int id, CancellationToken cancellationToken)
    {
        var command = new GetCaseStateByIdQuery(id);

        Result<CaseStateResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [AllowAnonymous]
    [HttpGet("CaseStateByName", Name = "Case State By Name")]
    [ProducesResponseType(typeof(CaseStateResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetCaseStateByName(string name, CancellationToken cancellationToken)
    {
        var command = new GetCaseStateByNameQuery(name);

        Result<CaseStateResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [AllowAnonymous]
    [HttpGet("CaseStateByAbbrev", Name = "Case State By Abbrev")]
    [ProducesResponseType(typeof(CaseStateResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetCaseStateByAbbrev(string name, CancellationToken cancellationToken)
    {
        var command = new GetCaseStateByAbbrevQuery(name);

        Result<CaseStateResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    #endregion
}
