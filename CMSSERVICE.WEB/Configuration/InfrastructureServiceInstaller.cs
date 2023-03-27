using CMSSERVICE.INFRASTRUCTURE.OptionsConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Scrutor;

namespace CMSSERVICE.WEB.Configuration;

public class InfrastructureServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services
            .Scan(
                selector => selector
                    .FromAssemblies(
                        AssemblyReference.Assembly)
                    .AddClasses(false)
                    .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                    .AsMatchingInterface()
                    .WithScopedLifetime());

        //// services.AddSingleton<ConvertDomainEventsToOutboxMessagesInterceptor>();

        ////services.AddSingleton<UpdateAuditableEntitiesInterceptor>();

        services.AddDbContext<ApplicationDbContext>(
            (sp, optionsBuilder) =>
            {
                var databaseOptions = sp.GetService<IOptions<DatabaseOptions>>()!.Value;
                ////string dbConnectionString = configuration.BuildDbConnectionString();
                string dbConnectionString = INFRASTRUCTURE.Extensions.DbConfigurationExtensions.BuildDbConnectionString(databaseOptions);
                optionsBuilder.UseSqlServer(
                    dbConnectionString,
                    builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
                    .EnableRetryOnFailure(databaseOptions.DbMaxRetryCount)
                    .CommandTimeout(databaseOptions.DbCommandTimeOut));

                optionsBuilder.EnableDetailedErrors(databaseOptions.DbEnableDetailedError);
                optionsBuilder.EnableSensitiveDataLogging(databaseOptions.DbEnableSensitiveDataLogging);
            });

        services.AddScoped<ApplicationDbContextInitializer>();
    }
}
