using CMSSERVICE.APPLICATION.Persistence.CaseJudges.Commands;
using CMSSERVICE.APPLICATION.Persistence.CaseJudges.Queries;

namespace CMSSERVICE.PRESENTATION.Controllers;

[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},ApiKey")]
[Route("api/CaseJudge")]
public sealed class CaseJudgeController : ApiController
{
    public CaseJudgeController(ISender sender)
        : base(sender)
    {
    }

    [HttpPost("CreateCaseJudge", Name = "Create Case Judge")]
    [ProducesResponseType(typeof(CaseJudgeResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HasPermission("Admin")]
    public async Task<IActionResult> CreateCaseJudge(
    [FromBody] CaseJudgeRequest request,
    CancellationToken cancellationToken)
    {
        var command = new RegisterCaseJudgeCommand(request);

        Result<CaseJudgeResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("CaseJudgeById", Name = "Case Judge By Id")]
    [ProducesResponseType(typeof(CaseJudgeResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetCaseJudgeById(int id, CancellationToken cancellationToken)
    {
        var command = new GetCaseJudgeById(id);

        Result<CaseJudgeResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [AllowAnonymous]
    [HttpGet("CaseJudgeByNameCourtId", Name = "Case Judge By Name and Court Id")]
    [ProducesResponseType(typeof(CaseJudgeResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetCaseJudgeByNameCourtId(string name, int courtId, CancellationToken cancellationToken)
    {
        var command = new GetByNameCourtId(name, courtId);

        Result<CaseJudgeResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [AllowAnonymous]
    [HttpGet("AllCaseJudges", Name = "All Case Judges")]
    [ProducesResponseType(typeof(AllCaseJudgeResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllCaseJudges(CancellationToken cancellationToken)
    {
        var command = new GetAllJudgeQuery();

        Result<AllCaseJudgeResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("AllCaseJudgesByName", Name = "All Case Judges by Name")]
    [ProducesResponseType(typeof(AllCaseJudgeResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllCaseJudgesByName(string name, CancellationToken cancellationToken)
    {
        var command = new GetAllJudgeByNameQuery(name);

        Result<AllCaseJudgeResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("AllCaseJudgesByCourtName", Name = "All Case Judges by Court Name")]
    [ProducesResponseType(typeof(AllCaseJudgeResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllCaseJudgesByCourtName(string courtName, CancellationToken cancellationToken)
    {
        var command = new GetAllJudgeByCourtNameQuery(courtName);

        Result<AllCaseJudgeResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("AllCaseJudgesByCourtId", Name = "All Case Judges by Court Id")]
    [ProducesResponseType(typeof(AllCaseJudgeResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllCaseJudgesByCourtId(int courtId, CancellationToken cancellationToken)
    {
        var command = new GetAllJudgeByCourtIdQuery(courtId);

        Result<AllCaseJudgeResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }
}
