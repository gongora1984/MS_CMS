using Microsoft.AspNetCore.Authorization;

namespace CMSSERVICE.INFRASTRUCTURE.Authentication;

public class ClaimRequirement : IAuthorizationRequirement
{
    public ClaimRequirement(string claimDetail)
    {
        ClaimDetail = claimDetail;
    }

    public string ClaimDetail { get; }
}
