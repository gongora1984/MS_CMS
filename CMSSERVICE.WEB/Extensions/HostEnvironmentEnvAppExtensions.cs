namespace CMSSERVICE.WEB.Extensions;

public static class HostEnvironmentEnvAppExtensions
{
    /// <summary>
    /// Checks if the current host environment name is <see cref="Environments.Development"/>.
    /// </summary>
    /// <param name="hostEnvironment">An instance of <see cref="IHostEnvironment"/>.</param>
    /// <returns>True if the environment name is <see cref="Environments.Development"/>, otherwise false.</returns>
    public static bool IsDevelopmentEnv(this IHostEnvironment hostEnvironment)
    {
        return hostEnvironment?.IsEnvironment(Environments.Development)
               ?? throw new ArgumentNullException(nameof(hostEnvironment));
    }

    /// <summary>
    /// Checks if the current host environment name is <see cref="Environments.Qa"/>.
    /// </summary>
    /// <param name="hostEnvironment">An instance of <see cref="IHostEnvironment"/>.</param>
    /// <returns>True if the environment name is <see cref="Environments.Qa"/>, otherwise false.</returns>
    public static bool IsQaEnv(this IHostEnvironment hostEnvironment)
    {
        return hostEnvironment?.IsEnvironment(Environments.Qa)
               ?? throw new ArgumentNullException(nameof(hostEnvironment));
    }

    /// <summary>
    /// Checks if the current host environment name is <see cref="Environments.Uat"/>.
    /// </summary>
    /// <param name="hostEnvironment">An instance of <see cref="IHostEnvironment"/>.</param>
    /// <returns>True if the environment name is <see cref="Environments.Uat"/>, otherwise false.</returns>
    public static bool IsUatEnv(this IHostEnvironment hostEnvironment)
    {
        return hostEnvironment?.IsEnvironment(Environments.Uat)
               ?? throw new ArgumentNullException(nameof(hostEnvironment));
    }

    /// <summary>
    /// Checks if the current host environment name is <see cref="Environments.Production"/>.
    /// </summary>
    /// <param name="hostEnvironment">An instance of <see cref="IHostEnvironment"/>.</param>
    /// <returns>True if the environment name is <see cref="Environments.Production"/>, otherwise false.</returns>
    public static bool IsProductionEnv(this IHostEnvironment hostEnvironment)
    {
        return hostEnvironment?.IsEnvironment(Environments.Production)
               ?? throw new ArgumentNullException(nameof(hostEnvironment));
    }

    public static class Environments
    {
        public static readonly string Development = "Development";
        public static readonly string Qa = "qa";
        public static readonly string Uat = "uat";
        public static readonly string Production = "prod";
    }
}
