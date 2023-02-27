namespace CMSSERVICE.DOMAIN.Contracts.Responses.Clients;

public class ClientResponse
{
    public int Id { get; set; }
    public string ClientName { get; set; } = null!;
    public string ClientAddress1 { get; set; } = null!;
    public string? ClientAddress2 { get; set; }
    public string ClientCity { get; set; } = null!;
    public string ClientState { get; set; } = null!;
    public string ClientZip { get; set; } = null!;
    public string ClientBillAddress1 { get; set; } = null!;
    public string? ClientBillAddress2 { get; set; }
    public string ClientBillCity { get; set; } = null!;
    public string ClientBillState { get; set; } = null!;
    public string ClientBillZip { get; set; } = null!;
    public string? ClientMainContact { get; set; }
    public string? ClientMailAlertLogEmail { get; set; }
    public string? ClientLogoLocation { get; set; }
    public string? ProvestClientCode { get; set; }
    public string? ClientFax { get; set; }
    public string? ClientPhone { get; set; }
    public bool? UseNativeTasksOnly { get; set; }
    public bool? IsReverseClient { get; set; }
}
