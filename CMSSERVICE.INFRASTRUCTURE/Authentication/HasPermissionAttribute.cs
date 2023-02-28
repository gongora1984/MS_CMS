using Microsoft.AspNetCore.Authorization;

namespace CMSSERVICE.INFRASTRUCTURE.Authentication;

public sealed class HasPermissionAttribute : AuthorizeAttribute
{
    public HasPermissionAttribute(string permission)
        : base(policy: permission)
    {
    }
}
