using CMSSERVICE.INFRASTRUCTURE.OptionsConfiguration;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace CMSSERVICE.INFRASTRUCTURE.Extensions;

public static class DbConfigurationExtensions
{
    public static string BuildDbConnectionString(DatabaseOptions dbOptions)
    {
        var builder = new SqlConnectionStringBuilder
        {
            DataSource = string.Format("{0},{1}", dbOptions.DbHost, dbOptions.DbPort),
            InitialCatalog = dbOptions.DbName,
            UserID = dbOptions.DbUser,
            Password = dbOptions.DbPassword,
            ConnectTimeout = dbOptions.DbCommandTimeOut,
            TrustServerCertificate = dbOptions.DbTrustServerCertificate,
            MultiSubnetFailover = dbOptions.DbMultiSubnetFailover,
            MultipleActiveResultSets = dbOptions.DbMultipleActiveResultSets
        };
        return builder.ConnectionString;
    }

    public static string BuildDbConnectionString(this IConfiguration configuration)
    {
        var dbHost = ValueOrException(configuration, "CMS_DB_HOST");
        var dbName = ValueOrException(configuration, "CMS_DB_NAME");
        var dbUser = ValueOrException(configuration, "CMS_DB_USER");
        var dbPass = ValueOrException(configuration, "CMS_DB_PASS");

        var builder = new SqlConnectionStringBuilder
        {
            DataSource = dbHost,
            InitialCatalog = dbName,
            UserID = dbUser,
            Password = dbPass,
            ConnectTimeout = 300,
            TrustServerCertificate = false,
            MultiSubnetFailover = false
        };

        return builder.ConnectionString;
    }

    public static string BuildDbConnectionStringFromEnvironment(this IConfiguration configuration)
    {
        var dbHost = Environment.GetEnvironmentVariable("CMS_DB_HOST");
        var dbName = Environment.GetEnvironmentVariable("CMS_DB_NAME");
        var dbUser = Environment.GetEnvironmentVariable("CMS_DB_USER");
        var dbPass = Environment.GetEnvironmentVariable("CMS_DB_PASS");

        var builder = new SqlConnectionStringBuilder
        {
            DataSource = dbHost,
            InitialCatalog = dbName,
            UserID = dbUser,
            Password = dbPass,
            ConnectTimeout = 300,
            TrustServerCertificate = true
            ////MultiSubnetFailover = false
        };

        string? rtn = builder.ConnectionString;

        if (string.IsNullOrEmpty(rtn))
        {
            rtn = configuration.BuildDbConnectionString();
        }

        return rtn;
    }

    private static string ValueOrException(IConfiguration configuration, string configKey)
    {
        var value = configuration[configKey];
        return value!;
    }
}
