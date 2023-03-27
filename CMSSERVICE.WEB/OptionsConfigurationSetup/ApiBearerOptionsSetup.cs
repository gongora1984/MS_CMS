using CMSSERVICE.INFRASTRUCTURE.OptionsConfiguration;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;

namespace CMSSERVICE.WEB.OptionsConfigurationSetup;

public class ApiBearerOptionsSetup : IPostConfigureOptions<AuthenticationSchemeOptions>
{
    private readonly ApiOptions _apiOptions;

    public ApiBearerOptionsSetup(IOptions<ApiOptions> apiOptions)
    {
        _apiOptions = apiOptions.Value;
    }

    public void PostConfigure(string? name, AuthenticationSchemeOptions options)
    {
        ////
    }
}
