using CMSSERVICE.APPLICATION.Persistence.CaseCounties.Commands;
using CMSSERVICE.APPLICATION.Persistence.CaseCounties.Queries;

namespace CMSSERVICE.PRESENTATION.Controllers;

[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},ApiKey")]
[Route("api/CaseCounty")]
public sealed class CaseCountyController : ApiController
{
    public CaseCountyController(ISender sender)
        : base(sender)
    {
    }

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
