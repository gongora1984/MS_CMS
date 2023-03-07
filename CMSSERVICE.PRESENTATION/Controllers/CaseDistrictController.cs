using CMSSERVICE.APPLICATION.Persistence.CaseDistricts.Commands;
using CMSSERVICE.APPLICATION.Persistence.CaseDistricts.Queries;

namespace CMSSERVICE.PRESENTATION.Controllers;

[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},ApiKey")]
[Route("api/CaseDistrict")]
public sealed class CaseDistrictController : ApiController
{
    public CaseDistrictController(ISender sender)
        : base(sender)
    {
    }

    #region CASE DISTRICT METHODS
    [HttpPost("CreateCaseDistrict", Name = "Create Case District")]
    [ProducesResponseType(typeof(CaseDistrictResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HasPermission("Admin")]
    public async Task<IActionResult> CreateCaseDistrict(
    [FromBody] CaseDistrictRequest request,
    CancellationToken cancellationToken)
    {
        var command = new RegisterCaseDistrictCommand(request);

        Result<CaseDistrictResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("AllCaseDistricts", Name = "All Case Districts")]
    [ProducesResponseType(typeof(AllCaseDistrictResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllCaseDistricts(CancellationToken cancellationToken)
    {
        var command = new GetAllCaseDistrictQuery();

        Result<AllCaseDistrictResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("CaseDistrictById", Name = "Case District By Id")]
    [ProducesResponseType(typeof(CaseDistrictResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetCaseDistrictById(int id, CancellationToken cancellationToken)
    {
        var command = new GetCaseDistrictByIdQuery(id);

        Result<CaseDistrictResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [AllowAnonymous]
    [HttpGet("CaseDistrictInState", Name = "Case District In State")]
    [ProducesResponseType(typeof(AllCaseDistrictResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllCaseDistrictInStateQuery(int stateId, CancellationToken cancellationToken)
    {
        var command = new GetAllCaseDistrictInStateQuery(stateId);

        Result<AllCaseDistrictResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [AllowAnonymous]
    [HttpGet("CaseDistrictByName", Name = "Case District By Name")]
    [ProducesResponseType(typeof(AllCaseDistrictResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllCaseDistrictByNameQuery(string name, CancellationToken cancellationToken)
    {
        var command = new GetAllCaseDistrictByNameQuery(name);

        Result<AllCaseDistrictResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [AllowAnonymous]
    [HttpGet("CaseDistrictByNameInState", Name = "Case District By Name In State")]
    [ProducesResponseType(typeof(CaseDistrictResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetCaseDistrictByNameInStateQuery(string name, int stateId, CancellationToken cancellationToken)
    {
        var command = new GetCaseDistrictByNameInStateQuery(name, stateId);

        Result<CaseDistrictResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    #endregion

}
