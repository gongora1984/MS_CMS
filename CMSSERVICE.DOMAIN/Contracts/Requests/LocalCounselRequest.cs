namespace CMSSERVICE.DOMAIN.Contracts.Requests;

public record LocalCounselRequest(
    string? lcName,
    string? lcCompanyName,
    string? lcPhoneNumber,
    string? lcEmailAddress,
    string? lcAddress1,
    string? lcAddress2,
    string? lcCity,
    string? lcState,
    string? lcZip,
    int? lcCountyId,
    bool? isLcactive,
    string? lcBarNumber,
    string? lcModuleType,
    string? lcFaxNumber,
    string? logoLocation,
    string? lcTrackingNumber
    );
