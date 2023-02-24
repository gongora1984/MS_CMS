using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace CMSSERVICE.INFRASTRUCTURE.Authentication;

public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement>
{
    private readonly IServiceScopeFactory _serviceScopeFactory;

    public PermissionAuthorizationHandler(IServiceScopeFactory serviceScopeFactory)
    {
        _serviceScopeFactory = serviceScopeFactory;
    }

    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
    {
        ////string? userId = context.User.Claims.FirstOrDefault(
        ////    x => x.Type == ClaimTypes.NameIdentifier)?.Value;

        ////if (!int.TryParse(userId, out int parsedUserId))
        ////{
        ////    return;
        ////}

        ////using IServiceScope scope = _serviceScopeFactory.CreateScope();

        ////IPermissionService permissionService = scope.ServiceProvider
        ////    .GetRequiredService<IPermissionService>();

        ////HashSet<string> permissions = await permissionService
        ////    .GetPermissionsAsync(parsedUserId);

        var permissions = context
            .User
            .Claims
            .Where(x => x.Type == CustomClaims.Permissions)
            .Select(x => x.Value)
            .ToHashSet();

        if (permissions.Contains(requirement.Permission))
        {
            context.Succeed(requirement);
        }

        return Task.CompletedTask;
    }

    ////protected override async Task HandleRequirementAsync(
    ////AuthorizationHandlerContext context,
    ////PermissionRequirement requirement)
    ////{
    ////    string? memberId = context.User.Claims.FirstOrDefault(
    ////        x => x.Type == ClaimTypes.NameIdentifier)?.Value;

    ////    if (!int.TryParse(memberId, out int parsedMemberId))
    ////    {
    ////        return;
    ////    }

    ////    using IServiceScope scope = _serviceScopeFactory.CreateScope();

    ////    IPermissionService permissionService = scope.ServiceProvider
    ////        .GetRequiredService<IPermissionService>();

    ////    HashSet<string> permissions = await permissionService
    ////        .GetPermissionsAsync(parsedMemberId);

    ////    if (permissions.Contains(requirement.Permission))
    ////    {
    ////        context.Succeed(requirement);
    ////    }
    ////}
}
