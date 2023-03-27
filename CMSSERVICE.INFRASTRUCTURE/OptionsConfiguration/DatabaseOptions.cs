namespace CMSSERVICE.INFRASTRUCTURE.OptionsConfiguration;

public class DatabaseOptions
{
    public string DbHost { get; init; }
    public string DbName { get; init; }
    public string DbUser { get; init; }
    public string DbPassword { get; init; }
    public int DbPort { get; init; }
    public int DbMaxRetryCount { get; init; }
    public int DbCommandTimeOut { get; init; }
    public bool DbEnableDetailedError { get; init; }
    public bool DbEnableSensitiveDataLogging { get; init; }
    public bool DbTrustServerCertificate { get; init; }
    public bool DbMultiSubnetFailover { get; init; }
    public bool DbMultipleActiveResultSets { get; init; }
}
