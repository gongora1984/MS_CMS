using CMSSERVICE.APPLICATION.Persistence.Accounts.Commands.PermissionCommands;
using CMSSERVICE.APPLICATION.Persistence.Accounts.Queries.PermissionQueries;
using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.AppPermissions;
using CMSSERVICE.INFRASTRUCTURE.Authentication;
using CMSSERVICE.PRESENTATION.Abstractions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace CMSSERVICE.PRESENTATION.Controllers;

[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},ApiKey")]
[Route("api/Permission")]
public sealed class PermissionController : ApiController
{
    public PermissionController(ISender sender)
        : base(sender)
    {
    }

    [HttpPost("CreateRole", Name = "Create Role")]
    [ProducesResponseType(typeof(RoleResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HasPermission("Admin")]
    public async Task<IActionResult> CreateRole(
    [FromBody] RoleRequest request,
    CancellationToken cancellationToken)
    {
        var command = new RegisterRoleCommand(request);

        Result<RoleResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [HttpPost("CreatePermission", Name = "Create Permission")]
    [ProducesResponseType(typeof(PermissionResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HasPermission("Admin")]
    public async Task<IActionResult> CreatePermission(
        [FromBody] PermissionRequest request,
        CancellationToken cancellationToken)
    {
        var command = new RegisterPermissionCommand(request);

        Result<PermissionResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [HttpPost("CreateRolePermission", Name = "Create Role Permission")]
    [ProducesResponseType(typeof(IEnumerable<RolePermissionResponse>), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HasPermission("Admin")]
    public async Task<IActionResult> CreateRolePermission(
    [FromBody] RolePermissionRequest request,
    CancellationToken cancellationToken)
    {
        var command = new RegisterRolePermissionCommand(request);

        Result<IEnumerable<RolePermissionResponse>> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [HttpPost("CreateUserRole", Name = "Create User Role")]
    [ProducesResponseType(typeof(IEnumerable<UserRoleResponse>), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HasPermission("Admin")]
    public async Task<IActionResult> CreateRolePermission(
            [FromBody] UserRoleRequest request,
            CancellationToken cancellationToken)
    {
        var command = new RegisterUserRoleCommand(request);

        Result<IEnumerable<UserRoleResponse>> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("AllRoles", Name = "All Roles")]
    [ProducesResponseType(typeof(AllRoleResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllRoles(CancellationToken cancellationToken)
    {
        var command = new GetAllRoleQuery();

        Result<AllRoleResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("AllPermissions", Name = "All Permissions")]
    [ProducesResponseType(typeof(RolePermissionResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllPermissions(CancellationToken cancellationToken)
    {
        var command = new GetAllPermissionQuery();

        Result<AllPermissionResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("AllRolePermission", Name = "All Roles Permission")]
    [ProducesResponseType(typeof(AllRolePermissionResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllRolePermission(CancellationToken cancellationToken)
    {
        var command = new GetAllRolePermissionQuery();

        Result<AllRolePermissionResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("RoleById/{id:int}", Name = "Role By Id")]
    [ProducesResponseType(typeof(RoleResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetPermissionById(int id, CancellationToken cancellationToken)
    {
        var command = new GetRoleByIdQuery(id);

        Result<RoleResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [AllowAnonymous]
    [HttpGet("PermissionById/{id:int}", Name = "Permission By Id")]
    [ProducesResponseType(typeof(PermissionResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetRoleById(int id, CancellationToken cancellationToken)
    {
        var command = new GetPermissionByIdQuery(id);

        Result<PermissionResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [AllowAnonymous]
    [HttpGet("RolePermissionById/{id:int}", Name = "Role Permission By Id")]
    [ProducesResponseType(typeof(RolePermissionResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetRolePermissionById(int id, CancellationToken cancellationToken)
    {
        var command = new GetRolePermissionByIdQuery(id);

        Result<RolePermissionResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [AllowAnonymous]
    [HttpGet("RoleByName/{name}", Name = "Role By Name")]
    [ProducesResponseType(typeof(RoleResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetRoleByName(string name, CancellationToken cancellationToken)
    {
        var command = new GetRoleByNameQuery(name);

        Result<RoleResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [AllowAnonymous]
    [HttpGet("PermissionByName/{name}", Name = "Permission By Name")]
    [ProducesResponseType(typeof(PermissionResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetPermissionByName(string name, CancellationToken cancellationToken)
    {
        var command = new GetPermissionByNameQuery(name);

        Result<PermissionResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }
}
