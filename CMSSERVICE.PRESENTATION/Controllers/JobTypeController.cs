using CMSSERVICE.APPLICATION.Persistence.JobTypes.Commands;
using CMSSERVICE.APPLICATION.Persistence.JobTypes.Queries;
using CMSSERVICE.DOMAIN.Contracts.Responses.JobTypes;

namespace CMSSERVICE.PRESENTATION.Controllers;

[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},ApiKey")]
[Route("api/JobType")]
public sealed class JobTypeController : ApiController
{
    public JobTypeController(ISender sender)
        : base(sender)
    {
    }

    #region JOB TYPE METHODS
    [HttpPost("CreateJobType", Name = "Create Job Type")]
    [ProducesResponseType(typeof(JobTypeResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HasPermission("Admin")]
    public async Task<IActionResult> CreateJobType(
    [FromBody] JobTypeRequest request,
    CancellationToken cancellationToken)
    {
        var command = new RegisterJobTypeCommand(request);

        Result<JobTypeResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("AllJobType", Name = "All Job Types")]
    [ProducesResponseType(typeof(AllJobTypeResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllJobType(CancellationToken cancellationToken)
    {
        var command = new GetAllJobTypeQuery();

        Result<AllJobTypeResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("JobTypeById", Name = "Job Type By Id")]
    [ProducesResponseType(typeof(JobTypeResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetJobTypeById(int id, CancellationToken cancellationToken)
    {
        var command = new GetJobTypeByIdQuery(id);

        Result<JobTypeResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [AllowAnonymous]
    [HttpGet("JobTypeByName", Name = "Job Type By Name")]
    [ProducesResponseType(typeof(JobTypeResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetJobTypeByName(string name, CancellationToken cancellationToken)
    {
        var command = new GetJobTypeByNameQuery(name);

        Result<JobTypeResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [AllowAnonymous]
    [HttpGet("JobTypeBySysCode", Name = "Job Type By SysCode")]
    [ProducesResponseType(typeof(JobTypeResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetJobTypeBySysCode(string syscode, CancellationToken cancellationToken)
    {
        var command = new GetJobTypeBySysCodeQuery(syscode);

        Result<JobTypeResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }
    #endregion
}
