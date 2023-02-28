namespace CMSSERVICE.DOMAIN.Contracts.Responses.LawPratices;

public class LawPracticeResponse
{
    public int Id { get; set; }
    public string PracticeName { get; set; } = null!;
    public string PracticeContact { get; set; } = null!;
    public string Address1 { get; set; } = null!;
    public string? Address2 { get; set; }
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
    public string Zip { get; set; } = null!;
    public string? ContactBarNumber { get; set; }
    public string? PracticeLogoLocation { get; set; }
    public string? CurrentCmssystem { get; set; }
    public bool? HasDevelopmentStaff { get; set; }
    public bool? HasEfileAbility { get; set; }
    public int? NumberOfAttorneys { get; set; }
    public string? PaymentType { get; set; }
    public string? CardNumber { get; set; }
    public string? CardExpirationDate { get; set; }
    public string? CardName { get; set; }
    public string? CardDisplayNumber { get; set; }
    public string? ServiceEventsUrl { get; set; }
    public string? ServiceEventsLogon { get; set; }
    public string? ServiceEventsPass { get; set; }
    public string? ReferralCompanyCode { get; set; }
    public string? FirmStateCode { get; set; }
    public string? PhoneNumber { get; set; }
    public string? FaxNumber { get; set; }
    public int? ClientId { get; set; }
    public int PracticeTypeLid { get; set; }
}
