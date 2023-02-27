namespace CMSSERVICE.DOMAIN.Contracts.Responses.LocalCounsels;

public class LocalCounselResponse
{
    public int Id { get; set; }
    public string? Lcname { get; set; }
    public string? LccompanyName { get; set; }
    public string? LcphoneNumber { get; set; }
    public string? LcemailAddress { get; set; }
    public string? Lcaddress1 { get; set; }
    public string? Lcaddress2 { get; set; }
    public string? Lccity { get; set; }
    public string? Lcstate { get; set; }
    public string? Lczip { get; set; }
    public int? LccountyId { get; set; }
    public bool? IsLcactive { get; set; }
    public string? LcbarNumber { get; set; }
    public string? LcmoduleType { get; set; }
    public string? LcfaxNumber { get; set; }
    public string? LogoLocation { get; set; }
    public string? LctrackingNumber { get; set; }
}
