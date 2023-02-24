using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace CMSSERVICE.INFRASTRUCTURE.Authentication;

public class ClaimRequirementAuthorizationHandler : AuthorizationHandler<ClaimRequirement>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ClaimRequirement requirement)
    {
        string? roleData = context.User.Claims.FirstOrDefault(
            x => x.Type == ClaimTypes.Role)?.Value;

        if (string.IsNullOrEmpty(roleData))
        {
            return Task.CompletedTask;
        }

        context.Succeed(requirement);

        return Task.CompletedTask;
    }
}
