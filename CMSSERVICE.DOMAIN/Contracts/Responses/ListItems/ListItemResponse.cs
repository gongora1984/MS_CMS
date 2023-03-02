namespace CMSSERVICE.DOMAIN.Contracts.Responses.ListItems;

public class ListItemResponse
{
    public int Id { get; set; }
    public int? ClientId { get; set; }
    public int? LawPracticeId { get; set; }
    public string SystemCategory { get; set; } = null!;
    public string SystemTag { get; set; } = null!;
    public string DisplayText { get; set; } = null!;
    public string? Value1 { get; set; }
    public string? Value2 { get; set; }
    public int ListOrder { get; set; }
    public bool? Enabled { get; set; }
    public string? DefValue1 { get; set; }
    public string? DefValue2 { get; set; }
    public string? DefValue3 { get; set; }
    public string? DefValue4 { get; set; }
    public string? DefValue5 { get; set; }
    public string? DefValue6 { get; set; }
    public int? DefaultDateDays { get; set; }
    public string? MergeText { get; set; }
    public string? MergeValue { get; set; }
    public string? InvokeAssignment { get; set; }
}
