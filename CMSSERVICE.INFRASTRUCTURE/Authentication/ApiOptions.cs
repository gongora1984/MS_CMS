﻿namespace CMSSERVICE.INFRASTRUCTURE.Authentication;

public class ApiOptions
{
    public string ApiKeyHeaderName { get; init; }
    public string ApiKeyExpirationMinutes { get; init; }
}
