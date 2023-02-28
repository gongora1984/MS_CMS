namespace CMSSERVICE.DOMAIN.Contracts.Requests;

public record ClientRequest(
    string clientName,
    string clientAddress1,
    string? clientAddress2,
    string clientCity,
    string clientState,
    string clientZip,
    string clientBillAddress1,
    string? cllientBillAddress2,
    string clientBillCity,
    string clientBillState,
    string clientBillZip,
    string? clientMainContact,
    string? clientMailAlertLogEmail,
    string? plientLogoLocation,
    string? crovestClientCode,
    string? clientFax,
    string? clientPhone,
    bool? iseNativeTasksOnly,
    bool? isReverseClient);
