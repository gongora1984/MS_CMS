using CMSSERVICE.INFRASTRUCTURE.Authentication.Middlewares;
using CMSSERVICE.WEB.AuthSetup;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace CMSSERVICE.WEB.Configuration;

public class AuthenticationAuthorizationServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services.ConfigureOptions<JwtOptionsSetup>();
        services.ConfigureOptions<JwtBearerOptionsSetup>();

        services.ConfigureOptions<ApiOptionsSetup>();
        services.ConfigureOptions<ApiBearerOptionsSetup>();

        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer()
            .AddScheme<AuthenticationSchemeOptions, ApiKeyAuthenticationHandler>(
                "ApiKey",
                options => { });

        ////services.AddAuthentication("ApiKey")
        ////    .AddScheme<AuthenticationSchemeOptions, ApiKeyAuthenticationHandler>(
        ////        "ApiKey",
        ////        options => { });

        services.AddAuthorization(options =>
        {
            options.AddPolicy(
                "AdminPolicy",
                policy => policy.AddRequirements(new ClaimRequirement("Admin")));

            options.AddPolicy(
                "ClientPolicy",
                policy => policy.AddRequirements(new ClaimRequirement("Client")));

            options.AddPolicy(
                "LawPractice",
                policy => policy.AddRequirements(new ClaimRequirement("LawPractice")));

            options.AddPolicy(
                "LocalCounselPolicy",
                policy => policy.AddRequirements(new ClaimRequirement("LocalCounsel")));
        });

        ////services.AddSingleton<IAuthorizationHandler, ApiKeyAuthenticationHandler>();
        ////services.AddSingleton<IAuthorizationPolicyProvider, PermissionAuthorizationPolicyProvider>();
        services.AddSingleton<IAuthorizationHandler, ClaimRequirementAuthorizationHandler>();
    }
}
