using CMSSERVICE.INFRASTRUCTURE.OptionsConfiguration;
using Microsoft.Extensions.Options;

namespace CMSSERVICE.WEB.OptionsConfigurationSetup;

public class DatabaseOptionsSetup : IConfigureOptions<DatabaseOptions>
{
    private const string SectionName = "DatabaseConfig";
    private readonly IConfiguration _configuration;

    public DatabaseOptionsSetup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Configure(DatabaseOptions options)
    {
        _configuration.GetSection(SectionName).Bind(options);
    }
}
