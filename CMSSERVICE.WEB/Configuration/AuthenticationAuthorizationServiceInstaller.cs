﻿using CMSSERVICE.INFRASTRUCTURE.Authentication.Middlewares;
using CMSSERVICE.WEB.AuthSetup;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace CMSSERVICE.WEB.Configuration;

public class AuthenticationAuthorizationServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        ////services.ConfigureOptions<JwtOptionsSetup>();
        ////services.ConfigureOptions<JwtBearerOptionsSetup>();

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

        services.AddAuthorization();
        ////services.AddSingleton<IAuthorizationHandler, ApiKeyAuthenticationHandler>();
        ////services.AddSingleton<IAuthorizationPolicyProvider, PermissionAuthorizationPolicyProvider>();
    }
}
