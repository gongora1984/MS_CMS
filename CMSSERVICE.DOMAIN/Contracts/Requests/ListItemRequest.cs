namespace CMSSERVICE.DOMAIN.Contracts.Requests;

public record ListItemRequest(
    int? ClientId,
    int? LawPracticeId,
    string SystemCategory,
    string SystemTag,
    string DisplayText,
    string? Value1,
    string? Value2,
    string? DefValue1,
    string? DefValue2,
    string? DefValue3,
    string? DefValue4,
    string? DefValue5,
    string? DefValue6,
    int? DefaultDateDays,
    string? MergeText,
    string? MergeValue,
    string? InvokeAssignment);
