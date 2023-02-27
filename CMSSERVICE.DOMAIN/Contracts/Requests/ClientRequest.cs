namespace CMSSERVICE.DOMAIN.Contracts.Requests;

public record ClientRequest(
    string clientName,
    string clientAddress1,
    string? clientAddress2,
    string clientCity,
    string ccientState,
    string ccientZip,
    string ccientBillAddress1,
    string? cclientBillAddress2,
    string ccientBillCity,
    string ccientBillState,
    string ccientBillZip,
    string? clientMainContact,
    string? clientMailAlertLogEmail,
    string? plientLogoLocation,
    string? crovestClientCode,
    string? clientFax,
    string? clientPhone,
    bool? iseNativeTasksOnly,
    bool? isReverseClient);
