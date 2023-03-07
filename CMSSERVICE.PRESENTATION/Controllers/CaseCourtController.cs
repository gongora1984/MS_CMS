using CMSSERVICE.APPLICATION.Persistence.CaseCourts.Commands;
using CMSSERVICE.APPLICATION.Persistence.CaseCourts.Queries;

namespace CMSSERVICE.PRESENTATION.Controllers;

[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},ApiKey")]
[Route("api/Common")]
public sealed class CaseCourtController : ApiController
{
    public CaseCourtController(ISender sender)
        : base(sender)
    {
    }

    [HttpPost("CreateCaseCourt", Name = "Create Case Court")]
    [ProducesResponseType(typeof(CaseCourtResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HasPermission("Admin")]
    public async Task<IActionResult> CreateCaseCourt(
    [FromBody] CaseCourtRequest request,
    CancellationToken cancellationToken)
    {
        var command = new RegisterCaseCourtCommand(request);

        Result<CaseCourtResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("AllCaseCourts", Name = "All Case Courts")]
    [ProducesResponseType(typeof(AllCaseCourtResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllCaseCourt(CancellationToken cancellationToken)
    {
        var command = new GetAllCaseCourtQuery();

        Result<AllCaseCourtResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("CaseCourtById", Name = "Case Court By Id")]
    [ProducesResponseType(typeof(CaseCourtResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetCaseCourtById(int id, CancellationToken cancellationToken)
    {
        var command = new GetCaseCourtByIdQuery(id);

        Result<CaseCourtResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [AllowAnonymous]
    [HttpGet("AllCaseCourtByCounty", Name = "All Case Courts by County")]
    [ProducesResponseType(typeof(AllCaseCourtResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllCaseCourtByCounty(int countyId, CancellationToken cancellationToken)
    {
        var command = new GetAllCaseCourtByDistrictQuery(countyId);

        Result<AllCaseCourtResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("AllCaseCourtByDistrict", Name = "All Case Courts by District")]
    [ProducesResponseType(typeof(AllCaseCourtResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllCaseCourtByDistrict(int districtId, CancellationToken cancellationToken)
    {
        var command = new GetAllCaseCourtByDistrictQuery(districtId);

        Result<AllCaseCourtResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("AllCaseCourtByName", Name = "All Case Courts by Name")]
    [ProducesResponseType(typeof(AllCaseCourtResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllCaseCourtByName(string name, CancellationToken cancellationToken)
    {
        var command = new GetAllCaseCourtByNameQuery(name);

        Result<AllCaseCourtResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("AllCaseCourtByType", Name = "All Case Courts by Type")]
    [ProducesResponseType(typeof(AllCaseCourtResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllCaseCourtByType(int typeId, CancellationToken cancellationToken)
    {
        var command = new GetAllCaseCourtByTypeQuery(typeId);

        Result<AllCaseCourtResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }
}
