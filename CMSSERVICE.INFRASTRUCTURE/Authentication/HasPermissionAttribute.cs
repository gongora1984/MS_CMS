using CMSSERVICE.DOMAIN.Enums;
using Microsoft.AspNetCore.Authorization;

namespace CMSSERVICE.INFRASTRUCTURE.Authentication;

public sealed class HasPermissionAttribute : AuthorizeAttribute
{
    public HasPermissionAttribute(Permission permission)
        : base(policy: permission.ToString())
    {
    }
}
