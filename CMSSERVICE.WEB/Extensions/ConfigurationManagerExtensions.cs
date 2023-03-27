namespace CMSSERVICE.WEB.Extensions;

using static HostEnvironmentEnvAppExtensions.Environments;

public static class ConfigurationManagerExtensions
{
    public static ConfigurationManager ConfigureEnvironment(this ConfigurationManager configuration, IWebHostEnvironment environment)
    {
        // add RAS environment variables
        configuration.AddEnvironmentVariables("CMS_");

        // environments settings
        if (environment.IsDevelopmentEnv())
        {
            AddJsonFile(Development);
        }

        if (environment.IsQaEnv())
        {
            AddJsonFile(Qa);
        }

        if (environment.IsUatEnv())
        {
            AddJsonFile(Uat);
        }

        if (environment.IsProductionEnv())
        {
            AddJsonFile(Production);
        }

        return configuration;

        void AddJsonFile(string envName) => configuration.AddJsonFile($"appsettings.{envName}.json", optional: true);
    }
}
