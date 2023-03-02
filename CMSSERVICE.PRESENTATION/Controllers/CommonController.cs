using CMSSERVICE.APPLICATION.Persistence.CaseCounties.Commands;
using CMSSERVICE.APPLICATION.Persistence.CaseCounties.Queries;
using CMSSERVICE.APPLICATION.Persistence.CaseStates.Commands;
using CMSSERVICE.APPLICATION.Persistence.CaseStates.Queries;

namespace CMSSERVICE.PRESENTATION.Controllers;

[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},ApiKey")]
[Route("api/Common")]
public sealed class CommonController : ApiController
{
    public CommonController(ISender sender)
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

    #region CASE COUNTY METHODS
    [HttpPost("CreateCaseCounty", Name = "Create Case County")]
    [ProducesResponseType(typeof(CaseCountyResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HasPermission("Admin")]
    public async Task<IActionResult> CreateCaseCounty(
    [FromBody] CaseCountyRequest request,
    CancellationToken cancellationToken)
    {
        var command = new RegisterCaseCountyCommand(request);

        Result<CaseCountyResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("AllCaseCounty", Name = "All Case County")]
    [ProducesResponseType(typeof(AllCaseCountyResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllCaseCounty(CancellationToken cancellationToken)
    {
        var command = new GetAllCaseCountyQuery();

        Result<AllCaseCountyResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("CaseCountyById", Name = "Case County By Id")]
    [ProducesResponseType(typeof(CaseCountyResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetCaseCountyById(int id, CancellationToken cancellationToken)
    {
        var command = new GetCaseCountyByIdQuery(id);

        Result<CaseCountyResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [AllowAnonymous]
    [HttpGet("CaseCountyByName", Name = "Case County By Name")]
    [ProducesResponseType(typeof(CaseCountyResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetCaseCountyByName(string name, CancellationToken cancellationToken)
    {
        var command = new GetCaseCountyByNameQuery(name);

        Result<CaseCountyResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    #endregion
}
